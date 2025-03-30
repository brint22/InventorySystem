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
            UpdateEmployee form = new UpdateEmployee(employeeID, this);

            form.teEmployeeID.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("EmployeeID"));
            form.teFirstName.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("FirstName"));
            form.teMiddleName.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("MiddleName"));
            form.teLastName.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("LastName"));
            form.teNameExtension.Text = Convert.ToString(tvEmployee.GetFocusedRowCellValue("NameExtension"));
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

        private string GetImagePathFromTileView(string columnName)
        {
            return tvEmployee.GetFocusedRowCellValue(columnName) != DBNull.Value
                   ? Convert.ToString(tvEmployee.GetFocusedRowCellValue(columnName))
                   : string.Empty;
        }

    }
}