using DevExpress.Utils;
using InventorySystem.Infrastracture.SQL;
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

        public void UpdateLocation(int locationId, string start, string finish, int availability)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = ProductSQL.UpdateLocationQuery;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Start", start);
                    command.Parameters.AddWithValue("@Finish", finish);
                    command.Parameters.AddWithValue("@Availability", availability);
                    command.Parameters.AddWithValue("@LocationID", locationId);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
