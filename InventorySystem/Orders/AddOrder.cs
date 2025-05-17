using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using InventorySystem.Models;
using System.Data.SqlClient;

namespace InventorySystem.Orders
{
    public partial class AddOrder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        public List<ProductStock> GetStock()
        {
            IEnumerable<ProductStock> stock;

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                                s.ProductID,
                                s.Price,    
                                p.ProductName,
                                SUM(l.Capacity) AS AvailableStock
                            FROM [WAREHOUSEISDB].[dbo].[Stock] s
                            LEFT JOIN Location l ON l.ProductID = s.ProductID
                            LEFT JOIN Product p ON p.ProductID = s.ProductID
                            GROUP BY 
                                s.ProductID,
                                s.Price,
                                p.ProductName;
                            ;";

                stock = connection.Query<ProductStock>(query, commandType: CommandType.Text);
            }

            return stock.ToList();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            gcProducts.DataSource = GetStock();
        }
    }
}