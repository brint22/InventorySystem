using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using InventorySystem.Infrastracture.SQL;
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

namespace InventorySystem.Account
{
    public partial class ViewAccount : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewAccount()
        {
            InitializeComponent();

            LoadAccountList(gcEmployeeAccount);
        }

        public static void LoadAccountList(GridControl gcEmployeeAccount)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    string query = EmployeeSQL.GetListOfAccounts;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    gcEmployeeAccount.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewAccount_Load(object sender, EventArgs e)
        {
            gvEmployeeAccount.RowClick += (s, ev) =>
            {
                if (gvEmployeeAccount.FocusedRowHandle >= 0)
                {
                    var employeeID = gvEmployeeAccount.GetRowCellValue(gvEmployeeAccount.FocusedRowHandle, "EmployeeID")?.ToString();
                    teEmployeeID.Text = employeeID;
                    var employeePassword = gvEmployeeAccount.GetRowCellValue(gvEmployeeAccount.FocusedRowHandle, "Password")?.ToString();
                    tePassword.Text = employeePassword;
                }
            };
        }
    }
}