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
                   SELECT EmployeeID, 
                   CONCAT(FirstName, ' ', 
                          COALESCE(MiddleName + ' ', ''), 
                          LastName, 
                          COALESCE(' ' + NameExtension, '')) AS EmployeeName,
                   FORMAT(DateOfBirth, 'MMMM dd, yyyy') AS DateOfBirth, 
                   Address, 
                   RoleID, 
                   EmployeeImage AS EmployeeImagePath 
                   FROM Employee";

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
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