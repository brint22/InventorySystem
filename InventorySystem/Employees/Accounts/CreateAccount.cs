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
using DevExpress.XtraEditors;

namespace InventorySystem.Account
{
    public partial class CreateAccount : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CreateAccount()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            string query = @"
                SELECT 
                    e.EmployeeID,
                    e.FirstName + ' ' + e.MiddleName + ' ' + e.LastName + ' ' + e.NameExtension AS EmployeeName,
                    r.RoleName
                FROM [WAREHOUSEISDB].[dbo].[Employee] e
                LEFT JOIN [dbo].[Role] r ON r.RoleID = e.RoleID;";

            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalClass.connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        adapter.Fill(dt);
                        gcAccounts.DataSource = dt;
                        gcAccounts.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employee data:\n" + ex.Message);
            }
        }
        private void windowsUIBtnSave_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string connStr = GlobalClass.connectionString;


            string username = teUserName.Text.Trim();
            string password = tePassword.Text.Trim();

            // No password hashing
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all necessary data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    // Check if the username already exists
                    string checkSql = "SELECT 1 FROM Account WHERE UserName = @UserName";
                    var exists = connection.QueryFirstOrDefault<int?>(checkSql, new { UserName = username });

                    if (exists.HasValue)
                    {
                        MessageBox.Show("Username Already Exists", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert new account with RoleId
                    string registerSql = "INSERT INTO Account (UserName, Password, RoleId) VALUES (@UserName, @Password, @RoleId)";
                    connection.Execute(registerSql, new { UserName = username, Password = password });

                    MessageBox.Show("Account Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during creation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            LoadRole();

            // Show first row's EmployeeID on load
            int rowHandle = gvAccounts.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                string employeeId = gvAccounts.GetRowCellValue(rowHandle, "EmployeeID")?.ToString();
                teUserName.Text = employeeId;
            }

            // Hook event to update when selection changes
            gvAccounts.FocusedRowChanged += gvAccounts_FocusedRowChanged;
        }

        private void gvAccounts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                string employeeId = gvAccounts.GetRowCellValue(e.FocusedRowHandle, "EmployeeID")?.ToString();
                teUserName.Text = employeeId;
            }
        }


        private void windowsUIBtnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Account (UserName, Password) VALUES (@UserName, @Password)";

            using (SqlConnection con = new SqlConnection(GlobalClass.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserName", teUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", tePassword.Text); 

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account successfully added!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }


    }

