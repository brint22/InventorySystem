﻿using DevExpress.XtraBars;
using InventorySystem.Models;
using InventorySystem.Account;
using InventorySystem.Categories;
using InventorySystem.Employees;
using InventorySystem.Products;
using InventorySystem.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Locations;
using InventorySystem.Products.Stock;
using InventorySystem.Orders;
using InventorySystem.Products.Sales;

namespace InventorySystem.Views
{
    public partial class bbi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bbi()
        {
            InitializeComponent();
        }
        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void bbiTileView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            ViewEmployee employee = new ViewEmployee(GlobalClass.connectionString);
            this.IsMdiContainer = true;
            employee.MdiParent = this;
            // Show the Employee form

            employee.Show();
        }

        private void bbiListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            new GridViewEmployee().Show();
            // Create a new instance of Employee form
            //GridViewEmployee employee = new GridViewEmployee();
            //this.IsMdiContainer = true;
            //employee.MdiParent = this;
            // Show the Employee form
            //employee.Show();
        }


        private void addAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            CreateAccount product = new CreateAccount();
            this.IsMdiContainer = true;
            product.MdiParent = this;

            // Show the Employee form
            product.Show();
        }

        private void bbiAddCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            AddCategory category = new AddCategory();
            this.IsMdiContainer = true;
            category.MdiParent = this;

            // Show the Employee form
            category.Show();
        }

        private void bbiViewCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            ViewCategory category = new ViewCategory();
            this.IsMdiContainer = true;
            category.MdiParent = this;

            // Show the Employee form
            category.Show();
        }

        private void bbiAddLocation_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            AddLocation location = new AddLocation();
            this.IsMdiContainer = true;
            location.MdiParent = this;

            // Show the Employee form
            location.Show();
        }

        private void bbiViewLocation_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Location form
            new ViewLocation().Show();
        }

        private void bbiAddEmployee_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            AddEmployee employee = new AddEmployee();
            this.IsMdiContainer = true;
            employee.MdiParent = this;


            // Show the Employee form
            employee.Show();
        }

        private void bbiAddProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            AddProduct product = new AddProduct();
            this.IsMdiContainer = true;
            product.MdiParent = this;

            // Show the Employee form
            product.Show();
        }

        private void bbiViewProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click 6another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            new ViewProduct().Show();
        }

        private void viewAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            ViewAccount account = new ViewAccount();
            this.IsMdiContainer = true;
            account.MdiParent = this;
            // Show the Employee form

            account.Show();
        }

        private void AddStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            AddStock stock = new AddStock();
            this.IsMdiContainer = true;
            stock.MdiParent = this;

            // Show the Employee form
            stock.Show();
        }

        private void ViewStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click 6another form
            CloseAllChildForms();
            // Create a new instance of Stock form
            new ViewStock().Show();
        }

        private void bbiAddOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click 6another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            new AddOrder().Show();
        }

        private void ViewOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Close the current Form when click 6another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            new ViewOrderSale().Show();
        }

        private void bbiViewSales_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseAllChildForms();

            //Close the current Form when click 6another form
            CloseAllChildForms();
            // Create a new instance of Employee form
            new ViewSales().Show();
        }
    }
}
