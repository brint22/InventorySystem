using Dapper;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
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

namespace InventorySystem.Products
{
    public partial class AddProduct : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        public string GenerateProductID(string productName)
        {
            string firstLetter = string.IsNullOrEmpty(productName) ? "X" : productName.Substring(0, 1).ToUpper();
            string year = DateTime.Now.Year.ToString().Substring(2); // Gets "25" from "2025"

            int lastNumber = GetLastNumberFromDB(firstLetter, year);
            int newNumber = lastNumber + 1;

            // Format: B000125
            return string.Format("{0}{1:D4}{2}", firstLetter, newNumber, year);
        }

        private int GetLastNumberFromDB(string firstLetter, string year)
        {
            using (IDbConnection db = new SqlConnection(GlobalClass.connectionString))
            {
                string pattern = firstLetter + "%" + year; // e.g., B%25

                string query = @"
            SELECT TOP 1 CAST(SUBSTRING(ProductID, 2, 4) AS INT)
            FROM Product
            WHERE ProductID LIKE @Pattern
            ORDER BY ProductID DESC";

                return db.QueryFirstOrDefault<int?>(query, new { Pattern = pattern }) ?? 0;
            }
        }



        private void RegisterProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        if (product == null || string.IsNullOrWhiteSpace(product.ProductName))
                        {
                            MessageBox.Show("Product details are incomplete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Generate ProductID
                        char firstLetter = char.ToUpper(product.ProductName[0]);
                        string yearPart = DateTime.Now.Year.ToString().Substring(2); // also gives "25"

                        // Get the latest product number for this prefix
                        string prefix = firstLetter.ToString() + "%" + yearPart;
                        string getMaxQuery = @"
                    SELECT MAX(CAST(SUBSTRING(ProductID, 2, 4) AS INT))
                    FROM Product
                    WHERE ProductID LIKE @Prefix";

                        int latestNumber = connection.ExecuteScalar<int?>(getMaxQuery, new { Prefix = prefix }, transaction) ?? 0;
                        int nextNumber = latestNumber + 1;

                        string numberPart = nextNumber.ToString("D4");
                        string generatedID = $"{firstLetter}{numberPart}{yearPart}";
                        product.ProductID = generatedID;

                        // Insert product
                        string productQuery = @"
                    INSERT INTO Product 
                    (ProductID, ProductName, Price, Quantity, ProductRecieved, ExpirationDate)
                    VALUES 
                    (@ProductID, @ProductName, @Price, @Quantity, @ProductRecieved, @ExpirationDate)";

                        int rowsAffected = connection.Execute(productQuery, new
                        {
                            product.ProductID,
                            product.ProductName,
                            product.Price,
                            product.Quantity,
                            product.ProductRecieved,
                            product.ExpirationDate
                        }, transaction);

                        if (rowsAffected == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Product registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        transaction.Commit();
                        MessageBox.Show("Product registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tePrice.Text, out int price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(teQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Product product = new Product()
            {
                ProductName = teProductName.Text,
                Price = price,
                Quantity = quantity,
                ProductRecieved = DateTime.Now,
                ExpirationDate = deExpirationDate.DateTime

            };

            // You can now pass `product` to your RegisterProduct method or any other logic//
            RegisterProduct(product);
        }
    }

}