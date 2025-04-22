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

        private void LoadProduct()
        {

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                string sql = @"SELECT
                         p.[ProductID]
                        ,p.[ProductName]
                        ,p.[Price]
                        ,p.[Quantity]
                        ,p.[ExpirationDate]
                        ,p.[ProductRecieved]
                        ,c.CategoryName
                        ,p.[BrandName]
                        ,p.[Supplier]
                        ,L.LocationStart,
	                    l.LocationFinish
                  FROM [WAREHOUSEISDB].[dbo].[Product] p
                  LEFT JOIN Category c
                  ON c.CategoryID  = p.CategoryID
                  LEFT JOIN Location l
                  ON l.LocationID = p.LocationID";
                var productList = connection.Query<Product>(sql).ToList();
                // Bind data to the grid
                gcProductList.DataSource = productList;
            }
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void txtSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProductList.ApplyFindFilter(e.NewValue as string);
        }
    }
}