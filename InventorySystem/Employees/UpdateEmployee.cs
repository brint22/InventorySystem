using DevExpress.XtraEditors;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.IO;
using System.Drawing;

namespace InventorySystem.Employees
{
    public partial class UpdateEmployee : DevExpress.XtraEditors.XtraForm
    {
        public string EmployeeID { get; set; }

        private ViewEmployee viewEmployee;
        public UpdateEmployee(string employeeID, ViewEmployee viewEmployee)
        {
            InitializeComponent();
            this.EmployeeID = employeeID;
            this.viewEmployee = viewEmployee;
        }
        private void LoadRole()
        {
            string connStr = GlobalClass.connectionString;

            string query = @"
            SELECT [RoleID], 
                   CONCAT(UPPER(LEFT([RoleName], 1)), LOWER(SUBSTRING([RoleName], 2, LEN([RoleName]) - 1))) AS RoleName
            FROM [Role];";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var role = connection.Query<Role>(query).ToList();

                    if (role.Any())
                    {
                        lueRole.Properties.DataSource = role;
                        lueRole.Properties.DisplayMember = "RoleName";
                        lueRole.Properties.ValueMember = "RoleID";
                    }
                    else
                    {
                        lueRole.Properties.DataSource = null;
                        XtraMessageBox.Show("No departments found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            LoadRole();
        }

        private void UpdateEmployeeInformation(Employee employees, byte[] imageBytes)
        {
            if (employees == null || string.IsNullOrWhiteSpace(employees.EmployeeID))
            {
                MessageBox.Show("Employee details cannot be null or EmployeeID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string employeeID = employees.EmployeeID.Trim(); // Trim to remove extra spaces

                        // Check if employee exists
                        string checkQuery = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID";
                        int employeeExists = connection.ExecuteScalar<int>(checkQuery, new { EmployeeID = employeeID }, transaction);

                        if (employeeExists == 0)
                        {
                            MessageBox.Show("Employee record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int imageID = connection.ExecuteScalar<int>("SELECT ImageID FROM Employee WHERE EmployeeID = @EmployeeID",
                            new { EmployeeID = employeeID }, transaction);

                        // If a new image is provided, update or insert it
                        if (imageBytes != null)
                        {
                            if (imageID > 0)
                            {
                                // If an image already exists, update it
                                string updateImageQuery = "UPDATE EmployeeImage SET ImageData = @ImageData WHERE ImageID = @ImageID";
                                connection.Execute(updateImageQuery, new { ImageData = imageBytes, ImageID = imageID }, transaction);
                            }
                            else
                            {
                                // If no existing image, insert a new one and get the new ImageID
                                string insertImageQuery = "INSERT INTO EmployeeImage (ImageData) OUTPUT INSERTED.ImageID VALUES (@ImageData)";
                                imageID = connection.ExecuteScalar<int>(insertImageQuery, new { ImageData = imageBytes }, transaction);

                                // Assign the new ImageID to the employee
                                string updateEmployeeImageIDQuery = "UPDATE Employee SET ImageID = @ImageID WHERE EmployeeID = @EmployeeID";
                                connection.Execute(updateEmployeeImageIDQuery, new { ImageID = imageID, EmployeeID = employeeID }, transaction);
                            }
                        }

                        // Update Employee details
                        string updateQuery = @"
                    UPDATE Employee 
                    SET 
                        FirstName = @FirstName, 
                        MiddleName = @MiddleName, 
                        LastName = @LastName, 
                        NameExtension = @NameExtension, 
                        Gender = @Gender, 
                        CivilStatus = @CivilStatus,
                        DateOfBirth = @DateOfBirth, 
                        Age = DATEDIFF(YEAR, @DateOfBirth, CAST(GETDATE() AS DATE)) - 
                            CASE 
                                WHEN MONTH(@DateOfBirth) > MONTH(CAST(GETDATE() AS DATE)) 
                                    OR (MONTH(@DateOfBirth) = MONTH(CAST(GETDATE() AS DATE)) 
                                    AND DAY(@DateOfBirth) > DAY(CAST(GETDATE() AS DATE))) 
                                THEN 1 ELSE 0 
                            END,
                        PhoneNumber = @PhoneNumber, 
                        DateHired = @DateHired, 
                        Address = @Address, 
                        RoleID = @RoleID
                    WHERE EmployeeID = @EmployeeID";

                        int rowsUpdated = connection.Execute(updateQuery, new
                        {
                            EmployeeID = employeeID,
                            employees.FirstName,
                            employees.MiddleName,
                            employees.LastName,
                            employees.NameExtension,
                            employees.Gender,
                            employees.CivilStatus,
                            employees.DateOfBirth,
                            employees.PhoneNumber,
                            employees.DateHired,
                            employees.Address,
                            employees.RoleID
                        }, transaction);

                        if (rowsUpdated == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Employee update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Commit transaction
                        transaction.Commit();
                        MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Update failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Create an employee object (similar to the Insert code)
            Employee employee = new Employee
            {
                EmployeeID = teEmployeeID.Text,
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                NameExtension = teNameExtension.Text,
                Gender = GetGender().ToString(),
                CivilStatus = cbCivilStatus.Text,
                DateOfBirth = deDateOfBirth.DateTime,
                PhoneNumber = tePhoneNumber.Text,
                DateHired = deDateHired.DateTime,
                RoleName = lueRole.Text,
                Address = mmAddress.Text
            };

            // Get Role ID (you may need to check if this method already returns the correct value)
            GetRoleID();

            // Read image from selected path (same as insert)
            string imagePath = meEmployeeImagePath.Text.Trim();
            if (!File.Exists(imagePath))
            {
                MessageBox.Show("The selected image file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imageBytes = null;
            try
            {
                imageBytes = File.ReadAllBytes(imagePath);
                // Validate if the image can be loaded
                using (System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath)) { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid image file. Please select a valid image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update employee information (similar to Insert but calling an Update method instead)
            UpdateEmployeeInformation(employee, imageBytes);

            // Clear the input fields after the update
            ClearInputs();
        }

        private string GetGender()
        {
            string gender = "";
            if (rdGender.SelectedIndex == 0)
            {
                gender = "Male";

            }
            else
            {
                gender = "Female";
            }
            return gender;
        }

        private int GetRoleID()
        {
            int intRoleID = 0;

            if (lueRole.EditValue != null)
            {
                intRoleID = (int)lueRole.EditValue;

            }
            else
            {
                intRoleID = 0;
            }
            return intRoleID;
        }

        private void ClearInputs()
        {
            teFirstName.Text = string.Empty;
            teMiddleName.Text = string.Empty;
            teLastName.Text = string.Empty;
            teNameExtension.Text = string.Empty;
            rdGender.Text = string.Empty;
            cbCivilStatus.Text = string.Empty;
            deDateOfBirth.Text = string.Empty;
            tePhoneNumber.Text = string.Empty;
            deDateHired.Text = string.Empty;
            lueRole.Text = string.Empty;
            mmAddress.Text = string.Empty;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (meEmployeeImagePath != null)
                    {
                        meEmployeeImagePath.Text = filePath;
                    }
                    else
                    {
                        MessageBox.Show("Error: TextBox 'meEmployeeImagePath' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ✅ Display the selected image in the PictureEdit control
                    if (peProfile != null)
                    {
                        peProfile.Image = System.Drawing.Image.FromFile(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Error: PictureEdit 'peProfile' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}