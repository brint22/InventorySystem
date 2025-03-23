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
                INSERT INTO EmployeeImage (EmployeeImage) 
                OUTPUT INSERTED.ImageID
                VALUES (@EmployeeImage)";

                        int imageID = connection.ExecuteScalar<int>(imageQuery, new { EmployeeImage = imageBytes }, transaction);

                        if (imageID <= 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to store employee image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Generate EmployeeID
                        string generatedID = GenerateID();
                        employees.EmployeeID = generatedID;
                        employees.RoleID = GetRoleID();

                        // Insert into Employee table with the ImageID reference
                        string employeeQuery = @"
                INSERT INTO Employee 
                (EmployeeID, FirstName, MiddleName, LastName, NameExtension, DateOfBirth, Address, RoleID, ImageID)
                VALUES
                (@EmployeeID, @FirstName, @MiddleName, @LastName, @NameExtension, @DateOfBirth, @Address, @RoleID, @ImageID);";

                        int employeeRows = connection.Execute(employeeQuery, new
                        {
                            employees.EmployeeID,
                            employees.FirstName,
                            employees.MiddleName,
                            employees.LastName,
                            employees.NameExtension,
                            employees.DateOfBirth,
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
                    SELECT [RoleID], [RoleName] 
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
                DateOfBirth = deDateOfBirth.DateTime,
                Address = teAddress.Text,
                RoleName = lueRole.Text
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
        }

   
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            LoadRole();
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