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
using DevExpress.Utils.About;

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
                                CASE 
                                    WHEN ISNULL(loc.TotalCapacity, 0) = 0 THEN 'No Stock'
                                    ELSE CAST(loc.TotalCapacity AS VARCHAR)
                                END AS Capacity
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
                                loc.TotalCapacity;";
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

            // Validate if there is enough stock
            int availableStock = GetAvailableStock(productID); // Get the available stock for the product
            if (quantity > availableStock)
            {
                MessageBox.Show(
                    $"Not enough stock for Product ID: {productID}.\n" +
                    $"Requested: {quantity}, Available: {availableStock}",
                    "Insufficient Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return; // Stop the process if stock is insufficient
            }

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
            // Step 1: Show confirmation message box
            var confirmResult = MessageBox.Show(
                "Are you sure you want to confirm this order?",
                "Confirm Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.No)
                return;

            // Step 2: Validate stock for each product
            foreach (DataRow row in dtProduct.Rows)
            {
                string productID = row["ProductID"].ToString();
                int quantityRequested = Convert.ToInt32(row["Quantity"]);

                int availableStock = GetAvailableStock(productID); // Add this method below

                if (quantityRequested > availableStock)
                {
                    MessageBox.Show(
                        $"Not enough stock for Product ID: {productID}.\n" +
                        $"Requested: {quantityRequested}, Available: {availableStock}",
                        "Insufficient Stock",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            // Step 3: Create the Order object
            Order order = new Order()
            {
                TotalPrice = seTotalPrice.Text.Trim(),
                PaymentAmount = seAddAmount.Text.Trim(),
                OrderID = GenerateOrderID(),
                OrderDate = DateTime.Now
            };

            // Step 4: Insert Order using Dapper
            using (var connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                string insertOrderQuery = @"
            INSERT INTO Orders (OrderID, TotalPrice, PaymentAmount, OrderDate)
            VALUES (@OrderID, @TotalPrice, @PaymentAmount, @OrderDate)";

                connection.Execute(insertOrderQuery, order);
            }

            // Step 5: Insert Sales and Deduct Stock
            foreach (DataRow row in dtProduct.Rows)
            {
                string productID = row["ProductID"].ToString();
                int quantitySold = Convert.ToInt32(row["Quantity"]);
                decimal totalPrice = Convert.ToDecimal(row["Price"]);

                InsertSale(order.OrderID, productID, quantitySold, totalPrice);
                DeductStockQuantity(productID, quantitySold);
            }

            // Step 6: Refresh the data source
            gcProducts.DataSource = GetStock();
            gcProducts.RefreshDataSource();

            MessageBox.Show("Payment confirmed, sales recorded, and stock updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Helper method to get available stock for a product
        private int GetAvailableStock(string productID)
        {
            using (var connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                string query = "SELECT ISNULL(SUM(Quantity), 0) FROM Stock WHERE ProductID = @ProductID";
                return connection.ExecuteScalar<int>(query, new { ProductID = productID });
            }
        }


        private void InsertSale(string orderID, string productID, int quantitySold, decimal totalPrice)
        {
            using (var conn = new SqlConnection(GlobalClass.connectionString))
            {
                string query = @"
            INSERT INTO Sales (OrderID, ProductID, QuantitySold, Price)
            VALUES (@OrderID, @ProductID, @QuantitySold, @Price);";

                conn.Execute(query, new
                {
                    OrderID = orderID,           // This should match the OrderID from InsertOrder
                    ProductID = productID,
                    QuantitySold = quantitySold,
                    Price = totalPrice
                });
            }
        }

        // Method to insert into the Orders table and return the generated OrderID
        private int InsertOrder(Order order)
        {
            string generatedID = GenerateOrderID(); // e.g., "0525-0001"
            order.OrderID = generatedID;

            using (var conn = new SqlConnection(GlobalClass.connectionString))
            {
                string query = @"
        INSERT INTO Orders (OrderID, TotalPrice, PaymentAmount)
        VALUES (@OrderID, @TotalPrice, @PaymentAmount);";

                conn.Execute(query, new
                {
                    OrderID = order.OrderID,
                    TotalPrice = order.TotalPrice,
                    PaymentAmount = order.PaymentAmount
                });

                // Optionally return something; for now, return 1 to indicate success
                return 1;
            }
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
            else if ((addAmount > totalPrice))
            {
                seAddAmount.ForeColor = Color.Green;
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

        private void DeductStockQuantity(string productID, int quantitySold)
        {
            using (var conn = new SqlConnection(GlobalClass.connectionString))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Deduct from Stock table first
                        string updateStock = @"
                    UPDATE Stock
                    SET Quantity = Quantity - @QuantitySold
                    WHERE ProductID = @ProductID AND Quantity >= @QuantitySold";

                        int rowsAffected = conn.Execute(updateStock, new
                        {
                            ProductID = productID,
                            QuantitySold = quantitySold
                        }, transaction);

                        if (rowsAffected == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Not enough stock for Product ID: {productID}", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // LIFO deduction from Location based on LocationID descending
                        string selectLocations = @"
                    SELECT LocationID, Capacity
                    FROM Location
                    WHERE ProductID = @ProductID AND Capacity > 0
                    ORDER BY LocationID DESC";

                        var locations = conn.Query(selectLocations, new { ProductID = productID }, transaction).ToList();

                        int remainingToDeduct = quantitySold;

                        foreach (var loc in locations)
                        {
                            if (remainingToDeduct <= 0)
                                break;

                            int deduct = Math.Min(loc.Capacity, remainingToDeduct);

                            // Deduct capacity from this location
                            string updateLocation = @"
                        UPDATE Location
                        SET Capacity = Capacity - @Deduct
                        WHERE LocationID = @LocationID";

                            conn.Execute(updateLocation, new
                            {
                                Deduct = deduct,
                                LocationID = loc.LocationID
                            }, transaction);

                            // Re-check capacity AFTER deduction
                            string getUpdatedCapacity = @"
                        SELECT Capacity FROM Location WHERE LocationID = @LocationID";

                            int updatedCapacity = conn.ExecuteScalar<int>(getUpdatedCapacity, new
                            {
                                LocationID = loc.LocationID
                            }, transaction);

                            // If capacity is now 0, mark location available and remove ProductID
                            if (updatedCapacity == 0)
                            {
                                string updateAvailability = @"
                                            UPDATE Location
                                            SET Availability = 'Available',
                                                ProductID = NULL
                                            WHERE LocationID = @LocationID";
                                conn.Execute(updateAvailability, new { LocationID = loc.LocationID }, transaction);

                                // 🔁 Optionally delete LocationStock record
                                string deleteLocationStock = @"
                                            DELETE FROM LocationStock
                                            WHERE LocationID = @LocationID AND StockID IN (
                                                SELECT StockID FROM Stock WHERE ProductID = @ProductID
                                            )";
                                conn.Execute(deleteLocationStock, new
                                {
                                    LocationID = loc.LocationID,
                                    ProductID = productID
                                }, transaction);
                            }


                            remainingToDeduct -= deduct;
                        }

                        if (remainingToDeduct > 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Not enough location capacity for Product ID: {productID}", "Location Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error during deduction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        private static string GenerateOrderID()
        {
            string datePart = DateTime.Now.ToString("MMyy"); // e.g., "0525" for May 2025

            using (var connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                // Get the highest OrderID starting with current datePasrt
                string sql = @"
                            SELECT MAX(OrderID) 
                            FROM Orders 
                            WHERE LEFT(OrderID, 4) = @DatePart";

                string lastOrderId = connection.ExecuteScalar<string>(sql, new { DatePart = datePart });

                int nextNumber = 1; // Default for first order

                if (!string.IsNullOrEmpty(lastOrderId))
                {
                    // Extract the numeric part and increment
                    string[] parts = lastOrderId.Split('-');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int lastNumber))
                    {
                        nextNumber = lastNumber + 1;
                    }
                }

                // Format to 4-digit padded number, e.g., 0001
                string numberPart = nextNumber.ToString("D4");

                return $"{datePart}-{numberPart}";
            }
        }


    }
}




