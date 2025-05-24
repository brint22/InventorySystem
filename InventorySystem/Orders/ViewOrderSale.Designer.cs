namespace InventorySystem.Orders
{
    partial class ViewOrderSale
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcSales = new DevExpress.XtraGrid.GridControl();
            this.gvSales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RowCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.QuantitySold = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcOrders = new DevExpress.XtraGrid.GridControl();
            this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaymentAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1940, 73);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 999);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1940, 55);
            // 
            // gcSales
            // 
            this.gcSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcSales.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.gcSales.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSales.Location = new System.Drawing.Point(729, 130);
            this.gcSales.MainView = this.gvSales;
            this.gcSales.Margin = new System.Windows.Forms.Padding(4);
            this.gcSales.MenuManager = this.ribbon;
            this.gcSales.Name = "gcSales";
            this.gcSales.Size = new System.Drawing.Size(1161, 776);
            this.gcSales.TabIndex = 36;
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
            this.Price});
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
            this.RowCount.Width = 326;
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
            this.SaleID.Visible = true;
            this.SaleID.VisibleIndex = 1;
            this.SaleID.Width = 238;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.Caption = "Ordered Products";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 31;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 2;
            this.ProductName.Width = 654;
            // 
            // QuantitySold
            // 
            this.QuantitySold.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.QuantitySold.AppearanceCell.Options.UseFont = true;
            this.QuantitySold.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.QuantitySold.AppearanceHeader.Options.UseFont = true;
            this.QuantitySold.Caption = "Quantity";
            this.QuantitySold.FieldName = "QuantitySold";
            this.QuantitySold.MinWidth = 31;
            this.QuantitySold.Name = "QuantitySold";
            this.QuantitySold.Visible = true;
            this.QuantitySold.VisibleIndex = 3;
            this.QuantitySold.Width = 528;
            // 
            // Price
            // 
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 30;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 364;
            // 
            // gcOrders
            // 
            this.gcOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcOrders.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrders.Location = new System.Drawing.Point(46, 130);
            this.gcOrders.MainView = this.gvOrders;
            this.gcOrders.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrders.MenuManager = this.ribbon;
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.Size = new System.Drawing.Size(629, 776);
            this.gcOrders.TabIndex = 35;
            this.gcOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrders});
            // 
            // gvOrders
            // 
            this.gvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Count,
            this.OrderID,
            this.TotalPrice,
            this.PaymentAmount});
            this.gvOrders.DetailHeight = 417;
            this.gvOrders.GridControl = this.gcOrders;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.OptionsEditForm.PopupEditFormWidth = 1029;
            this.gvOrders.OptionsView.ShowGroupPanel = false;
            this.gvOrders.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvOrders_FocusedRowChanged);
            // 
            // Count
            // 
            this.Count.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Count.AppearanceCell.Options.UseFont = true;
            this.Count.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Count.AppearanceHeader.Options.UseFont = true;
            this.Count.Caption = "#";
            this.Count.FieldName = "Count";
            this.Count.MinWidth = 30;
            this.Count.Name = "Count";
            this.Count.OptionsColumn.AllowEdit = false;
            this.Count.Visible = true;
            this.Count.VisibleIndex = 0;
            this.Count.Width = 112;
            // 
            // OrderID
            // 
            this.OrderID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.OrderID.AppearanceCell.Options.UseFont = true;
            this.OrderID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.OrderID.AppearanceHeader.Options.UseFont = true;
            this.OrderID.Caption = "Order ID";
            this.OrderID.FieldName = "OrderID";
            this.OrderID.MinWidth = 31;
            this.OrderID.Name = "OrderID";
            this.OrderID.OptionsColumn.AllowEdit = false;
            this.OrderID.Visible = true;
            this.OrderID.VisibleIndex = 1;
            this.OrderID.Width = 195;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TotalPrice.AppearanceCell.Options.UseFont = true;
            this.TotalPrice.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.TotalPrice.AppearanceHeader.Options.UseFont = true;
            this.TotalPrice.Caption = "Total Price";
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.MinWidth = 31;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.OptionsColumn.AllowEdit = false;
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 2;
            this.TotalPrice.Width = 321;
            // 
            // PaymentAmount
            // 
            this.PaymentAmount.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.PaymentAmount.AppearanceCell.Options.UseFont = true;
            this.PaymentAmount.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.PaymentAmount.AppearanceHeader.Options.UseFont = true;
            this.PaymentAmount.Caption = "Payment Amount";
            this.PaymentAmount.FieldName = "PaymentAmount";
            this.PaymentAmount.MinWidth = 31;
            this.PaymentAmount.Name = "PaymentAmount";
            this.PaymentAmount.OptionsColumn.AllowEdit = false;
            this.PaymentAmount.Visible = true;
            this.PaymentAmount.VisibleIndex = 3;
            this.PaymentAmount.Width = 192;
            // 
            // ViewOrderSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1054);
            this.Controls.Add(this.gcSales);
            this.Controls.Add(this.gcOrders);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "ViewOrderSale";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ViewOrderSale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewOrderSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gcSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSales;
        private DevExpress.XtraGrid.Columns.GridColumn RowCount;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn QuantitySold;
        private DevExpress.XtraGrid.GridControl gcOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrders;
        private DevExpress.XtraGrid.Columns.GridColumn Count;
        private DevExpress.XtraGrid.Columns.GridColumn OrderID;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn PaymentAmount;
        private DevExpress.XtraGrid.Columns.GridColumn SaleID;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
    }
}