using DevExpress.XtraBars;
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

        //public string GenerateProductID(string productName)
        //{
        //    string[] words = productName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //    string initials = string.Concat(words.Take(2).Select(w => char.ToUpper(w[0])));

        //    int year = DateTime.Now.Year % 100; // Gets last two digits of the year
        //    int lastNumber = GetLastProductNumberFromDB(initials); // Implement this to get the last number used
        //    int newNumber = lastNumber + 1;

        //    return $"{initials}{newNumber:D6}{year:D2}";
        //}

        //private void RegisterProduct(Product product)
        //{
        //    using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
        //    {
        //        connection.Open();
        //        using (var transaction = connection.BeginTransaction())
        //        {
        //            try
        //            {
        //                if (product == null || string.IsNullOrWhiteSpace(product.ProductName))
        //                {
        //                    MessageBox.Show("Product details are incomplete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }

        //                // Generate ProductID
        //                string generatedID = GenerateProductID(product.ProductName); // Your custom method
        //                product.ProductID = generatedID;

        //                // Insert product
        //                string productQuery = @"
        //        INSERT INTO Product 
        //        (ProductID, ProductName, Price, Quantity, ProductRecieved, ExpirationDate)
        //        VALUES 
        //        (@ProductID, @ProductName, @Price, @Quantity, @ProductRecieved, @ExpirationDate)";

        //                int rowsAffected = connection.Execute(productQuery, new
        //                {
        //                    product.ProductID,
        //                    product.ProductName,
        //                    product.Price,
        //                    product.Quantity,
        //                    product.ProductRecieved,
        //                    product.ExpirationDate
        //                }, transaction);

        //                if (rowsAffected == 0)
        //                {
        //                    transaction.Rollback();
        //                    MessageBox.Show("Product registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return;
        //                }

        //                transaction.Commit();
        //                MessageBox.Show("Product registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            catch (Exception ex)
        //            {
        //                transaction.Rollback();
        //                MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}

    }
}