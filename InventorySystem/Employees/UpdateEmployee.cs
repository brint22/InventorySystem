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
using DevExpress.XtraReports.UI;

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
            gcAddress.DataSource = CreateAddressTable();

        }

        private void UpdateEmployeeInformation(Employee employees, byte[] imageBytes, string employeeImagePath, Address address)
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

                        // Only update image if image path is not empty and the file exists
                        if (!string.IsNullOrEmpty(employeeImagePath) && File.Exists(employeeImagePath))
                        {
                            // Read the image file as a byte array
                            imageBytes = File.ReadAllBytes(employeeImagePath);

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

                        // Update address
                        if (address != null)
                        {
                            string addressQuery = @"
                        UPDATE Address
                        SET BarangayName = @BarangayName, MunicipalityName = @MunicipalityName, ProvinceName = @ProvinceName, 
                            ZipCodeNumber = @ZipCodeNumber, CountryName = @CountryName
                        WHERE AddressID = (SELECT AddressID FROM Employee WHERE EmployeeID = @EmployeeID)";

                            connection.Execute(addressQuery, new
                            {
                                BarangayName = address.BarangayName,
                                MunicipalityName = address.MunicipalityName,
                                ProvinceName = address.ProvinceName,
                                ZipCodeNumber = address.ZipCodeNumber,
                                CountryName = address.CountryName,
                                EmployeeID = employeeID
                            }, transaction);
                        }

                        // Update Employee details (always update even if image or address are not updated)
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


        // At the top of your form class (outside the method)
        public event EventHandler EmployeeUpdated;

        private void BtnSubmit_Click(object sender, EventArgs e)
        {    // Validate required fields (except NameExtension)
            if (string.IsNullOrWhiteSpace(teEmployeeID.Text))
            {
                MessageBox.Show("Employee ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teMiddleName.Text))
            {
                MessageBox.Show("Middle Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cbCivilStatus.Text))
            {
                MessageBox.Show("Civil Status is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deDateOfBirth.EditValue == null)
            {
                MessageBox.Show("Date of Birth is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tePhoneNumber.Text))
            {
                MessageBox.Show("Phone Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deDateHired.EditValue == null)
            {
                MessageBox.Show("Date Hired is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (GetRoleID() == 0)
            {
                MessageBox.Show("Please select a valid Role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teBarangayName.Text))
            {
                MessageBox.Show("Barangay Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teMunicipalityName.Text))
            {
                MessageBox.Show("Municipality Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teProvinceName.Text))
            {
                MessageBox.Show("Province Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teZipCodeNumber.Text) || !int.TryParse(teZipCodeNumber.Text, out _))
            {
                MessageBox.Show("A valid Zip Code Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teCountryName.Text))
            {
                MessageBox.Show("Country Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create an employee object
            Employee employee = new Employee
            {
                EmployeeID = teEmployeeID.Text,
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                NameExtension = teNameExtension.Text, // Not required
                Gender = GetGender().ToString(),
                CivilStatus = cbCivilStatus.Text,
                DateOfBirth = deDateOfBirth.DateTime,
                PhoneNumber = tePhoneNumber.Text,
                DateHired = deDateHired.DateTime,
                RoleID = GetRoleID()
            };

    string imagePath = meEmployeeImagePath.Text.Trim();
    byte[] imageBytes = null;

            // If the image path is not empty and the file exists, read the image bytes
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    // Read the image file as byte array
                    imageBytes = File.ReadAllBytes(imagePath);

                    // Optionally, open the image to ensure it's valid
                    using (System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath))
                    {
                        // Additional validation can go here
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to read image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop if image loading fails
                }
            }

    Address address = new Address
    {
        BarangayName = teBarangayName.Text,
        MunicipalityName = teMunicipalityName.Text,
        ProvinceName = teProvinceName.Text,
        ZipCodeNumber = int.TryParse(teZipCodeNumber.Text, out int zipCodeNumber) ? zipCodeNumber : 0,
        CountryName = teCountryName.Text
    };

            // Ask for confirmation before updating
            DialogResult result = MessageBox.Show("Are you sure you want to update this data?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; // User canceled
            }

            // Update employee info (image update is conditional)
            UpdateEmployeeInformation(employee, imageBytes, imagePath, address);

            // ✅ Notify the main form to refresh the grid
            EmployeeUpdated?.Invoke(this, EventArgs.Empty);
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

        //private void ClearInputs()
        //{
        //    teFirstName.Text = string.Empty;
        //    teMiddleName.Text = string.Empty;
        //    teLastName.Text = string.Empty;
        //    teNameExtension.Text = string.Empty;
        //    rdGender.Text = string.Empty;
        //    cbCivilStatus.Text = string.Empty;
        //    deDateOfBirth.Text = string.Empty;
        //    tePhoneNumber.Text = string.Empty;
        //    deDateHired.Text = string.Empty;
        //    lueRole.Text = string.Empty;
        //    mmAddress.Text = string.Empty;
        //}

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

        private void BtnCancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Data table of Address
        DataTable dtAddress = new DataTable();
        private DataTable CreateAddressTable()
        {
            dtAddress.Columns.Add("Barangay", typeof(string));
            dtAddress.Columns.Add("Municipality", typeof(string));
            dtAddress.Columns.Add("Province", typeof(string));
            dtAddress.Columns.Add("ZipCode", typeof(string));
            dtAddress.Columns.Add("Country", typeof(string));

            return dtAddress;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string barangay = teBarangayName.Text.Trim();
            string municipality = teMunicipalityName.Text.Trim();
            string province = teProvinceName.Text.Trim();
            string zipCode = teZipCodeNumber.Text.Trim();
            string country = teCountryName.Text.Trim();
            // Validation to check if any field is empty
            if (string.IsNullOrEmpty(barangay) ||
                string.IsNullOrEmpty(municipality) ||
                string.IsNullOrEmpty(province) ||
                string.IsNullOrEmpty(zipCode) ||
                string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Please fill out all fields before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataRow newRow = dtAddress.NewRow();
            newRow["Barangay"] = barangay;
            newRow["Municipality"] = municipality;
            newRow["Province"] = province;
            newRow["ZipCode"] = zipCode;
            newRow["Country"] = country;
            dtAddress.Rows.Add(newRow);

            gcAddress.DataSource = dtAddress;
            gvAddress.RefreshData();

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvAddress.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                DataRow rowDelete = gvAddress.GetDataRow(focusedRowHandle);
                if (rowDelete != null)
                {
                    dtAddress.Rows.Remove(rowDelete);

                    gcAddress.DataSource = dtAddress;
                    gvAddress.RefreshData();
                }
                else
                {
                    XtraMessageBox.Show("Please select a row to remove.");
                }
            }
        }
    }
}