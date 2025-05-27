using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using InventorySystem.Models;
using InventorySystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //
        private bool LoginMethod(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                string query = @"SELECT COUNT(*) FROM Account
                         WHERE UserName = @UserName
                         AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int result = (int)command.ExecuteScalar();
                    return result > 0; 
                }
            }
        }

        //private bool LoginMethod(string username, string password)
        //{
        //    string connStr = GlobalClass.connectionString;
        //    SqlConnection connection = new SqlConnection(connStr);
        //    connection.Open();
        //    string query = @"SELECT COUNT(*) FROM Account
        //                   WHERE UserName = @UserName
        //                   AND Password = @Password";

        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("UserName", username);
        //    command.Parameters.AddWithValue("Password", password);
        //    int result = (int)command.ExecuteScalar();
        //    return result > 0;
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginMethod(teUserName.Text.Trim(), tePassword.Text.Trim()))
            {

                bbi mainform = new bbi();
                mainform.Show();
                Visible = false;

            }
            else
            {
                XtraMessageBox.Show("Invalid Input!", "Waring");
            }
        }

        // Sample1
    

        private void teUserName_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty when losing focus, set the placeholder text
            if (string.IsNullOrWhiteSpace(teUserName.Text))
            {
                teUserName.Text = "Username";
                teUserName.ForeColor = Color.Black; // Set placeholder color to gray
            }
        }

        //test-a

        private void tePassword_Leave(object sender, EventArgs e)
        {
            // If the TextBox is empty when losing focus, set the placeholder text
            if (string.IsNullOrWhiteSpace(tePassword.Text))
            {
                tePassword.Text = "Password";
                tePassword.ForeColor = Color.Black; // Set placeholder color to gray
            }
        }
    }
}
