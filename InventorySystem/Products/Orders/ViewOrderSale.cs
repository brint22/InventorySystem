using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using InventorySystem.Models;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using InventorySystem.Reports;
using DevExpress.XtraReports.UI;

namespace InventorySystem.Orders
{
    public partial class ViewOrderSale : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ViewOrderSale()
        {
            InitializeComponent();
        }

        public List<Order> LoadOrders()
        {
            IEnumerable<Order> order;

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                string query = @"SELECT  
                                       ROW_NUMBER() OVER (ORDER BY OrderID) AS Count
                                      ,[OrderID]
                                      ,[OrderDate]
                                      ,[TotalPrice]
                                      ,[PaymentAmount]
                               FROM [WAREHOUSEISDB].[dbo].[Orders];";
                order = connection.Query<Order>(query, commandType: CommandType.Text);
            }

            return order.ToList();
        }

        public List<Sale> LoadSalesByOrderId(string orderId)
        {
            IEnumerable<Sale> sales;

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                            ROW_NUMBER() OVER (ORDER BY SaleID) AS Count,
                            s.OrderID,
                            s.SaleID,
                            p.ProductName,
                            s.QuantitySold,
                            s.Price,
                            o.OrderDate
                         FROM [WAREHOUSEISDB].[dbo].[Sales] s
                         LEFT JOIN Product p ON s.ProductID = p.ProductID
                         LEFT JOIN Orders o ON s.OrderID = o.OrderID
                         WHERE s.OrderID = @OrderID;";

                sales = connection.Query<Sale>(query, new { OrderID = orderId }, commandType: CommandType.Text);
            }

            return sales.ToList();
        }

        private void ViewOrderSale_Load(object sender, EventArgs e)
        {
            gcOrders.DataSource = LoadOrders();
            
        }

        private void gvOrders_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var view = sender as GridView;
            if (view == null) return;

            var selectedOrder = view.GetRow(e.FocusedRowHandle) as Order;
            if (selectedOrder == null) return;

            var orderId = selectedOrder.OrderID;

            // Load sales for the selected order
            gcSales.DataSource = LoadSalesByOrderId(orderId);
            gcSales.RefreshDataSource();
        }

        private void ViewEmployeeDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            object orderIdObj = gvOrderList.GetFocusedRowCellValue("OrderID");

            if (orderIdObj == null)
            {
                XtraMessageBox.Show("Please select a valid Order ID.");
                return;
            }

            var selectedOrderId = Convert.ToString(orderIdObj);
            List<Sale> salesData = LoadSalesByOrderId(selectedOrderId);

            if (salesData.Any())
            {
                OrderReport report = new OrderReport();
                report.DataSource = salesData;

                report.ShowPreview();
            }
            else
            {
                XtraMessageBox.Show("No sales data found for the selected order.");
            }
        }

        private void gvOrderList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var view = sender as GridView;
            if (view == null) return;

            var selectedOrder = view.GetRow(e.FocusedRowHandle) as Order;
            if (selectedOrder == null) return;

            var orderId = selectedOrder.OrderID;

            // Load sales for the selected order
            gcSales.DataSource = LoadSalesByOrderId(orderId);
            gcSales.RefreshDataSource();
        }
    }
}