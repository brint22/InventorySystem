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
                        string getCapacitySql = @"SELECT Capacity FROM Product WHERE ProductID = @ProductID;";
                        int maxCapacity = connection.QuerySingleOrDefault<int>(getCapacitySql, new { productStock.ProductID }, transaction);

                        if (maxCapacity <= 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Invalid product capacity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

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

                        int remainingQty = productStock.Quantity;

                        // Get all locations sorted alphanumerically
                        string allLocationsSql = @"
                    SELECT LocationID FROM Location
                    WHERE (Availability = 'Available' OR ProductID = @ProductID)
                    ORDER BY 
                        SUBSTRING(LocationID, 1, 1),
                        CAST(PARSENAME(REPLACE(LocationID, '-', '.'), 2) AS INT),
                        CAST(PARSENAME(REPLACE(LocationID, '-', '.'), 1) AS INT);";

                        var allAvailableLocations = connection.Query<string>(allLocationsSql, new
                        {
                            ProductID = productStock.ProductID
                        }, transaction).ToList();

                        // Start from selected location *and after*
                        int selectedIndex = allAvailableLocations.IndexOf(selectedLocation);
                        if (selectedIndex == -1)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Selected location not found or unavailable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var orderedLocations = allAvailableLocations.Skip(selectedIndex).ToList();

                        foreach (var locId in orderedLocations)
                        {
                            if (remainingQty <= 0)
                                break;

                            string getLocCapacitySql = @"SELECT ISNULL(Capacity, 0) FROM Location WHERE LocationID = @LocationID";
                            int currentLocQty = connection.QuerySingleOrDefault<int>(getLocCapacitySql, new { LocationID = locId }, transaction);

                            int spaceLeft = maxCapacity - currentLocQty;
                            if (spaceLeft <= 0)
                                continue;

                            int qtyToAdd = Math.Min(remainingQty, spaceLeft);

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
                            MessageBox.Show("Not enough space in locations after selected one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        transaction.Commit();
                        MessageBox.Show("Stock successfully added and distributed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ResetAllFields();
        }

        private void cbLocationGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = cbLocationGroup.SelectedItem?.ToString();
            string selectedProductId = lueProductName.EditValue?.ToString();

            if (!string.IsNullOrEmpty(selectedGroup) && !string.IsNullOrEmpty(selectedProductId))
            {
                ProductRepository.LoadLocation(lueLocation, selectedGroup, selectedProductId);
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

        private void ResetAllFields()
        {
            lueProductName.Clear();
            tePrice.Clear();
            teQuantity.Clear();
            deExpirationDate.Clear();
            cbLocationGroup.Properties.Items.Clear();
            cbLocationGroup.EditValue = null;
            lueLocation.Properties.DataSource = null;        
            lueLocation.Properties.Columns.Clear();          
            lueLocation.Properties.DisplayMember = string.Empty;
            lueLocation.Properties.ValueMember = string.Empty;
            lueLocation.EditValue = null;                    
            lueLocation.Properties.NullText = "";            

            teSupplier.Clear();
        }

        private void lueProductName_EditValueChanged(object sender, EventArgs e)
        {


            if (lueProductName.EditValue == null)
                return;

            // Clear previous values
            cbLocationGroup.Properties.Items.Clear();
            cbLocationGroup.EditValue = null;
            lueLocation.Properties.DataSource = null;
            lueLocation.Properties.Columns.Clear();
            lueLocation.Properties.DisplayMember = string.Empty;
            lueLocation.Properties.ValueMember = string.Empty;
            lueLocation.EditValue = null;

            // Populate A–K
            for (char c = 'A'; c <= 'K'; c++)
            {
                cbLocationGroup.Properties.Items.Add(c.ToString());
            }

            // Optionally select the first one by default
            cbLocationGroup.SelectedIndex = 0;

        }
    }
}
    