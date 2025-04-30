using Dapper;
using DevExpress.Office.Services;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

                        // Check for existing ProductName
                        string checkQuery = "SELECT COUNT(*) FROM Product WHERE ProductName = @ProductName";
                        int count = connection.ExecuteScalar<int>(checkQuery, new { product.ProductName }, transaction);
                        if (count > 0)
                        {
                            MessageBox.Show("A product with the same name already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Generate ProductID
                        char firstLetter = char.ToUpper(product.ProductName[0]);
                        string yearPart = DateTime.Now.Year.ToString().Substring(2);
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
                        product.CategoryID = GetCategoryID();

                        // Insert product into Product table
                        string productQuery = @"
                    INSERT INTO Product 
                    (ProductID, ProductName, Price, Quantity, ProductRecieved, ExpirationDate, CategoryID, BrandName, Supplier)
                    VALUES 
                    (@ProductID, @ProductName, @Price, @Quantity, @ProductRecieved, @ExpirationDate, @CategoryID, @BrandName, @Supplier)";

                        int rowsAffected = connection.Execute(productQuery, new
                        {
                            product.ProductID,
                            product.ProductName,
                            product.Price,
                            product.Quantity,
                            product.ProductRecieved,
                            product.ExpirationDate,
                            product.CategoryID,
                            product.BrandName,
                            product.Supplier
                        }, transaction);

                        if (rowsAffected == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Product registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Location assignment logic
                        int maxCapacity = 100;
                        int remainingQty = product.Quantity;

                        string selectedLocation = cbLocation.SelectedItem?.ToString();
                        if (string.IsNullOrWhiteSpace(selectedLocation))
                        {
                            MessageBox.Show("Please select a valid Location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string getLocationsQuery = @"
                    SELECT LocationID 
                    FROM Location 
                    WHERE Availability = 'Available'
                    ORDER BY 
                        LEFT(LocationID, 1),
                        TRY_CAST(PARSENAME(REPLACE(LocationID, '-', '.'), 3) AS INT),
                        TRY_CAST(PARSENAME(REPLACE(LocationID, '-', '.'), 2) AS INT),
                        TRY_CAST(PARSENAME(REPLACE(LocationID, '-', '.'), 1) AS INT)";

                        var allLocations = connection.Query<string>(getLocationsQuery, null, transaction).ToList();
                        int startIndex = allLocations.IndexOf(selectedLocation);

                        if (startIndex == -1)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Selected location is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        bool started = false;

                        foreach (var locId in allLocations)
                        {
                            if (!started)
                            {
                                if (locId == selectedLocation)
                                    started = true;
                                else
                                    continue;
                            }

                            if (remainingQty <= 0)
                                break;

                            int assignQty = Math.Min(remainingQty, maxCapacity);

                            string updateLoc = @"
                        UPDATE Location
                        SET ProductID = @ProductID,
                            Availability = 'Occupied',
                            Capacity = @Capacity
                        WHERE LocationID = @LocationID";

                            connection.Execute(updateLoc, new
                            {
                                ProductID = product.ProductID,
                                Capacity = assignQty,
                                LocationID = locId
                            }, transaction);

                            remainingQty -= assignQty;
                        }

                        if (remainingQty > 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Not enough available locations to store the full quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void LoadLocation()
        {
            string connStr = GlobalClass.connectionString;
            string query = @"
                            SELECT [LocationID] 
                            FROM [WAREHOUSEISDB].[dbo].[Location]
                            WHERE Availability = 'Available'
                            ORDER BY 
                                LEFT([LocationID], CHARINDEX('-', [LocationID]) - 1), -- First part: letter (A, B, etc.)
                                CAST(SUBSTRING([LocationID], CHARINDEX('-', [LocationID], 1) + 1, CHARINDEX('-', [LocationID], CHARINDEX('-', [LocationID]) + 1) - CHARINDEX('-', [LocationID]) - 1) AS INT) ASC, -- Second part: the first number
                                CAST(SUBSTRING([LocationID], CHARINDEX('-', [LocationID], CHARINDEX('-', [LocationID]) + 1) + 1, LEN([LocationID])) AS INT) ASC -- Third part: the second number
                            ";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var locationIds = connection.Query<string>(query).ToList();

                    cbLocation.Properties.Items.Clear();
                    cbLocation.Properties.Items.AddRange(locationIds);
                    cbLocation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

                    if (!locationIds.Any())
                    {
                        XtraMessageBox.Show("No locations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCategory()
        {
            string connStr = GlobalClass.connectionString;

            string query = @"
                                SELECT [CategoryID], 
                                       CONCAT(UPPER(LEFT([CategoryName], 1)), LOWER(SUBSTRING([CategoryName], 2, LEN([CategoryName]) - 1))) AS CategoryName
                                FROM [Category];";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var category = connection.Query<Category>(query).ToList();

                    if (category.Any())
                    {
                        lueCategory.Properties.DataSource = category;
                        lueCategory.Properties.DisplayMember = "CategoryName";
                        lueCategory.Properties.ValueMember = "CategoryID";
                    }
                    else
                    {
                        lueCategory.Properties.DataSource = null;
                        XtraMessageBox.Show("No categories found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(teProductName.Text) ||
                string.IsNullOrWhiteSpace(teBrandName.Text) ||
                string.IsNullOrWhiteSpace(teSupplier.Text))
            {
                MessageBox.Show("Please fill in all required fields (Product Name, Brand Name, and Supplier).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            if (deExpirationDate.DateTime <= DateTime.Now)
            {
                MessageBox.Show("Expiration date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm submission
            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to add this product?",
                "Confirm Product Registration",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            // Create the product object
            Product product = new Product()
            {
                ProductName = teProductName.Text.Trim(),
                Price = price,
                Quantity = quantity,
                ProductRecieved = DateTime.Now,
                ExpirationDate = deExpirationDate.DateTime,
                BrandName = teBrandName.Text.Trim(),
                Supplier = teSupplier.Text.Trim()
            };

            // Call the registration logic
            RegisterProduct(product);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadLocation();
            LoadLocationGroup();
        }

        private int GetCategoryID()
        {
            int intcategoryID = 0;

            if (lueCategory.EditValue != null)
            {
                intcategoryID = (int)lueCategory.EditValue;

            }
            else
            {
                intcategoryID = 0;
            }
            return intcategoryID;
        }

        private void tePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and control keys (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block any non-digit characters
            }
        }

        private void cbLocationGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPrefix = cbLocationGroup.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedPrefix))
            {
                LoadLcation(selectedPrefix); // This loads all matching LocationIDs into cbLocation
            }
        }

        private void LoadLocationGroup()
        {
            string query = @"
                            SELECT DISTINCT LEFT(LocationID, CHARINDEX('-', LocationID) - 1) AS LocationGroup
                            FROM [WAREHOUSEISDB].[dbo].[Location]
                            WHERE LocationID LIKE 'A%'
                               OR LocationID LIKE 'B%'
                               OR LocationID LIKE 'C%'
                               OR LocationID LIKE 'D%'
                            ORDER BY LocationGroup";

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                var locationGroups = connection.Query<string>(query);

                cbLocationGroup.Properties.Items.Clear();
                foreach (var group in locationGroups)
                {
                    cbLocationGroup.Properties.Items.Add(group);
                }
            }
        }

        private void LoadLcation(string locationPrefix)
        {
            string query = @"
                            SELECT [LocationID] 
                            FROM [WAREHOUSEISDB].[dbo].[Location]
                            WHERE Availability = 'Available'
                            AND LEFT([LocationID], CHARINDEX('-', [LocationID]) - 1) = @LocationPrefix
                            ORDER BY 
                                LEFT([LocationID], CHARINDEX('-', [LocationID]) - 1),
                                CAST(SUBSTRING([LocationID], CHARINDEX('-', [LocationID], 1) + 1, 
                                CHARINDEX('-', [LocationID], CHARINDEX('-', [LocationID]) + 1) - CHARINDEX('-', [LocationID]) - 1) AS INT),
                                CAST(SUBSTRING([LocationID], CHARINDEX('-', [LocationID], CHARINDEX('-', [LocationID]) + 1) + 1, 
                                LEN([LocationID])) AS INT) ";

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                var locationList = connection.Query<string>(query, new { LocationPrefix = locationPrefix });

                cbLocation.Properties.Items.Clear();
                foreach (var location in locationList)
                {
                    cbLocation.Properties.Items.Add(location);
                }
            }
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = cbLocationGroup.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedGroup))
            {
                LoadLcation(selectedGroup);
            }
        }

        //private void tePrice_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Allow digits, comma, dot, and control characters like backspace
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }

        //    //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    //{
        //    //    e.Handled = true;
        //    //}
        //}

        //private void teQuantity_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Allow digits, commas, and control keys (like Backspace)
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private int GetLocationID()
        //{
        //    int intlocationID = 0;

        //    if (lueLocation.EditValue != null)
        //    {
        //        intlocationID = (int)lueLocation.EditValue;

        //    }
        //    else
        //    {
        //        intlocationID = 0;
        //    }
        //    return intlocationID;
        //}
    }

}