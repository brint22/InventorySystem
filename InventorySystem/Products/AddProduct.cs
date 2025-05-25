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
            // ✅ Validate required fields
            if (string.IsNullOrWhiteSpace(teProductName.Text) ||
                string.IsNullOrWhiteSpace(sePrice.Text))
            {
                MessageBox.Show("Please fill in all required fields (Product Name and Brand Name).",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // ✅ Confirm submission
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

            // ✅ Create product object
            Product product = new Product()
            {
                CategoryID = GetCategoryID(), // ✅ Use the actual selected ProductID
                ProductName = teProductName.Text.Trim(),
                Price = sePrice.Value,
                Capacity = int.Parse(teCapacity.Text)
        };

            // ✅ Save to database
            ProductRepository repo = new ProductRepository(GlobalClass.connectionString);
            repo.RegisterProduct(product);

            MessageBox.Show("Product registered successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            ResetAllFields();
        }
    

      

        //private void cbLocationGroup_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //           string selectedGroup = cbLocationGroup.SelectedItem?.ToString();
        //    if (!string.IsNullOrEmpty(selectedGroup))
        //    {
        //        // Now passing both the ComboBoxEdit control and the selectedGroup
        //        ProductRepository.LoadLocation(cbLocation, selectedGroup);
        //    }
        //}

        private int GetCategoryID()
        {
            if (lueCategory.EditValue != null && int.TryParse(lueCategory.EditValue.ToString(), out int categoryID))
            {
                return categoryID;
            }

            return 0; // Or return -1 or throw an exception if 0 is a valid category ID
        }

       private void ResetAllFields()
        {
            teProductName.Clear();
            sePrice.Clear();
            lueCategory.Clear();
            teCapacity.Clear();
        }
    }

}