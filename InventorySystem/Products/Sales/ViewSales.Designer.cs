﻿namespace InventorySystem.Products.Sales
{
    partial class ViewSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSales));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcSales = new DevExpress.XtraGrid.GridControl();
            this.gvSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RowCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantitySold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnGenerateReport = new DevExpress.XtraEditors.SimpleButton();
            this.cbSelectTimeReport = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSelectTimeReport.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 44, 45, 44);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 495;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1139, 73);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // gcSales
            // 
            this.gcSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSales.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            gridLevelNode1.RelationName = "Level1";
            this.gcSales.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSales.Location = new System.Drawing.Point(144, 234);
            this.gcSales.MainView = this.gvSales;
            this.gcSales.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.gcSales.MenuManager = this.ribbon;
            this.gcSales.Name = "gcSales";
            this.gcSales.Size = new System.Drawing.Size(904, 376);
            this.gcSales.TabIndex = 38;
            this.gcSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSales});
            // 
            // gvSales
            // 
            this.gvSales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RowCount,
            this.SaleID,
            this.ProductName,
            this.QuantitySold,
            this.Price,
            this.OrderDate});
            this.gvSales.DetailHeight = 417;
            this.gvSales.FixedLineWidth = 3;
            this.gvSales.GridControl = this.gcSales;
            this.gvSales.Name = "gvSales";
            this.gvSales.OptionsEditForm.PopupEditFormWidth = 1029;
            this.gvSales.OptionsView.ShowGroupPanel = false;
            // 
            // RowCount
            // 
            this.RowCount.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.RowCount.AppearanceCell.Options.UseFont = true;
            this.RowCount.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.RowCount.AppearanceHeader.Options.UseFont = true;
            this.RowCount.Caption = "#";
            this.RowCount.FieldName = "Count";
            this.RowCount.MinWidth = 30;
            this.RowCount.Name = "RowCount";
            this.RowCount.OptionsColumn.AllowEdit = false;
            this.RowCount.Visible = true;
            this.RowCount.VisibleIndex = 0;
            this.RowCount.Width = 444;
            // 
            // SaleID
            // 
            this.SaleID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.SaleID.AppearanceCell.Options.UseFont = true;
            this.SaleID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.SaleID.AppearanceHeader.Options.UseFont = true;
            this.SaleID.Caption = "Sale ID";
            this.SaleID.FieldName = "SaleID";
            this.SaleID.MinWidth = 30;
            this.SaleID.Name = "SaleID";
            this.SaleID.OptionsColumn.AllowEdit = false;
            this.SaleID.Width = 238;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.Caption = "Sold Products";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 31;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 890;
            // 
            // QuantitySold
            // 
            this.QuantitySold.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.QuantitySold.AppearanceCell.Options.UseFont = true;
            this.QuantitySold.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.QuantitySold.AppearanceHeader.Options.UseFont = true;
            this.QuantitySold.Caption = "Total Quantity Sold";
            this.QuantitySold.FieldName = "QuantitySold";
            this.QuantitySold.MinWidth = 31;
            this.QuantitySold.Name = "QuantitySold";
            this.QuantitySold.Visible = true;
            this.QuantitySold.VisibleIndex = 2;
            this.QuantitySold.Width = 719;
            // 
            // Price
            // 
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.Caption = "Total Revenue";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 30;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 3;
            this.Price.Width = 386;
            // 
            // OrderDate
            // 
            this.OrderDate.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.OrderDate.AppearanceCell.Options.UseFont = true;
            this.OrderDate.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.OrderDate.AppearanceHeader.Options.UseFont = true;
            this.OrderDate.Caption = "Order Date";
            this.OrderDate.FieldName = "OrderDate";
            this.OrderDate.MinWidth = 32;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Visible = true;
            this.OrderDate.VisibleIndex = 4;
            this.OrderDate.Width = 275;
            // 
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerateReport.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnGenerateReport.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateReport.Appearance.Options.UseBackColor = true;
            this.BtnGenerateReport.Appearance.Options.UseFont = true;
            this.BtnGenerateReport.Location = new System.Drawing.Point(676, 106);
            this.BtnGenerateReport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Size = new System.Drawing.Size(307, 45);
            this.BtnGenerateReport.TabIndex = 66;
            this.BtnGenerateReport.Text = "GENERATE REPORT";
            this.BtnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // cbSelectTimeReport
            // 
            this.cbSelectTimeReport.EditValue = "Select Time Report";
            this.cbSelectTimeReport.Location = new System.Drawing.Point(144, 170);
            this.cbSelectTimeReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSelectTimeReport.MenuManager = this.ribbon;
            this.cbSelectTimeReport.Name = "cbSelectTimeReport";
            this.cbSelectTimeReport.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbSelectTimeReport.Properties.Appearance.Options.UseFont = true;
            this.cbSelectTimeReport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSelectTimeReport.Properties.Items.AddRange(new object[] {
            "Daily ",
            "Weekly ",
            "Monthly",
            "Yearly",
            "All"});
            this.cbSelectTimeReport.Size = new System.Drawing.Size(465, 48);
            this.cbSelectTimeReport.TabIndex = 68;
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 657);
            this.Controls.Add(this.cbSelectTimeReport);
            this.Controls.Add(this.BtnGenerateReport);
            this.Controls.Add(this.gcSales);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ViewSales.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ViewSales";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.Text = "View Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSelectTimeReport.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gcSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSales;
        private DevExpress.XtraGrid.Columns.GridColumn RowCount;
        private DevExpress.XtraGrid.Columns.GridColumn SaleID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn QuantitySold;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraEditors.SimpleButton BtnGenerateReport;
        private DevExpress.XtraEditors.ComboBoxEdit cbSelectTimeReport;
        private DevExpress.XtraGrid.Columns.GridColumn OrderDate;
    }
}