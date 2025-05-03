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
            LoadAllProduct();
            LoadLocationAndCapacity();
        }


        private void LoadAllProduct()
        {
            string connStr = GlobalClass.connectionString;
            string query = @"
                            SELECT [ProductName]
                            FROM [WAREHOUSEISDB].[dbo].[Product]";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    var productNames = connection.Query<string>(query).ToList();

                    cbProductName.Properties.Items.Clear();
                    cbProductName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

                    if (productNames.Any())
                    {
                        cbProductName.Properties.Items.AddRange(productNames);
                    }
                    else
                    {
                        XtraMessageBox.Show("No products found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string selectedGroup = cbLocationGroup.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedGroup))
            {
                // Now passing both the ComboBoxEdit control and the selectedGroup
                ProductRepository.LoadLocation(lueLocation, selectedGroup);
            }
        }

        private void cbLocationGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = cbLocationGroup.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedGroup))
            {
                // Now passing both the ComboBoxEdit control and the selectedGroup
                ProductRepository.LoadLocation(lueLocation, selectedGroup);
            }
        }

        private void LoadLocationAndCapacity()
        {
            string query = @"
                    SELECT [LocationID], 
                           CAST(ISNULL(Capacity, 0) AS VARCHAR(20)) + '/100' AS Capacity
                    FROM [Location]
                    WHERE ISNULL(Capacity, 0) < 100
                    ORDER BY 
                            LEFT(LocationID, CHARINDEX('-', LocationID) - 1),
                            CAST(SUBSTRING(LocationID, CHARINDEX('-', LocationID) + 1, CHARINDEX('-', LocationID, CHARINDEX('-', LocationID) + 1) - CHARINDEX('-', LocationID) - 1) AS INT),
                            CAST(SUBSTRING(LocationID, CHARINDEX('-', LocationID, CHARINDEX('-', LocationID) + 1) + 1, LEN(LocationID)) AS INT);";

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();
                    var departments = connection.Query<Location>(query).ToList();

                    if (departments.Any())
                    {
                        lueLocation.Properties.DataSource = departments;
                        lueLocation.Properties.DisplayMember = "LocationID";
                        lueLocation.Properties.ValueMember = "LocationID";
                    }
                    else
                    {
                        lueLocation.Properties.DataSource = null;
                        XtraMessageBox.Show("No departments found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}