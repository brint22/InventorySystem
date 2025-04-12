using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraCharts.Designer.Native;
using DevExpress.XtraReports.UI;
using InventorySystem.Models;
using InventorySystem.Reports;
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
    //
    public partial class GridViewEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public GridViewEmployee()
        {
            InitializeComponent();
        }

        private void GridViewEmployee_Load(object sender, EventArgs e)
        {
            GlobalMethod.LoadEmployeeData("All", gcEmployeeView);
        }

        private void teSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvEmployeeView.ApplyFindFilter(e.NewValue as string);
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            EmployeesReport employeesReport = new EmployeesReport();

            // Load data into the GridControl first
            GlobalMethod.LoadEmployeeData("All", gcEmployeeView);

            // Use the GridControl's data source for the report
            DataTable dataTable = gcEmployeeView.DataSource as DataTable;

            if (dataTable != null)
            {
                employeesReport.DataSource = dataTable;
                employeesReport.ShowPreview();
            }
            else
            {
                MessageBox.Show("Failed to load employee data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}