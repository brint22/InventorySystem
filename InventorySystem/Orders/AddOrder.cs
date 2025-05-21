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

        private void InsertToOrderSales()
        {

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
                    var productID =  gvProducts.GetRowCellValue(gvProducts.FocusedRowHandle, "ProductID")?.ToString();
                    teProductID.Text = productID;
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

        private void UpdateTotalValue()
        {
            decimal total = 0;

            foreach (DataRow row in dtProduct.Rows)
            {
                if (row["Price"] != DBNull.Value)
                {
                    total += Convert.ToDecimal(row["Price"]);
                }
            }

            // Assuming seTotalValue is a numeric control like SpinEdit or similar
            seTotalPrice.Value = total;
        }


        //Data table of Order Product
        DataTable dtProduct = new DataTable();
        private DataTable AddOrderTable()
        {
            dtProduct.Columns.Add("Count", typeof(int));
            dtProduct.Columns["Count"].AutoIncrement = true;
            dtProduct.Columns["Count"].AutoIncrementSeed = 1;
            dtProduct.Columns["Count"].AutoIncrementStep = 1;

            dtProduct.Columns.Add("ProductID", typeof(string));
            dtProduct.Columns.Add("ProductName", typeof(string));
            dtProduct.Columns.Add("Quantity", typeof(int));
            dtProduct.Columns.Add("Price", typeof(decimal));
            return dtProduct;
        }


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string productID = teProductID.Text.Trim();
            string productName = teProductName.Text.Trim();
            string quantityText = seQuantity.Text.Trim();
            string priceText = tePrice.Text.Trim();

            // Validation to check if any field is empty
            if (string.IsNullOrEmpty(productID) || 
                string.IsNullOrEmpty(productName) ||
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

            // Check if product already exists in the DataTable
            bool productExists = false;
            foreach (DataRow row in dtProduct.Rows)
            {
                if (row["ProductName"].ToString() == productName)
                {
                    // Product exists, update quantity and price
                    int existingQuantity = Convert.ToInt32(row["Quantity"]);
                    int newQuantity = existingQuantity + quantity;
                    row["Quantity"] = newQuantity;
                    row["Price"] = newQuantity * unitPrice; // Recalculate total price

                    productExists = true;
                    break;
                }
            }

            if (!productExists)
            {
                // Product doesn't exist, add new row
                DataRow newRow = dtProduct.NewRow();
                newRow["ProductID"] = productID;
                newRow["ProductName"] = productName;
                newRow["Quantity"] = quantity;
                newRow["Price"] = totalPrice;

                dtProduct.Rows.Add(newRow);
            }

            // Update grid and totals
            UpdateTotalValue();
            gcOrder.DataSource = dtProduct;
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

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            // Step 1: Insert into Orders table to get the OrderID
            int orderID = InsertOrder();  // This method will return the generated OrderID

            // Step 2: Insert into Sales table for each product in the order
            foreach (DataRow row in dtProduct.Rows)
            {
                // Get the ProductID as string (from DataTable)
                string productID = row["ProductID"].ToString();  // Assuming "ProductID" is a column in dtProduct

                // Get the Quantity directly from the DataTable
                int quantitySold = Convert.ToInt32(row["Quantity"]);  // Assuming "Quantity" is a column in dtProduct

                // Insert each sale record into the Sales table
                InsertSale(orderID, productID, quantitySold);
            }

            MessageBox.Show("Payment confirmed, and sales recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to insert into the Sales table
        private void InsertSale(int orderID, string productID, int quantitySold)
        {
            // Using the GlobalClass.connectionString for the connection
            using (SqlConnection conn = new SqlConnection(GlobalClass.connectionString))
            {
                string query = "INSERT INTO Sales (OrderID, ProductID, QuantitySold) VALUES (@OrderID, @ProductID, @QuantitySold)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@OrderID", orderID);  // Use the OrderID obtained from InsertOrder
                    cmd.Parameters.AddWithValue("@ProductID", productID);  // ProductID comes from dtProduct DataTable (as string)
                    cmd.Parameters.AddWithValue("@QuantitySold", quantitySold);  // Quantity comes from dtProduct DataTable

                    conn.Open();
                    cmd.ExecuteNonQuery();  // Insert the sale record
                    conn.Close();
                }
            }
        }

        // Method to insert into the Orders table and return the generated OrderID
        private int InsertOrder()
        {
            int orderID = 0;

            // Using the GlobalClass.connectionString for the connection
            using (SqlConnection conn = new SqlConnection(GlobalClass.connectionString))
            {
                // Since OrderID is an auto-increment column, we don't need to insert any value.
                // This query only triggers the creation of a new OrderID.
                string query = "INSERT INTO Orders DEFAULT VALUES; " +
                               "SELECT SCOPE_IDENTITY();";  // Retrieve the generated OrderID

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    orderID = Convert.ToInt32(cmd.ExecuteScalar());  // Get the generated OrderID
                    conn.Close();
                }
            }

            return orderID;
        }


        private void seAddAmount_EditValueChanged(object sender, EventArgs e)
        {
            decimal totalPrice = seTotalPrice.Value;
            decimal addAmount = seAddAmount.Value;
            decimal change = addAmount - totalPrice;

            if (addAmount < totalPrice)
            {
                seAddAmount.ForeColor = Color.Red;
                seChange.Value = 0;
            }
            else
            {
                seAddAmount.ForeColor = Color.Black;
                seChange.Value = change;
            }
        }

        private void seChange_EditValueChanged(object sender, EventArgs e)
        {
            decimal totalPrice = seTotalPrice.Value;
            decimal addAmount = seAddAmount.Value;
            decimal change = addAmount - totalPrice;

            if (addAmount < totalPrice)
            {
                seAddAmount.ForeColor = Color.Red;
                seChange.Value = 0;
            }
            else
            {
                seAddAmount.ForeColor = Color.Black;
                seChange.Value = change;
            }
        }

        private void gcOrder_Click(object sender, EventArgs e)
        {

        }
    }
}




