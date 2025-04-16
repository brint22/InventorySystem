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

namespace InventorySystem.Category
{
    public partial class ViewCategory : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewCategory()
        {
            InitializeComponent();
        }

        private void ViewCategory_Load(object sender, EventArgs e)
        {
            GlobalMethod.LoadCategoryData(gcCategory);

            gvCategory.RowClick += (s, ev) =>
            {
                if (gvCategory.FocusedRowHandle >= 0)
                {
                    var categoryName = gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, "CategoryName")?.ToString();
                    teCategoryName.Text = categoryName;
                }
            };
        }

        private void UpdateCategory(int categoryId, string newCategoryName)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    // Check for duplicates
                    string checkQuery = "SELECT COUNT(*) FROM Category WHERE CategoryName = @CategoryName AND CategoryID != @CategoryID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@CategoryName", newCategoryName);
                        checkCmd.Parameters.AddWithValue("@CategoryID", categoryId);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("A category with this name already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Perform the update
                    string updateQuery = "UPDATE Category SET CategoryName = @CategoryName WHERE CategoryID = @CategoryID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@CategoryName", newCategoryName);
                        updateCmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalMethod.LoadCategoryData(gcCategory); // Refresh grid
                    teCategoryName.Text = ""; // Clear text field
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            if (gvCategory.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a category to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newCategoryName = teCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(newCategoryName))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to update this category?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int categoryId = Convert.ToInt32(gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, "CategoryID"));
                UpdateCategory(categoryId, newCategoryName);
            }
        }

        private void DeleteCategory(int categoryId)
        {
            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Category WHERE CategoryID = @CategoryID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GlobalMethod.LoadCategoryData(gcCategory); // Refresh the grid
                    teCategoryName.Text = ""; // Clear text field
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (gvCategory.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a category to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int categoryId = Convert.ToInt32(gvCategory.GetRowCellValue(gvCategory.FocusedRowHandle, "CategoryID"));
                DeleteCategory(categoryId);
            }
        }
    }
}