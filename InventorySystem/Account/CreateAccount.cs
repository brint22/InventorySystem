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
namespace InventorySystem.Account
{
    public partial class CreateAccount : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void windowsUIBtnSave_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string connStr = GlobalClass.connectionString;

           
            string username = teUserName.Text.Trim();
            string password = tePassword.Text.Trim();
            string role = cbRole.Text.Trim();
            
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
                    string checkSql = "SELECT 1 FROM Account WHERE UserName = @UserName";
                    var exists = connection.QueryFirstOrDefault<int?>(checkSql, new { Username = username });

                    if (exists.HasValue)
                    {
                        MessageBox.Show("Username Already Exist", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Insert username and plain-text password (insecure, avoid in production)
                    string registerSql = "INSERT INTO Account (UserName, Password, Role) VALUES (@UserName, @Password, @Role)";
                    connection.Execute(registerSql, new { Username = username, Password = password, Role = role });

                    MessageBox.Show("Account Created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred during creation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}