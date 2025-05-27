using Dapper;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

        private void UpdateEmployeeAccount(string employeeID, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    // Step 1: Get the AccountID linked to the employee
                    string getAccountQuery = "SELECT AccountID FROM Employee WHERE EmployeeID = @EmployeeID";
                    int? accountID = connection.ExecuteScalar<int?>(getAccountQuery, new { EmployeeID = employeeID });

                    if (accountID == null)
                    {
                        MessageBox.Show("This employee does not have an account assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Step 2: Update the Account password
                    string updateQuery = "UPDATE Account SET Password = @Password WHERE AccountID = @AccountID";
                    connection.Execute(updateQuery, new
                    {
                        Password = newPassword,
                        AccountID = accountID
                    });

                    MessageBox.Show("Account password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tePassword.Text = "";

                    // ✅ Refresh the account list
                    LoadAccountList(gcEmployeeAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (gvEmployeeAccount.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select an employee to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string password = tePassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this employee's account password?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string employeeID = gvEmployeeAccount.GetRowCellValue(gvEmployeeAccount.FocusedRowHandle, "EmployeeID")?.ToString();
                UpdateEmployeeAccount(employeeID, password); // Will handle refresh inside
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the GridView
            if (gvEmployeeAccount.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select an employee to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected EmployeeID from the GridView
            string employeeID = gvEmployeeAccount.GetRowCellValue(gvEmployeeAccount.FocusedRowHandle, "EmployeeID").ToString();

            if (string.IsNullOrEmpty(employeeID))
            {
                MessageBox.Show("No valid employee ID found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 1: Show confirmation dialog
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete this employee's account?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If the user clicks "No", exit the method
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Proceed with deletion if "Yes" is clicked
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    // Step 2: Get the AccountID linked to the employee
                    string getAccountQuery = "SELECT AccountID FROM Employee WHERE EmployeeID = @EmployeeID";
                    int? accountID = connection.ExecuteScalar<int?>(getAccountQuery, new { EmployeeID = employeeID });

                    if (accountID == null)
                    {
                        MessageBox.Show("This employee does not have an account assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Step 3: Delete the Account row from the Account table
                    string deleteAccountQuery = "DELETE FROM Account WHERE AccountID = @AccountID";
                    connection.Execute(deleteAccountQuery, new { AccountID = accountID });

                    // Step 4: Set AccountID in Employee table to NULL
                    string updateEmployeeQuery = "UPDATE Employee SET AccountID = NULL WHERE EmployeeID = @EmployeeID";
                    connection.Execute(updateEmployeeQuery, new { EmployeeID = employeeID });

                    MessageBox.Show("Employee's account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ✅ Refresh the employee list or perform any other UI update if needed
                    LoadAccountList(gcEmployeeAccount); // This is just an example, replace it with your actual method to reload employee data
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}