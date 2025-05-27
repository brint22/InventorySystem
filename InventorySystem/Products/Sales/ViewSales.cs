using DevExpress.XtraBars;
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
using DevExpress.XtraReports.UI;
using Dapper;


namespace InventorySystem.Products.Sales
{
    public partial class ViewSales : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewSales()
        {
            InitializeComponent();
        }

        public List<Sale> LoadSales()
        {
            List<Sale> sales;

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                                p.ProductName,
                                SUM(s.QuantitySold) AS QuantitySold,
                                SUM(s.QuantitySold * s.Price) AS Price,
                                FORMAT(o.OrderDate, 'MMMM dd, yyyy') AS OrderDate
                            FROM [WAREHOUSEISDB].[dbo].[Sales] s
                            LEFT JOIN Product p ON s.ProductID = p.ProductID
                            LEFT JOIN Orders o ON o.OrderID = s.OrderID
                            GROUP BY 
                                p.ProductName, 
                                FORMAT(o.OrderDate, 'MMMM dd, yyyy');";

                sales = connection.Query<Sale>(query, commandType: CommandType.Text).ToList();
            }

            // Add Count manually
            for (int i = 0; i < sales.Count; i++)
            {
                sales[i].Count = i + 1;
            }

            return sales;
        }

        private void ViewSales_Load(object sender, EventArgs e)
        {
            gcSales.DataSource = LoadSales();
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            SalesReport salesReport = new SalesReport();

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                            p.ProductName,
                            SUM(s.QuantitySold) AS QuantitySold,
                            SUM(s.QuantitySold * s.Price) AS Price,
                            c.CategoryName
                         FROM [WAREHOUSEISDB].[dbo].[Sales] s
                         LEFT JOIN Product p ON s.ProductID = p.ProductID
                        LEFT JOIN Category c ON p.CategoryID = c.CategoryID
                         GROUP BY p.ProductName, c.CategoryName";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(dataTable);
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                salesReport.DataSource = dataTable;
                salesReport.ShowPreview();
            }
            else
            {
                MessageBox.Show("No sales data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}