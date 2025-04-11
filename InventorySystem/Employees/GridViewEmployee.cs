using DevExpress.XtraBars;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Employees
{
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
    }
}