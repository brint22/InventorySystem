using Dapper;
using DevExpress.Office.Services;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using InventorySystem.Infrastracture.SQL;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Infrastracture.Repositories
{
    public class ProductRepository
    {

        private readonly string _connectionString;
            public ProductRepository(string connectionString)
            {
                _connectionString = connectionString;
            }

        public void InsertLocation()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        for (char letter = 'A'; letter <= 'K'; letter++)
                        {
                            for (int i = 1; i <= 5; i++)
                            {
                                for (int j = 1; j <= 10; j++)
                                {
                                    var location = new Location
                                    {
                                        LocationID = $"{letter}-{i}-{j}"
                                    };

                                    connection.Execute(
                                        ProductSQL.InsertLocation,
                                        location,
                                        transaction
                                    );
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Failed to insert locations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public DataTable GetAllLocations()
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = ProductSQL.GetAllLocations;

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            return dataTable;
                        }
                    }
                }
            }

            public void UpdateLocation(string locationId)
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        string query = ProductSQL.UpdateLocationQuery;

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Availability", "available");
                            command.Parameters.AddWithValue("@LocationID", locationId);

                            command.ExecuteNonQuery();
                        }
                    }
                }

            public List<Location> GetLocationsByAvailability(string availability)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    return connection.Query<Location>(ProductSQL.GetLocationsByAvailability, new { Availability = availability }).ToList();
                }
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

        public void RegisterProduct(Product product)
        {
            if (product == null || string.IsNullOrWhiteSpace(product.ProductName))
            {
                MessageBox.Show("Product details are incomplete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // ✅ Check for duplicate product name
                        int count = connection.ExecuteScalar<int>(ProductSQL.CheckIfProductExists, new { product.ProductName }, transaction);
                        if (count > 0)
                        {
                            MessageBox.Show("A product with the same name already exists.", "Duplicate Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            transaction.Rollback();
                            return;
                        }

                        // ✅ Generate ProductID (e.g., A0001 24)
                        char firstLetter = char.ToUpper(product.ProductName[0]);
                        string yearPart = DateTime.Now.Year.ToString().Substring(2);
                        string prefix = firstLetter.ToString() + "%" + yearPart;

                        int latestNumber = connection.ExecuteScalar<int?>(ProductSQL.GetMaxProductNumber, new { Prefix = prefix }, transaction) ?? 0;
                        string numberPart = (latestNumber + 1).ToString("D4");
                        product.ProductID = $"{firstLetter}{numberPart}{yearPart}";

                        // ✅ Insert product
                        int rowsAffected = connection.Execute(ProductSQL.InsertProduct, new
                        {
                            product.ProductID,
                            product.ProductName,
                            product.CategoryID,
                            product.Price,
                            product.Capacity
                        }, transaction);

                        if (rowsAffected == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Product registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // ✅ Commit if all goes well
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Registration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public int GetCategoryID(LookUpEdit lookupEdit)
        {
            return lookupEdit.EditValue != null ? (int)lookupEdit.EditValue : 0;
        }

        public static void LoadCategory(LookUpEdit lueCategory)
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

        public static void LoadLocation(LookUpEdit lookUpEdit, string locationPrefix, string productId)
        {
            string query = @"
    SELECT 
        l.LocationID, 
        CASE 
            WHEN l.Availability = 'Available' THEN 'Available'
            ELSE CAST(ISNULL(l.Capacity, 0) AS VARCHAR(20)) + '/' + CAST(ISNULL(p.Capacity, 0) AS VARCHAR(20))
        END AS Capacity
    FROM [Location] l
    LEFT JOIN Product p ON l.ProductID = p.ProductID
    WHERE 
        LEFT(l.LocationID, CHARINDEX('-', l.LocationID) - 1) = @LocationPrefix
        AND (
            l.Availability = 'Available'
            OR (l.ProductID = @ProductID AND ISNULL(l.Capacity, 0) < ISNULL(p.Capacity, 0))
        )
    ORDER BY 
        LEFT(l.LocationID, CHARINDEX('-', l.LocationID) - 1),
        CAST(SUBSTRING(l.LocationID, CHARINDEX('-', l.LocationID) + 1, CHARINDEX('-', l.LocationID, CHARINDEX('-', l.LocationID) + 1) - CHARINDEX('-', l.LocationID) - 1) AS INT),
        CAST(SUBSTRING(l.LocationID, CHARINDEX('-', l.LocationID, CHARINDEX('-', l.LocationID) + 1) + 1, LEN(l.LocationID)) AS INT);";

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                var locationList = connection.Query<Location>(query, new { LocationPrefix = locationPrefix, ProductID = productId }).ToList();

                lookUpEdit.Properties.DataSource = locationList;
                lookUpEdit.Properties.DisplayMember = "LocationID";
                lookUpEdit.Properties.ValueMember = "LocationID";
                lookUpEdit.Properties.NullText = "Select Location";
                lookUpEdit.EditValue = null;

                lookUpEdit.Properties.Columns.Clear();
                lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("LocationID", "Location"));
                lookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Capacity", "Capacity"));
            }
        }




        public List<Location> GetLocationsByGroup(string groupLetter)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // If groupLetter is "ALL", fetch all locations
                string query = string.IsNullOrEmpty(groupLetter) || groupLetter.Equals("ALL", StringComparison.OrdinalIgnoreCase)
                    ? ProductSQL.GetAllLocations // Query for all locations
                    : ProductSQL.GetLocationsByGroup; // Query for filtered locations by group

                var locations = connection.Query<Location>(
                    query,
                    new { GroupLetter = groupLetter }
                ).ToList();

                return locations;
            }
        }

    }



    //public void addlocation(Location location)
    //{
    //    using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
    //    {
    //        string sql = "INSERT INTO Location (LocationID, ProductID, Availability) VALUES (@LocationID, '', 'Availability')";
    //        connection.Execute(sql, location);
    //    }
    //}

}
