using DevExpress.XtraBars;
using InventorySystem.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Views
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bbiAddEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Create a new instance of Employee form
            AddEmployee employee = new AddEmployee();
            this.IsMdiContainer = true;
            employee.MdiParent = this;

            // Show the Employee form
            employee.Show();
        }

        private void bbiViewEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Create a new instance of Employee form
            ViewEmployee employee = new ViewEmployee();
            this.IsMdiContainer = true;
            employee.MdiParent = this;
            // Show the Employee form
            employee.Show();
        }
    }
}