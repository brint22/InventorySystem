using DevExpress.XtraBars;
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

namespace InventorySystem.Employees
{
    public partial class ViewEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void LoadEmployeeData()
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                    SELECT e.EmployeeID, 
                           (e.FirstName + ' ' + 
                            ISNULL(e.MiddleName + ' ', '') + 
                            e.LastName + ' ' + 
                            ISNULL(e.NameExtension, '')) AS EmployeeName,
                           e.DateOfBirth, e.Address, 
                           UPPER(LEFT(r.RoleName, 1)) + LOWER(SUBSTRING(r.RoleName, 2, LEN(r.RoleName))) AS RoleName, -- Sentence Case
                           ei.ImageData
                    FROM Employee e
                    LEFT JOIN EmployeeImage ei ON e.ImageID = ei.ImageID
                    LEFT JOIN Role r ON e.RoleID = r.RoleID";

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Ensure EmployeeImage stays as byte[]
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["ImageData"] == DBNull.Value)
                        {
                            row["ImageData"] = new byte[0]; // Store empty byte[] instead of NULL
                        }
                    }

                    // Bind to GridControl
                    gcEmployee.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
    }
}