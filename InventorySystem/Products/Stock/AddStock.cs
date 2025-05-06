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
                        // Retrieve the product's capacity
                        string getCapacitySql = @"
                    SELECT Capacity 
                    FROM Product 
                    WHERE ProductID = @ProductID;";

                        int productCapacity = connection.QuerySingleOrDefault<int>(getCapacitySql, new { ProductID = productStock.ProductID }, transaction);

                        // Check if the quantity being added exceeds the product's capacity
                        if (productStock.Quantity > productCapacity)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Quantity cannot exceed the product's capacity of {productCapacity}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Validate selected location
                        if (string.IsNullOrWhiteSpace(selectedLocation))
                        {
                            transaction.Rollback();
                            MessageBox.Show("Please provide a valid location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Step 1: Check if the selected location has "Available" status
                        string checkLocationSql = @"
                    SELECT LocationID, Availability
                    FROM Location
                    WHERE LocationID = @LocationID AND Availability = 'Available';";

                        var locationResult = connection.QueryFirstOrDefault(checkLocationSql, new { LocationID = selectedLocation }, transaction);

                        if (locationResult == null)
                        {
                            // If no available location is found, rollback and show error
                            transaction.Rollback();
                            MessageBox.Show("No available location found. Please choose a different location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

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

                        // Step 2: Update the available location
                        string updateLocationSql = @"
                    UPDATE Location
                    SET ProductID = @ProductID,
                        Capacity = COALESCE(Capacity, 0) + @NewQuantity,  -- Add the newly added stock quantity to Capacity
                        Availability = 'Occupied'
                    WHERE LocationID = @LocationID;";

                        int rowsUpdated = connection.Execute(updateLocationSql, new
                        {
                            ProductID = productStock.ProductID,
                            NewQuantity = productStock.Quantity,
                            LocationID = selectedLocation
                        }, transaction);

                        if (rowsUpdated == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Location update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

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