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

namespace InventorySystem.Products
{
    public partial class ViewStock : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewStock()
        {
            InitializeComponent();
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {
            GlobalMethod.LoadStockList(gcStock);
        }
    }
}