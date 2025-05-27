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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderSale));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.gvOrderList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaidAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ViewEmployeeDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ViewEmployeeDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 257;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1509, 61);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 843);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1509, 45);
            // 
            // gcSales
            // 
            this.gcSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            gridLevelNode1.RelationName = "Level1";
            this.gcSales.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSales.Location = new System.Drawing.Point(1066, 109);
            this.gcSales.MainView = this.gvSales;
            this.gcSales.MenuManager = this.ribbon;
            this.gcSales.Name = "gcSales";
            this.gcSales.Size = new System.Drawing.Size(404, 653);
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
            this.gvSales.DetailHeight = 351;
            this.gvSales.FixedLineWidth = 3;
            this.gvSales.GridControl = this.gcSales;
            this.gvSales.Name = "gvSales";
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
            this.RowCount.MinWidth = 23;
            this.RowCount.Name = "RowCount";
            this.RowCount.OptionsColumn.AllowEdit = false;
            this.RowCount.Visible = true;
            this.RowCount.VisibleIndex = 0;
            this.RowCount.Width = 254;
            // 
            // SaleID
            // 
            this.SaleID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.SaleID.AppearanceCell.Options.UseFont = true;
            this.SaleID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.SaleID.AppearanceHeader.Options.UseFont = true;
            this.SaleID.Caption = "Sale ID";
            this.SaleID.FieldName = "SaleID";
            this.SaleID.MinWidth = 23;
            this.SaleID.Name = "SaleID";
            this.SaleID.OptionsColumn.AllowEdit = false;
            this.SaleID.Visible = true;
            this.SaleID.VisibleIndex = 1;
            this.SaleID.Width = 185;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.Caption = "Ordered Products";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 24;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 2;
            this.ProductName.Width = 509;
            // 
            // QuantitySold
            // 
            this.QuantitySold.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.QuantitySold.AppearanceCell.Options.UseFont = true;
            this.QuantitySold.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.QuantitySold.AppearanceHeader.Options.UseFont = true;
            this.QuantitySold.Caption = "Quantity";
            this.QuantitySold.FieldName = "QuantitySold";
            this.QuantitySold.MinWidth = 24;
            this.QuantitySold.Name = "QuantitySold";
            this.QuantitySold.Visible = true;
            this.QuantitySold.VisibleIndex = 3;
            this.QuantitySold.Width = 411;
            // 
            // Price
            // 
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 23;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 283;
            // 
            // gcOrders
            // 
            this.gcOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcOrders.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcOrders.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrders.Location = new System.Drawing.Point(42, 109);
            this.gcOrders.MainView = this.gvOrderList;
            this.gcOrders.Margin = new System.Windows.Forms.Padding(4);
            this.gcOrders.Name = "gcOrders";
            this.gcOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ViewEmployeeDetails});
            this.gcOrders.Size = new System.Drawing.Size(993, 653);
            this.gcOrders.TabIndex = 39;
            this.gcOrders.UseEmbeddedNavigator = true;
            this.gcOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderList});
            // 
            // gvOrderList
            // 
            this.gvOrderList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderCount,
            this.OrderID,
            this.TotalAmount,
            this.PaidAmount,
            this.ViewEmployeeDetail});
            this.gvOrderList.DetailHeight = 431;
            this.gvOrderList.GridControl = this.gcOrders;
            this.gvOrderList.Name = "gvOrderList";
            this.gvOrderList.OptionsEditForm.PopupEditFormWidth = 933;
            this.gvOrderList.OptionsView.ShowGroupPanel = false;
            this.gvOrderList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvOrderList_FocusedRowChanged);
            // 
            // OrderCount
            // 
            this.OrderCount.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.OrderCount.AppearanceCell.Options.UseFont = true;
            this.OrderCount.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.OrderCount.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.OrderCount.AppearanceHeader.Options.UseFont = true;
            this.OrderCount.AppearanceHeader.Options.UseForeColor = true;
            this.OrderCount.AppearanceHeader.Options.UseTextOptions = true;
            this.OrderCount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OrderCount.Caption = "#";
            this.OrderCount.FieldName = "Count";
            this.OrderCount.MinWidth = 23;
            this.OrderCount.Name = "OrderCount";
            this.OrderCount.Visible = true;
            this.OrderCount.VisibleIndex = 0;
            this.OrderCount.Width = 323;
            // 
            // OrderID
            // 
            this.OrderID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.OrderID.AppearanceCell.Options.UseFont = true;
            this.OrderID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.OrderID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.OrderID.AppearanceHeader.Options.UseFont = true;
            this.OrderID.AppearanceHeader.Options.UseForeColor = true;
            this.OrderID.AppearanceHeader.Options.UseTextOptions = true;
            this.OrderID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.OrderID.Caption = "Order ID";
            this.OrderID.FieldName = "OrderID";
            this.OrderID.MinWidth = 23;
            this.OrderID.Name = "OrderID";
            this.OrderID.Visible = true;
            this.OrderID.VisibleIndex = 1;
            this.OrderID.Width = 347;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TotalAmount.AppearanceCell.Options.UseFont = true;
            this.TotalAmount.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.TotalAmount.AppearanceHeader.Options.UseFont = true;
            this.TotalAmount.Caption = "Total Amount";
            this.TotalAmount.FieldName = "TotalPrice";
            this.TotalAmount.MinWidth = 25;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Visible = true;
            this.TotalAmount.VisibleIndex = 2;
            this.TotalAmount.Width = 302;
            // 
            // PaidAmount
            // 
            this.PaidAmount.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.PaidAmount.AppearanceCell.Options.UseFont = true;
            this.PaidAmount.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.PaidAmount.AppearanceHeader.Options.UseFont = true;
            this.PaidAmount.Caption = "Payment Amount";
            this.PaidAmount.FieldName = "PaymentAmount";
            this.PaidAmount.MinWidth = 25;
            this.PaidAmount.Name = "PaidAmount";
            this.PaidAmount.Visible = true;
            this.PaidAmount.VisibleIndex = 3;
            this.PaidAmount.Width = 294;
            // 
            // ViewEmployeeDetail
            // 
            this.ViewEmployeeDetail.AccessibleDescription = "bu";
            this.ViewEmployeeDetail.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ViewEmployeeDetail.AppearanceCell.Options.UseFont = true;
            this.ViewEmployeeDetail.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ViewEmployeeDetail.AppearanceHeader.Options.UseFont = true;
            this.ViewEmployeeDetail.Caption = "Export";
            this.ViewEmployeeDetail.ColumnEdit = this.ViewEmployeeDetails;
            this.ViewEmployeeDetail.MinWidth = 25;
            this.ViewEmployeeDetail.Name = "ViewEmployeeDetail";
            this.ViewEmployeeDetail.Visible = true;
            this.ViewEmployeeDetail.VisibleIndex = 4;
            this.ViewEmployeeDetail.Width = 286;
            // 
            // ViewEmployeeDetails
            // 
            this.ViewEmployeeDetails.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.ViewEmployeeDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.ViewEmployeeDetails.Name = "ViewEmployeeDetails";
            this.ViewEmployeeDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ViewEmployeeDetails.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ViewEmployeeDetails_ButtonClick);
            // 
            // ViewOrderSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 888);
            this.Controls.Add(this.gcOrders);
            this.Controls.Add(this.gcSales);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewEmployeeDetails)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn SaleID;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.GridControl gcOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrderList;
        private DevExpress.XtraGrid.Columns.GridColumn OrderCount;
        private DevExpress.XtraGrid.Columns.GridColumn OrderID;
        private DevExpress.XtraGrid.Columns.GridColumn ViewEmployeeDetail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ViewEmployeeDetails;
        private DevExpress.XtraGrid.Columns.GridColumn TotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn PaidAmount;
    }
}