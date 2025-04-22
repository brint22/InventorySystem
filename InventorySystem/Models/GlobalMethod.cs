using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Models
{
    public class GlobalMethod
    {
        public static void LoadEmployeeData(string roleFilter, GridControl gcEmployee)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
            SELECT e.EmployeeID, 
                (e.FirstName + ' ' + 
                ISNULL(e.MiddleName + ' ', '') +
                e.LastName + ' ' + 
                ISNULL(e.NameExtension, '')) AS EmployeeName,
                
                FORMAT(e.DateOfBirth, 'MMMM dd, yyyy') AS DateOfBirth,
                
                -- Concatenated Address
                (
                    ISNULL('Barangay ' + a.BarangayName + ', ', '') +
                    ISNULL(a.MunicipalityName + ', ', '') +
                    ISNULL(a.ProvinceName + ', ', '') +
                    ISNULL(CAST(a.ZipCodeNumber AS VARCHAR) + ', ', '') +
                    ISNULL(a.CountryName, '')
                ) AS Address,

                r.RoleID,
                UPPER(LEFT(r.RoleName, 1)) + LOWER(SUBSTRING(r.RoleName, 2, LEN(r.RoleName))) AS RoleName,
                ei.ImageData,
                
                CAST(
                    DATEDIFF(YEAR, e.DateOfBirth, CAST(GETDATE() AS DATE)) - 
                    CASE 
                        WHEN MONTH(e.DateOfBirth) > MONTH(CAST(GETDATE() AS DATE)) 
                            OR (MONTH(e.DateOfBirth) = MONTH(CAST(GETDATE() AS DATE)) 
                            AND DAY(e.DateOfBirth) > DAY(CAST(GETDATE() AS DATE))) 
                        THEN 1 ELSE 0 
                    END 
                AS VARCHAR) + ' years old' AS Age,                   

                e.PhoneNumber,
                FORMAT(e.DateHired, 'MMMM dd, yyyy') AS DateHired,
                e.Gender,
                e.CivilStatus

            FROM Employee e
            LEFT JOIN EmployeeImage ei ON e.ImageID = ei.ImageID
            LEFT JOIN Role r ON e.RoleID = r.RoleID
            LEFT JOIN Address a ON e.AddressID = a.AddressID  -- Adjusted the join condition
            WHERE (@RoleFilter = 'All' OR r.RoleName = @RoleFilter)
            ORDER BY EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoleFilter", roleFilter);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    // Ensure EmployeeImage stays as byte[]
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["ImageData"] == DBNull.Value)
                        {
                            row["ImageData"] = new byte[0]; // Store empty byte[] instead of NULL
                        }
                    }

                    // Bind to GridControl
                    gcEmployee.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LoadCategoryData(GridControl gcCategory)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
            SELECT 
                CategoryID,
                CategoryName
            FROM 
                Category
            ORDER BY 
                CategoryID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    gcCategory.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void LoadProductList(GridControl gcProductList)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT
                         p.[ProductID]
                        ,p.[ProductName]
                        ,p.[Price]
                        ,p.[Quantity]
                        ,p.[ExpirationDate]
                        ,p.[ProductRecieved]
                        ,c.CategoryName
                        ,p.[BrandName]
                        ,p.[Supplier]
                        ,l.LocationID	                    
                        ,l.Availability 
                  FROM [WAREHOUSEISDB].[dbo].[Product] p
                  LEFT JOIN Category c
                  ON c.CategoryID  = p.CategoryID
                  LEFT JOIN Location l
                  ON l.ProductID = p.ProductID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    gcProductList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void LoadLocationList(GridControl gcProductList)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"SELECT LocationID, 
                        LocationStart, 
                        LocationFinish, 
                        Availability
                        FROM Location";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    gcProductList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading location: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
