using Dapper;
using DevExpress.Office.Services;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using InventorySystem.Infrastracture.Repositories;
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

namespace InventorySystem.Products
{
    public partial class AddProduct : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            ProductRepository.LoadCategory(lueCategory);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teProductName.Text) ||
       string.IsNullOrWhiteSpace(teBrandName.Text) ||

       string.IsNullOrWhiteSpace(teSupplier.Text))
            {
                MessageBox.Show("Please fill in all required fields (Product Name, Brand Name, and Supplier).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tePrice.Text, out int price))
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(teQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (deExpirationDate.DateTime <= DateTime.Now)
            {
                MessageBox.Show("Expiration date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to add this product?",
                "Confirm Product Registration",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            Product product = new Product()
            {
                ProductName = teProductName.Text.Trim(),
                Price = price,
                Quantity = quantity,
                ProductRecieved = DateTime.Now,
                ExpirationDate = deExpirationDate.DateTime,
                BrandName = teBrandName.Text.Trim(),
                Supplier = teSupplier.Text.Trim()
            };

            string selectedLocation = cbLocation.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedLocation))
            {
                MessageBox.Show("Please select a location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Call the method from the repository
            ProductRepository repo = new ProductRepository(GlobalClass.connectionString);
            repo.RegisterProduct(product, selectedLocation);
        }

        private void tePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits and control keys (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void teQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block any non-digit characters
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