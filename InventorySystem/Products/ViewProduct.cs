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
using InventorySystem.Employees;
using System.IO;
using InventorySystem.Products;

namespace InventorySystem.views
{
    public partial class ViewProduct : DevExpress.XtraEditors.XtraForm
    {
  
        public ViewProduct()
        {
            InitializeComponent();
           
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            
            GlobalMethod.LoadProductList(gcProductList);
        }

        private void txtSearch_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gvProductList.ApplyFindFilter(e.NewValue as string);
        }


       
       
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (gvProductList.FocusedRowHandle < 0)
            {
                MessageBox.Show("Please select a product to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected ProductID
            string productID = Convert.ToString(gvProductList.GetFocusedRowCellValue("ProductID"));
            string productName = Convert.ToString(gvProductList.GetFocusedRowCellValue("ProductName"));
            decimal price = Convert.ToDecimal(gvProductList.GetFocusedRowCellValue("Price"));
            int capacity = Convert.ToInt32(gvProductList.GetFocusedRowCellValue("Capacity"));

            // Instantiate the update form
            var updateForm = new UpdateProduct(productID, this);

            // Populate form fields
            updateForm.teProductID.Text = productID;
            updateForm.teProductName.Text = productName;
            updateForm.lueCategory.EditValue = gvProductList.GetFocusedRowCellValue("CategoryID");
            updateForm.tePrice.Text = price.ToString();
            updateForm.teCapacity.Text = capacity.ToString();

            // Show the form
            DialogResult result = updateForm.ShowDialog();

            // Optionally refresh data after successful update
            if (result == DialogResult.OK)
            {
                GlobalMethod.LoadProductList(gcProductList); // Replace with your actual method to reload products
            }
        }



        private void DeleteProducte(string productID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
                {
                    string query = "DELETE FROM Product WHERE ProductID = @ProductID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching employee found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}