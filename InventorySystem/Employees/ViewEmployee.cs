using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraLayout.Customization;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySystem.Employees
{
    public partial class ViewEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static ViewEmployee instance;
       

        public ViewEmployee()
        {
            instance = this;
            InitializeComponent();

        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            GlobalMethod.LoadEmployeeData("All", gcEmployee);
            GlobalMethod.LoadEmployeeData("Manager", gcManager);
            GlobalMethod.LoadEmployeeData("Cashier", gcCashier);
            GlobalMethod.LoadEmployeeData("Laborer", gcLaborer);
            gcEmployee.RefreshDataSource();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string employeeID = Convert.ToString(tvEmployee.GetFocusedRowCellValue("EmployeeID"));

            // Fetch employee details, including ImageData
            (string firstName, string middleName, string lastName, string nameExtension, byte[] imageData) = GetEmployeeDetails(employeeID);

            // Fetch address details
            Address employeeAddress = GetEmployeeAddress(employeeID);

            var updateForm = new UpdateEmployee(employeeID, this); // instantiate your update form

            // Hook the event to refresh gcEmployee
            updateForm.EmployeeUpdated += (s, args) =>
            {
                GlobalMethod.LoadEmployeeData("All", gcEmployee);
            };

            // Populate form fields with employee details
            updateForm.teEmployeeID.Text = employeeID;
            updateForm.teFirstName.Text = firstName;
            updateForm.teMiddleName.Text = middleName;
            updateForm.teLastName.Text = lastName;
            updateForm.teNameExtension.Text = nameExtension;

            string gender = Convert.ToString(tvEmployee.GetFocusedRowCellValue("Gender"));
            updateForm.rdGender.SelectedIndex = (gender == "Male") ? 0 : (gender == "Female") ? 1 : -1;

            updateForm.cbCivilStatus.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("CivilStatus"));
            updateForm.tePhoneNumber.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("PhoneNumber"));
            updateForm.lueRole.EditValue = tvEmployee.GetFocusedRowCellValue("RoleID");

            if (tvEmployee.GetFocusedRowCellValue("DateOfBirth") != DBNull.Value)
            {
                updateForm.deDateOfBirth.DateTime = Convert.ToDateTime(tvEmployee.GetFocusedRowCellValue("DateOfBirth"));
            }

            if (tvEmployee.GetFocusedRowCellValue("DateHired") != DBNull.Value)
            {
                updateForm.deDateHired.DateTime = Convert.ToDateTime(tvEmployee.GetFocusedRowCellValue("DateHired"));
            }

            // Load the image into the form if imageData exists
            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        updateForm.peProfile.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                updateForm.meEmployeeImagePath.Text = string.Empty;
            }

            // Populate the address fields
            updateForm.teBarangayName.Text = employeeAddress.BarangayName;
            updateForm.teMunicipalityName.Text = employeeAddress.MunicipalityName;
            updateForm.teProvinceName.Text = employeeAddress.ProvinceName;
            updateForm.teZipCodeNumber.Text = employeeAddress.ZipCodeNumber.ToString();
            updateForm.teCountryName.Text = employeeAddress.CountryName;

            // Show the update form
            DialogResult result = updateForm.ShowDialog();
        }

     

        private (string firstName, string middleName, string lastName, string nameExtension, byte[] imageData) GetEmployeeDetails(string employeeID)
        {
            string firstName = "", middleName = "", lastName = "", nameExtension = "";
            byte[] imageData = null;

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
    SELECT e.FirstName, e.MiddleName, e.LastName, e.NameExtension, ei.ImageData
    FROM Employee e
    LEFT JOIN EmployeeImage ei ON e.ImageID = ei.ImageID
    WHERE e.EmployeeID = @EmployeeID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstName = reader["FirstName"].ToString();
                                middleName = reader["MiddleName"] != DBNull.Value ? reader["MiddleName"].ToString() : "";
                                lastName = reader["LastName"].ToString();
                                nameExtension = reader["NameExtension"] != DBNull.Value ? reader["NameExtension"].ToString() : "";

                                // Check for ImageData
                                if (reader["ImageData"] != DBNull.Value)
                                {
                                    imageData = (byte[])reader["ImageData"];
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching employee details: " + ex.Message);
                }
            }

            return (firstName, middleName, lastName, nameExtension, imageData);
        }

        private Address GetEmployeeAddress(string employeeID)
        {
            Address address = new Address();

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
            SELECT a.BarangayName, a.MunicipalityName, a.ProvinceName, a.ZipCodeNumber, a.CountryName
            FROM Employee e
            LEFT JOIN Address a ON e.AddressID = a.AddressID
            WHERE e.EmployeeID = @EmployeeID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                address.BarangayName = reader["BarangayName"] != DBNull.Value ? reader["BarangayName"].ToString() : "";
                                address.MunicipalityName = reader["MunicipalityName"] != DBNull.Value ? reader["MunicipalityName"].ToString() : "";
                                address.ProvinceName = reader["ProvinceName"] != DBNull.Value ? reader["ProvinceName"].ToString() : "";
                                address.ZipCodeNumber = reader["ZipCodeNumber"] != DBNull.Value ? Convert.ToInt32(reader["ZipCodeNumber"]) : 0;
                                address.CountryName = reader["CountryName"] != DBNull.Value ? reader["CountryName"].ToString() : "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching address details: " + ex.Message);
                }
            }

            return address;
        }



        private string GetImagePathFromTileView(string columnName)
        {
            return tvEmployee.GetFocusedRowCellValue(columnName) != DBNull.Value
                   ? Convert.ToString(tvEmployee.GetFocusedRowCellValue(columnName))
                   : string.Empty;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = tvEmployee.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                // Get the EmployeeID of the selected row
                string employeeID = Convert.ToString(tvEmployee.GetFocusedRowCellValue("EmployeeID"));

                // Confirm deletion
                DialogResult confirmDelete = MessageBox.Show(
                    "Are you sure you want to delete this employee record?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmDelete == DialogResult.Yes)
                {
                    // Call delete function
                    DeleteEmployee(employeeID);

                    // Refresh data after deletion
                    GlobalMethod.LoadEmployeeData("All", gcEmployee);

                    // Adjust focus after deletion
                    int newFocusedRowHandle = (focusedRowHandle >= tvEmployee.DataRowCount) ?
                                              tvEmployee.DataRowCount - 1 :
                                              focusedRowHandle;

                    if (newFocusedRowHandle >= 0)
                    {
                        tvEmployee.FocusedRowHandle = newFocusedRowHandle;
                    }

                  
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteEmployee(string employeeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
                {
                    string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching employee found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            tvEmployee.ApplyFindFilter(e.NewValue as string);
        }
    }
    
}