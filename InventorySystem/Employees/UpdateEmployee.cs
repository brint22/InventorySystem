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
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Validate input
                        if (employees == null)
                        {
                            MessageBox.Show("Employee details cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Check if employee exists
                        string checkQuery = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID";
                        int employeeExists = connection.ExecuteScalar<int>(checkQuery, new { employees.EmployeeID }, transaction);

                        if (employeeExists == 0)
                        {
                            MessageBox.Show("Employee record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int imageID = 0; // Default ImageID

                        // If a new image is provided, update EmployeeImage table
                        if (imageBytes != null)
                        {
                            string imageQuery = @"
                    IF EXISTS (SELECT 1 FROM Employee WHERE EmployeeID = @EmployeeID AND ImageID IS NOT NULL)
                    BEGIN
                        UPDATE EmployeeImage
                        SET ImageData = @ImageData
                        WHERE ImageID = (SELECT ImageID FROM Employee WHERE EmployeeID = @EmployeeID)
                    END
                    ELSE
                    BEGIN
                        INSERT INTO EmployeeImage (ImageData) 
                        OUTPUT INSERTED.ImageID
                        VALUES (@ImageData)
                    END";

                            imageID = connection.ExecuteScalar<int>(imageQuery, new { ImageData = imageBytes, employees.EmployeeID }, transaction);
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
                    " + (imageBytes != null ? ", ImageID = @ImageID" : "") + @"
                WHERE EmployeeID = @EmployeeID";

                        int rowsUpdated = connection.Execute(updateQuery, new
                        {
                            employees.EmployeeID,
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
                            employees.RoleID,
                            ImageID = imageID > 0 ? imageID : (object)DBNull.Value // Assign ImageID only if updated
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
            // Create an employee object
            Employee employee = new Employee
            {
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

            GetRoleID();

            // Read image from selected path
            string imagePath = meEmployeeImagePath.Text.Trim();
            byte[] imageBytes = File.Exists(imagePath) ? File.ReadAllBytes(imagePath) : null;

            if (imageBytes == null)
            {
                MessageBox.Show("Invalid image file. Please select a valid image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Register employee and store image
            UpdateEmployeeInformation(employee, imageBytes);
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