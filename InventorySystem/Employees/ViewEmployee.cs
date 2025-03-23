using DevExpress.XtraBars;
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
            SELECT e.EmployeeID, e.FirstName, e.MiddleName, e.LastName, e.NameExtension, 
                   e.DateOfBirth, e.Address, e.RoleID, ei.EmployeeImage
            FROM Employee e
            LEFT JOIN EmployeeImage ei ON e.ImageID = ei.ImageID"; // Join EmployeeImage table

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Ensure EmployeeImage stays as byte[]
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["EmployeeImage"] == DBNull.Value)
                        {
                            row["EmployeeImage"] = new byte[0]; // Store empty byte[] instead of NULL
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