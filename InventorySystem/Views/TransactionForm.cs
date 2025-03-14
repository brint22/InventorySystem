using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

namespace InventorySystem.Views
{
    public partial class TransactionForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string connectionString = @"Data Source=LAB1-PC11;Initial Catalog=InventoryDB;User ID=sa;Password=123456;";

        public TransactionForm()
        {
            InitializeComponent();

            LoadProductsToComboBox();
            gcProducts.DataSource = CreateProductTable();
        }



        //
        //for data table
        //

        DataTable dtProduct = new DataTable();
        
        //dt for products table
        private DataTable CreateProductTable()
        {
            dtProduct.Columns.Add("ProductName", typeof(string));
            dtProduct.Columns.Add("Price", typeof(string));
            dtProduct.Columns.Add("Quantity", typeof(string));
            return dtProduct;
        }



        //
        //for loading data from db to cbe
        //

        //loading products from db to cbe
        private void LoadProductsToComboBox()
        {
            string query = "SELECT ProductName From Products;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        cbeEnterProduct.Properties.Items.Clear(); // Clear previous data
                        while (reader.Read())
                        {
                            cbeEnterProduct.Properties.Items.Add(reader["ProductName"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //
        //for btn
        //

        //for adding input to products table
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string productName = cbeEnterProduct.Text.Trim();
            string price = cbeEnterProduct.Text.Trim();
            string quantity = cbeEnterProduct.Text.Trim();

            DataRow newRow = dtProduct.NewRow();
            newRow["ProductName"] = productName;
            newRow["Price"] = price;
            newRow["Quantity"] = quantity;
            dtProduct.Rows.Add(newRow);

            gcProducts.DataSource = dtProduct;
            gvProducts.RefreshData();
        }

        //for removing inputs from products table
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvProducts.FocusedRowHandle;

            if (focusedRowHandle >= 0)
            {
                DataRow rowToDelete = gvProducts.GetDataRow(focusedRowHandle);
                if (rowToDelete != null)
                {
                    dtProduct.Rows.Remove(rowToDelete);

                    gcProducts.DataSource = dtProduct;
                    gvProducts.RefreshData();
                }
            }
            else
            {
                XtraMessageBox.Show("Please try again. Select a row before pressing the button.");
            }
        }
    }
}