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
using InventorySystem.Infrastracture.Repositories;
using DevExpress.XtraRichEdit.Accessibility;

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
                                ROW_NUMBER() OVER (ORDER BY p.ProductName) AS Count,
                                s.ProductID,
                                p.Price,                       
                                p.ProductName,
                                ISNULL(loc.TotalCapacity, 0) AS Capacity
                            FROM [WAREHOUSEISDB].[dbo].[Stock] s
                            LEFT JOIN (
                                SELECT ProductID, SUM(Capacity) AS TotalCapacity
                                FROM Location
                                GROUP BY ProductID
                            ) loc ON loc.ProductID = s.ProductID
                            LEFT JOIN Product p ON p.ProductID = s.ProductID
                            GROUP BY 
                                s.ProductID,
                                p.Price,
                                p.ProductName,
                                loc.TotalCapacity;
                            ";
                stock = connection.Query<ProductStock>(query, commandType: CommandType.Text);
            }

            return stock.ToList();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            gcProducts.DataSource = GetStock();
            var products = GetStock();
            gcProducts.DataSource = products;

            gvProducts.RowClick += (s, ev) =>
            {
                if (gvProducts.FocusedRowHandle >= 0)
                {
                    var productstock = gvProducts.GetRowCellValue(gvProducts.FocusedRowHandle, "ProductName")?.ToString();
                    teProductName.Text = productstock;
                    var price = gvProducts.GetRowCellValue(gvProducts.FocusedRowHandle, "Price")?.ToString();
                    tePrice.Text = price;
                }
            };

            gcOrder.DataSource = AddOrderTable();

        }

        private void txtSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProducts.ApplyFindFilter(e.NewValue as string);
        }

        //Data table of Order Product
        DataTable dtProduct = new DataTable();
        private DataTable AddOrderTable()
        {
            dtProduct.Columns.Add("Count", typeof(int));
            dtProduct.Columns["Count"].AutoIncrement = true;
            dtProduct.Columns["Count"].AutoIncrementSeed = 1;
            dtProduct.Columns["Count"].AutoIncrementStep = 1;

            dtProduct.Columns.Add("ProductName", typeof(string));
            dtProduct.Columns.Add("Quantity", typeof(int));
            dtProduct.Columns.Add("Price", typeof(decimal));
            return dtProduct;
        }


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string productName = teProductName.Text.Trim();
            string quantityText = seQuantity.Text.Trim();
            string priceText = tePrice.Text.Trim();

            // Validation to check if any field is empty
            if (string.IsNullOrEmpty(productName) ||
                string.IsNullOrEmpty(quantityText) ||
                string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Please fill out all fields before adding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Try parsing quantity and price
            if (!int.TryParse(quantityText, out int quantity) ||
                !decimal.TryParse(priceText, out decimal unitPrice))
            {
                MessageBox.Show("Invalid input for quantity or price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice = quantity * unitPrice;

            DataRow newRow = dtProduct.NewRow();
            newRow["ProductName"] = productName;
            newRow["Quantity"] = quantity;
            newRow["Price"] = totalPrice; 

            dtProduct.Rows.Add(newRow);

            gcOrder.DataSource = dtProduct;
            gvOrder.RefreshData();
            gvOrder.RefreshData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gvOrder.FocusedRowHandle;

            if (selectedRowHandle >= 0)
            {
                // Optional: confirm before removing
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected row?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    gvOrder.DeleteRow(selectedRowHandle); // Removes from DataTable bound to grid
                    gvOrder.RefreshData(); // Optional: refresh display
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}




