using DevExpress.XtraEditors;
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

namespace InventorySystem.views
{
    public partial class ViewProduct : DevExpress.XtraEditors.XtraForm
    {
        public ViewProduct()
        {
            InitializeComponent();
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            
            GlobalMethod.LoadProductList(gcProductList);
        }

        private void txtSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProductList.ApplyFindFilter(e.NewValue as string);
        }


        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}