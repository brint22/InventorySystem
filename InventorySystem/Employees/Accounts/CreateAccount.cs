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
                        gridControl1.DataSource = dt;
                        gridControl1.RefreshDataSource();
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
            string role = lueRole.Text.Trim();
            
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

                    // Retrieve the RoleId from the Role table
                    string roleSql = "SELECT RoleId FROM Role WHERE RoleName = @RoleName";
                    var roleId = connection.QueryFirstOrDefault<int?>(roleSql, new { RoleName = role });

                    if (!roleId.HasValue)
                    {
                        MessageBox.Show("Invalid Role Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert new account with RoleId
                    string registerSql = "INSERT INTO Account (UserName, Password, RoleId) VALUES (@UserName, @Password, @RoleId)";
                    connection.Execute(registerSql, new { UserName = username, Password = password, RoleId = roleId.Value });

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

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            LoadRole();
        }

     
    }
}