﻿using DevExpress.XtraGrid;
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
                        ,c.CategoryName
                        ,c.CategoryID
                        ,p.[Price]    
                        ,p.[Capacity]
                      
                  FROM [WAREHOUSEISDB].[dbo].[Product] p
                  LEFT JOIN Category c
                  ON c.CategoryID  = p.CategoryID";

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
        public static void LoadLocationList(GridControl gcLocationList)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                  SELECT
                        l.LocationID, 
                        l.ProductID,
                        l.Availability
                        FROM Location l";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    gcLocationList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading location: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LoadStockList(GridControl gcStock)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                                 SELECT 
                                s.[StockID],
                                s.[ProductID],
                                p.[ProductName],               
                                s.Quantity,
                                ls.[LocationID],
                                s.[Supplier],
                                FORMAT(s.[ExpirationDate], 'MMMM dd, yyyy') AS [ExpirationDate],
                                FORMAT(s.[ProductRecieved], 'MMMM dd, yyyy hh:mm tt') AS [ProductReceived],
                                CASE 
                                    WHEN ISNULL(l.Capacity, 0) = 0 THEN 'No Stock'
                                    ELSE CAST(ISNULL(l.Capacity, 0) AS VARCHAR(50)) + '/' + CAST(ISNULL(p.Capacity, 0) AS VARCHAR(50))
                                END AS 'LocationCapacity'
                            FROM 
                                [WAREHOUSEISDB].[dbo].[Stock] s
                            LEFT JOIN 
                                Product p ON p.ProductID = s.ProductID
                            LEFT JOIN 
                                LocationStock ls ON ls.StockID = s.StockID
                            LEFT JOIN
                                Location l ON l.LocationID = ls.LocationID
                            WHERE 
                                s.Quantity > 0
                            ORDER BY 
                                LEFT(ls.LocationID, CHARINDEX('-', ls.LocationID) - 1),
                                CAST(SUBSTRING(ls.LocationID, CHARINDEX('-', ls.LocationID) + 1, CHARINDEX('-', ls.LocationID, CHARINDEX('-', ls.LocationID) + 1) - CHARINDEX('-', ls.LocationID) - 1) AS INT),
                                CAST(SUBSTRING(ls.LocationID, CHARINDEX('-', ls.LocationID, CHARINDEX('-', ls.LocationID) + 1) + 1, LEN(ls.LocationID)) AS INT); ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }

                    gcStock.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
