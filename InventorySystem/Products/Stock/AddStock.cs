using DevExpress.XtraBars;
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
using InventorySystem.Infrastracture.Repositories;
using InventorySystem.Infrastracture.SQL;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Collections;
using DevExpress.Utils.About;
using DevExpress.Utils;

namespace InventorySystem.Products.Stock
{
    public partial class AddStock : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
           
            LoadAllProducts();


        }

        public void AddNewStock(ProductStock productStock, string selectedLocation, Product product, Location location)
        {
            using (var connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert into Stock table
                        string insertStockSql = @"
                    INSERT INTO Stock 
                    (ProductID, Price, Quantity, ExpirationDate, Supplier)
                    VALUES
                    (@ProductID, @Price, @Quantity, @ExpirationDate, @Supplier);";

                        int rowsAffected = connection.Execute(insertStockSql, new
                        {
                            productStock.ProductID,
                            productStock.Price,
                            productStock.Quantity,
                            productStock.ExpirationDate,
                            productStock.Supplier
                        }, transaction);

                        if (rowsAffected == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Stock addition failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Validate selected location
                        if (string.IsNullOrWhiteSpace(selectedLocation))
                        {
                            transaction.Rollback();
                            MessageBox.Show("Please provide a valid location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Update the selected location (NOT insert)//
                        string updateLocationSql = @"
                    UPDATE Location
                    SET ProductID = @ProductID,
                        Capacity = @Capacity,
                        Availability = 'Occupied'
                    WHERE LocationID = @LocationID;";

                        connection.Execute(updateLocationSql, new
                        {
                            ProductID = productStock.ProductID,
                            Capacity = productStock.Quantity, // Set Capacity to the entered Quantity
                            LocationID = selectedLocation
                        }, transaction);

                        transaction.Commit();
                        MessageBox.Show("Stock and location successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Stock failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            ProductStock productStock = new ProductStock()
            {
                ProductID = GetProductID(), // ✅ Use the actual selected ProductID
                Price = price,
                Quantity = quantity,
                ExpirationDate = deExpirationDate.DateTime,
                Supplier = teSupplier.Text
            };
            GetProductID();

            string selectedLocation = lueLocation.EditValue?.ToString();
            if (string.IsNullOrWhiteSpace(selectedLocation))
            {
                MessageBox.Show("Please select a location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Location location = new Location()
            {
                ProductID = GetLocationProductID()
            };

            Product product = new Product();

            // Call the method to add the customer transaction
            AddNewStock(productStock, selectedLocation, product, location);
        }

        private void cbLocationGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = cbLocationGroup.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedGroup))
            {
                // Now passing both the ComboBoxEdit control and the selectedGroup
                ProductRepository.LoadLocation(lueLocation, selectedGroup);
            }
        }


        private void LoadAllProducts()
        {
            string query = @"
                    SELECT [ProductID], [ProductName] 
                    FROM [Product];";

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();
                    var departments = connection.Query<Product>(query).ToList();

                    if (departments.Any())
                    {
                        lueProductName.Properties.DataSource = departments;
                        lueProductName.Properties.DisplayMember = "ProductName";
                        lueProductName.Properties.ValueMember = "ProductID";
                    }
                    else
                    {
                        lueProductName.Properties.DataSource = null;
                        XtraMessageBox.Show("No departments found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetProductID()
        {
            string departmentID = string.Empty;

            if (lueProductName.EditValue != null)
            {
                departmentID = lueProductName.EditValue.ToString();
            }

            return departmentID;
        }

        private string GetLocationProductID()
        {
            string departmentID = string.Empty;

            if (lueProductName.EditValue != null)
            {
                departmentID = lueLocation.EditValue.ToString();
            }

            return departmentID;
        }
    }

}