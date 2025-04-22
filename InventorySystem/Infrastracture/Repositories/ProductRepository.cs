using Dapper;
using DevExpress.Utils;
using InventorySystem.Infrastracture.SQL;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Infrastracture.Repositories
{
    public class ProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
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

        //public void addlocation(Location location)
        //{
        //    using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
        //    {
        //        string sql = "INSERT INTO Location (LocationID, ProductID, Availability) VALUES (@LocationID, '', 'Availability')";
        //        connection.Execute(sql, location);
        //    }
        //}

    }
}
