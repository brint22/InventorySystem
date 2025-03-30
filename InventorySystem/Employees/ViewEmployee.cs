using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Tile;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventorySystem.Employees
{
    public partial class ViewEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static ViewEmployee instance;
        public ViewEmployee()
        {
            instance = this;
            InitializeComponent();

        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            GlobalMethod.LoadEmployeeData("All", gcEmployee);
            GlobalMethod.LoadEmployeeData("Manager", gcManager);
            GlobalMethod.LoadEmployeeData("Cashier", gcCashier);
            GlobalMethod.LoadEmployeeData("Laborer", gcLaborer);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string employeeID = Convert.ToString(tvEmployee.GetFocusedRowCellValue("EmployeeID"));

            // Fetch missing employee details from the database
            (string firstName, string middleName, string lastName, string nameExtension) = GetEmployeeDetails(employeeID);

            UpdateEmployee form = new UpdateEmployee(employeeID, this);

            form.teEmployeeID.Text = employeeID;
            form.teFirstName.Text = firstName;
            form.teMiddleName.Text = middleName;
            form.teLastName.Text = lastName;
            form.teNameExtension.Text = nameExtension;
            string gender = Convert.ToString(tvEmployee.GetFocusedRowCellValue("Gender"));

            if (gender == "Male")
            {
                form.rdGender.SelectedIndex = 0;
            }
            else if (gender == "Female")
            {
                form.rdGender.SelectedIndex = 1;
            }
            form.cbCivilStatus.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("CivilStatus"));
            form.tePhoneNumber.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("PhoneNumber"));
            form.lueRole.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("RoleName"));
            form.mmAddress.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("Address"));

            if (tvEmployee.GetFocusedRowCellValue("DateOfBirth") != DBNull.Value)
            {
                form.deDateOfBirth.DateTime = Convert.ToDateTime(tvEmployee.GetFocusedRowCellValue("DateOfBirth"));
            }

            if (tvEmployee.GetFocusedRowCellValue("DateHired") != DBNull.Value)
            {
                form.deDateHired.DateTime = Convert.ToDateTime(tvEmployee.GetFocusedRowCellValue("DateHired"));
            }

            // Load image if available
            form.meEmployeeImagePath.Text = GetImagePathFromTileView("EmployeeImagePath");

            DialogResult result = form.ShowDialog();
        }

        private (string, string, string, string) GetEmployeeDetails(string employeeID)
        {
            string firstName = "", middleName = "", lastName = "", nameExtension = "";

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                SELECT FirstName, MiddleName, LastName, NameExtension 
                FROM Employee 
                WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstName = reader["FirstName"].ToString();
                                middleName = reader["MiddleName"] != DBNull.Value ? reader["MiddleName"].ToString() : "";
                                lastName = reader["LastName"].ToString();
                                nameExtension = reader["NameExtension"] != DBNull.Value ? reader["NameExtension"].ToString() : "";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching employee details: " + ex.Message);
                }
            }

            return (firstName, middleName, lastName, nameExtension);
        }


        private string GetImagePathFromTileView(string columnName)
        {
            return tvEmployee.GetFocusedRowCellValue(columnName) != DBNull.Value
                   ? Convert.ToString(tvEmployee.GetFocusedRowCellValue(columnName))
                   : string.Empty;
        }

    }
}