using InventorySystem.Infrastracture.SQL;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace InventorySystem.Infrastracture.Repositories
{
    public class EmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // INSERT METHODS

        public void RegisterEmployee(Employee employees, byte[] imageBytes, Address address)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        if (employees == null || imageBytes == null || address == null)
                        {
                            MessageBox.Show("Employee details, image, or address cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int imageID = connection.ExecuteScalar<int>(
                            EmployeeSQL.InsertEmployeeImage,
                            new { ImageData = imageBytes },
                            transaction
                        );

                        if (imageID <= 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to save employee image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int addressID = connection.ExecuteScalar<int>(
                            EmployeeSQL.InsertAddress,
                            new
                            {
                                BarangayName = address.BarangayName,
                                MunicipalityName = address.MunicipalityName,
                                ProvinceName = address.ProvinceName,
                                ZipCodeNumber = address.ZipCodeNumber,
                                CountryName = address.CountryName
                            },
                            transaction
                        );

                        if (addressID <= 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Failed to save address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        employees.EmployeeID = GenerateID();

                        int employeeRows = connection.Execute(
                            EmployeeSQL.InsertEmployee,
                            new
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
                                AddressID = addressID,
                                employees.RoleID,
                                ImageID = imageID
                            },
                            transaction
                        );

                        if (employeeRows == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Employee registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

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

        // LOAD METHODS

        public DataTable GetEmployeeList(string roleFilter)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                string query = EmployeeSQL.GetListOfEmployees;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoleFilter", roleFilter);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (row["ImageData"] == DBNull.Value)
                            {
                                row["ImageData"] = new byte[0];
                            }
                        }

                        return dataTable;
                    }
                }
            }
        }

        public static void LoadRole(LookUpEdit lookUpEdit)
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
                    var roles = connection.Query<Role>(query).ToList();

                    if (roles.Any())
                    {
                        lookUpEdit.Properties.DataSource = roles;
                        lookUpEdit.Properties.DisplayMember = "RoleName";
                        lookUpEdit.Properties.ValueMember = "RoleID";
                    }
                    else
                    {
                        lookUpEdit.Properties.DataSource = null;
                        XtraMessageBox.Show("No roles found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string GetGender(RadioGroup radioGroup)
        {
            return radioGroup.SelectedIndex == 0 ? "Male" : "Female";
        }

        public static int GetRole(LookUpEdit lookupEditor)
        {
            return lookupEditor.EditValue != null ? (int)lookupEditor.EditValue : 0;
        }

        public string GenerateID()
        {
            int year = DateTime.Now.Year;
            int lastNumber = GetLastNumberFromDB(year);
            int newNumber = lastNumber + 1;

            return $"{year}-{newNumber:D4}"; // Ensures 4-digit formatting (e.g., 2025-0001)
        }

        public int GetLastNumberFromDB(int year)
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
      
        public static void ClearEmployeeInputs(
        TextEdit firstName, TextEdit middleName, TextEdit lastName,
        TextEdit nameExtension, RadioGroup gender, ComboBoxEdit civilStatus,
        DateEdit dateOfBirth, TextEdit phoneNumber, DateEdit dateHired, LookUpEdit role)
        {
            firstName.Text = string.Empty;
            middleName.Text = string.Empty;
            lastName.Text = string.Empty;
            nameExtension.Text = string.Empty;
            gender.SelectedIndex = -1;
            civilStatus.SelectedIndex = -1;
            dateOfBirth.EditValue = null;
            phoneNumber.Text = string.Empty;
            dateHired.EditValue = null;
            role.EditValue = null;
        }


    }
}
