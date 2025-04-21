using InventorySystem.Infrastracture.SQL;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Infrastracture.Repositories
{
    public class EmployeeRepository
    {
        private readonly string _connectionString;

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetEmployeeList(string roleFilter)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();
                string query = EmployeeSQL.GetListOfEmployees;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoleFilter", roleFilter);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (row["ImageData"] == DBNull.Value)
                            {
                                row["ImageData"] = new byte[0];
                            }
                        }

                        return dataTable;
                    }
                }
            }
        }

    }
}
