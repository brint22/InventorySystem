using DevExpress.XtraBars;
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

namespace InventorySystem.Categories
{
    public partial class AddCategory : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void InsertCategory(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                string sql = "INSERT INTO Category (CategoryName) VALUES (@CategoryName)";
                connection.Execute(sql, new { CategoryName = categoryName });
            }
        }

        private bool CategoryExists(string categoryName)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                string sql = "SELECT COUNT(1) FROM Category WHERE CategoryName = @CategoryName";
                int count = connection.ExecuteScalar<int>(sql, new { CategoryName = categoryName });
                return count > 0;
            }
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string categoryName = teCategoryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CategoryExists(categoryName))
            {
                MessageBox.Show("This category already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to add this category?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                InsertCategory(categoryName);
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                teCategoryName.Text = "";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}