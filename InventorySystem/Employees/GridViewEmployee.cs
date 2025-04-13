using Dapper;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using InventorySystem.Models;
using InventorySystem.Reports;
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

namespace InventorySystem.Employees
{
    //
    public partial class GridViewEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GridViewEmployee()
        {
            InitializeComponent();

        }

        private void GridViewEmployee_Load(object sender, EventArgs e)
        {
            GlobalMethod.LoadEmployeeData("All", gcEmployeeView);
            RetrieveAndDisplayEmployee();
            LoadRoleNames();

        }

        private void teSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvEmployeeView.ApplyFindFilter(e.NewValue as string);
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            EmployeesReport employeesReport = new EmployeesReport();

            // Load data into the GridControl first
            GlobalMethod.LoadEmployeeData("All", gcEmployeeView);

            // Use the GridControl's data source for the report
            DataTable dataTable = gcEmployeeView.DataSource as DataTable;

            if (dataTable != null)
            {
                employeesReport.DataSource = dataTable;
                employeesReport.ShowPreview();
            }
            else
            {
                MessageBox.Show("Failed to load employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbEmployeeRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cbEmployeeRole.Text;

            // If no role is selected, you can pass null to get all employees
            if (string.IsNullOrWhiteSpace(selectedRole))
            {
                RetrieveAndDisplayEmployee(null);
            }
            else
            {
                RetrieveAndDisplayEmployee(selectedRole);
            }
        }

        private void RetrieveAndDisplayEmployee(string role = null)
        {
            try
            {
                string query = @"
        SELECT e.EmployeeID, 
            (e.FirstName + ' ' + 
            ISNULL(e.MiddleName + ' ', '') +
            e.LastName + ' ' + 
            ISNULL(e.NameExtension, '')) AS EmployeeName,
            FORMAT(e.DateOfBirth, 'MMMM dd, yyyy') AS DateOfBirth,
            (
                ISNULL('Barangay ' + a.BarangayName + ', ', '') +
                ISNULL(a.MunicipalityName + ', ', '') +
                ISNULL(a.ProvinceName + ', ', '') +
                ISNULL(CAST(a.ZipCodeNumber AS VARCHAR) + ', ', '') +
                ISNULL(a.CountryName, '')
            ) AS Address,
            r.RoleID,
            UPPER(LEFT(r.RoleName, 1)) + LOWER(SUBSTRING(r.RoleName, 2, LEN(r.RoleName))) AS RoleName,
            ei.ImageData,
            CAST(
                DATEDIFF(YEAR, e.DateOfBirth, CAST(GETDATE() AS DATE)) - 
                CASE 
                    WHEN MONTH(e.DateOfBirth) > MONTH(CAST(GETDATE() AS DATE)) 
                        OR (MONTH(e.DateOfBirth) = MONTH(CAST(GETDATE() AS DATE)) 
                        AND DAY(e.DateOfBirth) > DAY(CAST(GETDATE() AS DATE))) 
                    THEN 1 ELSE 0 
                END 
            AS VARCHAR) + ' years old' AS Age,
            e.PhoneNumber,
            FORMAT(e.DateHired, 'MMMM dd, yyyy') AS DateHired,
            e.Gender,
            e.CivilStatus
        FROM Employee e
        LEFT JOIN EmployeeImage ei ON e.ImageID = ei.ImageID
        LEFT JOIN Role r ON e.RoleID = r.RoleID
        LEFT JOIN Address a ON e.AddressID = a.AddressID
        WHERE (@RoleName IS NULL OR r.RoleName = @RoleName)
        ORDER BY e.DateHired DESC;";

                using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleName", string.IsNullOrWhiteSpace(role) ? (object)DBNull.Value : role);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        connection.Open();
                        adapter.Fill(dataTable);
                        gcEmployeeView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void LoadRoleNames()
        {
            string query = "SELECT DISTINCT RoleName FROM Role ORDER BY RoleName;";

            using (var connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();
                    var roles = connection.Query<string>(query).ToList();

                    if (roles.Any())
                    {
                        cbEmployeeRole.Properties.Items.Clear();
                        cbEmployeeRole.Properties.Items.AddRange(roles);
                    }
                    else
                    {
                        XtraMessageBox.Show("No roles found in the database.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }

  }

