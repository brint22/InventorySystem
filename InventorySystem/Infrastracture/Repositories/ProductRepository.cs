using Dapper;
using DevExpress.Utils;
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
