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
                   e.DateOfBirth, e.Address, 
                   UPPER(LEFT(r.RoleName, 1)) + LOWER(SUBSTRING(r.RoleName, 2, LEN(r.RoleName))) AS RoleName, -- Sentence Case
                   ei.ImageData,
                   DATEDIFF(YEAR, DateOfBirth, CAST(GETDATE() AS DATE)) - 
                            CASE 
                                 WHEN MONTH(DateOfBirth) > MONTH(CAST(GETDATE() AS DATE)) 
                                   OR (MONTH(DateOfBirth) = MONTH(CAST(GETDATE() AS DATE)) 
                                   AND DAY(DateOfBirth) > DAY(CAST(GETDATE() AS DATE))) 
                                 THEN 1 ELSE 0 
                            END
                    FROM Employee e
                    LEFT JOIN EmployeeImage ei ON e.ImageID = ei.ImageID
                    LEFT JOIN Role r ON e.RoleID = r.RoleID
                    WHERE (@RoleFilter = 'All' OR r.RoleName = @RoleFilter)";

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

    }
}
