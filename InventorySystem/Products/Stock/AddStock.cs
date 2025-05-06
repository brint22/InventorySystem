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
                        // 1. Get product's max capacity
                        string getCapacitySql = @"SELECT Capacity FROM Product WHERE ProductID = @ProductID;";
                        int maxCapacity = connection.QuerySingleOrDefault<int>(getCapacitySql, new { productStock.ProductID }, transaction);

                        if (maxCapacity <= 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Invalid product capacity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // 2. Insert into Stock table (record of the stock)
                        string insertStockSql = @"
                    INSERT INTO Stock (ProductID, Price, Quantity, ExpirationDate, Supplier)
                    VALUES (@ProductID, @Price, @Quantity, @ExpirationDate, @Supplier);";

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

                        // 3. Split quantity across locations
                        int remainingQty = productStock.Quantity;

                        // List of candidate locations (start with selected one, then get others if needed)
                        var locationIds = new List<string> { selectedLocation };

                        // Add more available locations if quantity doesn't fit
                        string availableLocationsSql = @"
                    SELECT LocationID FROM Location
                    WHERE (Availability = 'Available' OR ProductID = @ProductID)
                      AND LocationID != @SelectedLocation
                    ORDER BY LocationID;";

                        var additionalLocations = connection.Query<string>(availableLocationsSql, new
                        {
                            ProductID = productStock.ProductID,
                            SelectedLocation = selectedLocation
                        }, transaction);

                        locationIds.AddRange(additionalLocations);

                        foreach (var locId in locationIds)
                        {
                            if (remainingQty <= 0)
                                break;

                            // Get current capacity of this location
                            string getLocCapacitySql = @"SELECT ISNULL(Capacity, 0) FROM Location WHERE LocationID = @LocationID";
                            int currentLocQty = connection.QuerySingleOrDefault<int>(getLocCapacitySql, new { LocationID = locId }, transaction);

                            int spaceLeft = maxCapacity - currentLocQty;
                            if (spaceLeft <= 0)
                                continue;

                            int qtyToAdd = Math.Min(remainingQty, spaceLeft);

                            // Update location
                            string updateLocSql = @"
                        UPDATE Location
                        SET ProductID = @ProductID,
                            Capacity = ISNULL(Capacity, 0) + @QtyToAdd,
                            Availability = 'Occupied'
                        WHERE LocationID = @LocationID";

                            connection.Execute(updateLocSql, new
                            {
                                ProductID = productStock.ProductID,
                                QtyToAdd = qtyToAdd,
                                LocationID = locId
                            }, transaction);

                            remainingQty -= qtyToAdd;
                        }

                        if (remainingQty > 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Not enough available locations to store the entire stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        transaction.Commit();
                        MessageBox.Show("Stock successfully added and allocated to location(s)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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