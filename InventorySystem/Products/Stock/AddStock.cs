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
                ProductRepository.LoadLocation(cbLocation, selectedGroup);
            }
        }

        private void cbLocationGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = cbLocationGroup.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedGroup))
            {
                // Now passing both the ComboBoxEdit control and the selectedGroup
                ProductRepository.LoadLocation(cbLocation, selectedGroup);
            }
        }
    }
}