﻿using DevExpress.XtraBars;
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
                                      ,[TotalPrice]
                                      ,[PaymentAmount]
                               FROM [WAREHOUSEISDB].[dbo].[Orders];";
                order = connection.Query<Order>(query, commandType: CommandType.Text);
            }

            return order.ToList();
        }

        public List<Sale> LoadSalesByOrderId(int orderId)
        {
            IEnumerable<Sale> sales;

            using (SqlConnection connection = new SqlConnection(GlobalClass.connectionString))
            {
                connection.Open();

                string query = @"SELECT 
                            ROW_NUMBER() OVER (ORDER BY SaleID) AS Count,
                            s.SaleID,
                            p.ProductName,
                            s.QuantitySold,
                            s.Price
                         FROM [WAREHOUSEISDB].[dbo].[Sales] s
                         LEFT JOIN Product p ON s.ProductID = p.ProductID
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

            int orderId = selectedOrder.OrderID;

            // Load sales for the selected order
            gcSales.DataSource = LoadSalesByOrderId(orderId);
            gcSales.RefreshDataSource();
        }
    }
}