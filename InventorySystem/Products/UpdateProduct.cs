using DevExpress.XtraBars;
using InventorySystem.Employees;
using InventorySystem.Models;
using InventorySystem.views;
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
using DevExpress.XtraEditors;

namespace InventorySystem.Products
{
    public partial class UpdateProduct : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string ProductID { get; set; }

        private ViewProduct viewProduct;
        public UpdateProduct(string productID, ViewProduct viewProduct)
        {
            InitializeComponent();

            this.ProductID = productID;
            this.viewProduct = viewProduct;
        }


        public void UpdateProductInformation(Product product)
        {
            if (product == null || string.IsNullOrWhiteSpace(product.ProductID))
            {
                MessageBox.Show("Product details are missing or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Get CategoryID from CategoryName
                        string getCategoryIdQuery = "SELECT CategoryID FROM Category WHERE CategoryName = @CategoryName";
                        int categoryId = connection.ExecuteScalar<int>(getCategoryIdQuery, new { CategoryName = product.CategoryName }, transaction);

                        if (categoryId == 0)
                        {
                            MessageBox.Show("Invalid category name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        // Update Product using CategoryID
                        string updateQuery = @"
                UPDATE Product 
                SET 
                    ProductName = @ProductName, 
                    CategoryID = @CategoryID, 
                    Price = @Price, 
                    Capacity = @Capacity
                WHERE ProductID = @ProductID";

                        int rowsAffected = connection.Execute(updateQuery, new
                        {
                            product.ProductID,
                            product.ProductName,
                            CategoryID = categoryId,
                            product.Price,
                            product.Capacity
                        }, transaction);

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Product update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }

                        transaction.Commit();
                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Update failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public event EventHandler ProductUpdated; // Declare this at the top of your form

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(teProductID.Text))
            {
                MessageBox.Show("Product ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(teProductName.Text))
            {
                MessageBox.Show("Product Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(lueCategory.Text))
            {
                MessageBox.Show("Category is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tePrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("A valid Price is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(teCapacity.Text, out int capacity) || capacity < 0)
            {
                MessageBox.Show("A valid Capacity is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ask for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to update this product?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; // Cancelled by user
            }

            // Create product object
            var product = new Product
            {
                ProductID = teProductID.Text.Trim(),
                ProductName = teProductName.Text.Trim(),
                CategoryName = lueCategory.Text.Trim(),
                Price = price,
                Capacity = capacity
            };

            try
            {
                // Call update method
                UpdateProductInformation(product);

                // Notify the main form to refresh product list
                ProductUpdated?.Invoke(this, EventArgs.Empty);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategory()
        {
            string connStr = GlobalClass.connectionString;

            string query = @"
        SELECT CategoryID, CategoryName
        FROM Category";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var categoryList = connection.Query<Category>(query).ToList(); // Assuming you have a Category model

                    lueCategory.Properties.DataSource = categoryList;
                    lueCategory.Properties.DisplayMember = "CategoryName";
                    lueCategory.Properties.ValueMember = "CategoryID";
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
    }
}