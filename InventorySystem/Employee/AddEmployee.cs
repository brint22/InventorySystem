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
using DevExpress.XtraPrinting.Native;
using System.Net;
using DevExpress.XtraEditors;

namespace InventorySystem.Employee
{
    public partial class AddEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddEmployee()
        {
            InitializeComponent();
        }


        private void RegisterEmployee(Employees employees)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Validate input objects
                        if (employees == null )
                        {
                            MessageBox.Show("Employee or related details cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Generate EmployeeID ONCE and apply it to all related entities
                        string generatedID = GenerateID();
                        employees.EmployeeID = generatedID;
                        employees.RoleID = GetRoleID(); // Fetch Role ID


                        if (string.IsNullOrWhiteSpace(employees.EmployeeID))
                        {
                            MessageBox.Show("Failed to generate Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Insert into Employees table
                        string employeeQuery = @"
                    INSERT INTO Employee 
                    (EmployeeID, FirstName, MiddleName, LastName, NameExtension,DateOfBirth, Address, RoleID)
                    VALUES
                    (@EmployeeID, @FirstName, @MiddleName, @LastName, @NameExtension, @DateOfBirth, @Address, @RoleID);";

                        int employeeRows = connection.Execute(employeeQuery, employees, transaction);

                        if (employeeRows == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Employee registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                      
                        // Commit transaction only if all inserts succeed
                        transaction.Commit();
                        MessageBox.Show("Employee registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //private static string GenerateID()
        //{
        //    Random random = new Random();
        //    string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    string id = string.Empty;

        //    for (int i = 0; i < 4; i++)
        //    {
        //        id += letters[random.Next(letters.Length)];
        //        id += random.Next(0, 8);

        //    }
        //    return id;
        //}

        private static int lastNumber = 0; // Ideally, fetch from a database

        private static string GenerateID()
        {
            int year = DateTime.Now.Year;
            lastNumber++; // Increment the counter (load/save this properly in a real application)

            return $"{year}-{lastNumber:D4}"; // Ensures 4-digit formatting (e.g., 2025-0001)
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees
            {
                FirstName = teFirstName.Text,
                MiddleName = teMiddleName.Text,
                LastName = teLastName.Text,
                NameExtension = teNameExtension.Text,
                DateOfBirth = deDateOfBirth.DateTime,
                Address  = teAddress.Text,
                RoleName = lueRole.Text
            };
            GetRoleID();
            RegisterEmployee(employees);
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            LoadRole();
        }

        private int GetRoleID()
        {
            int intRoleID = 0;

            if (lueRole.EditValue != null)
            {
                intRoleID = (int)lueRole.EditValue;

            }
            else
            {
                intRoleID = 0;
            }
            return intRoleID;
        }
    }
}