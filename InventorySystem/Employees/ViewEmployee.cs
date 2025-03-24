using DevExpress.XtraBars;
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

namespace InventorySystem.Employees
{
    public partial class ViewEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {
            GlobalMethod.LoadEmployeeData("All", gcEmployee);
            GlobalMethod.LoadEmployeeData("Manager", gcManager);
            GlobalMethod.LoadEmployeeData("Cashier", gcCashier);
            GlobalMethod.LoadEmployeeData("Laborer", gcLaborer);
        }
    }
}