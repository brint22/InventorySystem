using DevExpress.XtraBars;
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
using DevExpress.XtraPrinting.Native;
using System.Net;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Net;
using DevExpress.XtraLayout.Customization;

namespace InventorySystem.Employees
{
    public partial class AddEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddEmployee()
        {
            InitializeComponent();
        }


        private void RegisterEmployee(Employee employees, byte[] imageBytes)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Validate input
                        if (employees == null || imageBytes == null)
                        {
                            MessageBox.Show("Employee details and image data cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Insert image into EmployeeImage table
                        string imageQuery = @"
                        INSERT INTO EmployeeImage (ImageData) 
                        OUTPUT INSERTED.ImageID
                        VALUES (@ImageData)";

                        int imageID = connection.ExecuteScalar<int>(imageQuery, new { ImageData = imageBytes }, transaction);

                        if (imageID <= 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to store employee image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Generate EmployeeID
                        string generatedID = GenerateID();
                        employees.EmployeeID = generatedID;

                        // Insert into Employee table with the ImageID reference
                        string employeeQuery = @"
                            INSERT INTO Employee 
                            (EmployeeID, 
                            FirstName, 
                            MiddleName, 
                            LastName, 
                            NameExtension, 
                            Gender, 
                            CivilStatus,
                            DateOfBirth, 
                            Age, 
                            PhoneNumber, 
                            DateHired, 
                            Address, 
                            RoleID, 
                            ImageID)

                            VALUES
                            (@EmployeeID, 
                            @FirstName, 
                            @MiddleName, 
                            @LastName, 
                            @NameExtension, 
                            @Gender, 
                            @CivilStatus, 
                            @DateOfBirth, 
                            DATEDIFF(YEAR, @DateOfBirth, CAST(GETDATE() AS DATE)) - 
                            CASE 
                                 WHEN MONTH(@DateOfBirth) > MONTH(CAST(GETDATE() AS DATE)) 
                                   OR (MONTH(@DateOfBirth) = MONTH(CAST(GETDATE() AS DATE)) 
                                   AND DAY(@DateOfBirth) > DAY(CAST(GETDATE() AS DATE))) 
                                 THEN 1 ELSE 0 
                            END,
                            @PhoneNumber,
                            @DateHired, 
                            @Address, 
                            @RoleID, 
                            @ImageID);";
                        int employeeRows = connection.Execute(employeeQuery, new
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
                            ImageID = imageID // Link the image to the employee
                        }, transaction);

                        if (employeeRows == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Employee registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Commit transaction
                        transaction.Commit();
                        MessageBox.Show("Employee registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //private static string GenerateID()
        //{
        //    Random random = new Random();
        //    string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    string id = string.Empty;

        //    for (int i = 0; i < 4; i++)
        //    {
        //        id += letters[random.Next(letters.Length)];
        //        id += random.Next(0, 8);

        //    }
        //    return id;
        //}

        public string GenerateID()
        {
            int year = DateTime.Now.Year;
            int lastNumber = GetLastNumberFromDB(year);
            int newNumber = lastNumber + 1;

            return $"{year}-{newNumber:D4}"; // Ensures 4-digit formatting (e.g., 2025-0001)
        }

        private int GetLastNumberFromDB(int year)
        {
            using (IDbConnection db = new SqlConnection(GlobalClass.connectionString))
            {
                string query = @"
                SELECT TOP 1 CAST(RIGHT(EmployeeID, 4) AS INT) 
                FROM Employee 
                WHERE EmployeeID LIKE @YearPattern
                ORDER BY EmployeeID DESC";

                return db.QueryFirstOrDefault<int?>(query, new { YearPattern = $"{year}-%" }) ?? 0;
            }
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
                RoleID = GetRoleID(),
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
            RegisterEmployee(employee, imageBytes);
            ClearInputs();
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



        //Method ign getting the Gender
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

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            LoadRole();
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

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}