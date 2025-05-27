namespace InventorySystem.Orders
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.teProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RowCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderedProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcOrder = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.seTotalPrice = new DevExpress.XtraEditors.SpinEdit();
            this.seAddAmount = new DevExpress.XtraEditors.SpinEdit();
            this.btnConfirmPayment = new DevExpress.XtraEditors.SimpleButton();
            this.seChange = new DevExpress.XtraEditors.SpinEdit();
            this.teProductID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAddAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(39, 37, 39, 37);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 424;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(2088, 73);
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
            // BtnSubmit
            // 
            this.BtnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseBackColor = true;
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(84, 1102);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(374, 45);
            this.BtnSubmit.TabIndex = 33;
            this.BtnSubmit.Text = "SUBMIT";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Location = new System.Drawing.Point(87, 867);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(318, 45);
            this.btnAdd.TabIndex = 79;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(87, 747);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 26);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Quantity";
            // 
            // seQuantity
            // 
            this.seQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.seQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seQuantity.Location = new System.Drawing.Point(87, 778);
            this.seQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seQuantity.MenuManager = this.ribbon;
            this.seQuantity.Name = "seQuantity";
            this.seQuantity.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.seQuantity.Properties.Appearance.Options.UseFont = true;
            this.seQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seQuantity.Size = new System.Drawing.Size(316, 46);
            this.seQuantity.TabIndex = 23;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(444, 867);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(302, 45);
            this.BtnCancel.TabIndex = 80;
            this.BtnCancel.Text = "CANCEL";
            // 
            // teProductName
            // 
            this.teProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teProductName.Location = new System.Drawing.Point(444, 678);
            this.teProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teProductName.MenuManager = this.ribbon;
            this.teProductName.Name = "teProductName";
            this.teProductName.Properties.AllowFocused = false;
            this.teProductName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.teProductName.Properties.Appearance.Options.UseFont = true;
            this.teProductName.Properties.ReadOnly = true;
            this.teProductName.Size = new System.Drawing.Size(302, 46);
            this.teProductName.TabIndex = 82;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(87, 99);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(163, 26);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Search Product:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(87, 129);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.AutoHeight = false;
            this.txtSearch.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtSearch.Size = new System.Drawing.Size(627, 45);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtSearch_EditValueChanging);
            // 
            // gvProducts
            // 
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Count,
            this.ProductID,
            this.ProductName,
            this.Capacity,
            this.Price});
            this.gvProducts.DetailHeight = 417;
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsEditForm.PopupEditFormWidth = 1029;
            this.gvProducts.OptionsView.ShowGroupPanel = false;
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
            // ProductID
            // 
            this.ProductID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ProductID.AppearanceCell.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.Caption = "Product ID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 31;
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 1;
            this.ProductID.Width = 195;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 31;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 2;
            this.ProductName.Width = 321;
            // 
            // Capacity
            // 
            this.Capacity.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Capacity.AppearanceCell.Options.UseFont = true;
            this.Capacity.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Capacity.AppearanceHeader.Options.UseFont = true;
            this.Capacity.Caption = "Stock";
            this.Capacity.FieldName = "Capacity";
            this.Capacity.MinWidth = 31;
            this.Capacity.Name = "Capacity";
            this.Capacity.OptionsColumn.AllowEdit = false;
            this.Capacity.Visible = true;
            this.Capacity.VisibleIndex = 3;
            this.Capacity.Width = 192;
            // 
            // Price
            // 
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 31;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 195;
            // 
            // gcProducts
            // 
            this.gcProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProducts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcProducts.Location = new System.Drawing.Point(87, 202);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcProducts.MenuManager = this.ribbon;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(858, 418);
            this.gcProducts.TabIndex = 2;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvOrder
            // 
            this.gvOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderProductID,
            this.RowCount,
            this.OrderedProduct,
            this.Quantity,
            this.TotalPrice});
            this.gvOrder.DetailHeight = 417;
            this.gvOrder.FixedLineWidth = 3;
            this.gvOrder.GridControl = this.gcOrder;
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.OptionsEditForm.PopupEditFormWidth = 1029;
            this.gvOrder.OptionsView.ShowGroupPanel = false;
            // 
            // OrderProductID
            // 
            this.OrderProductID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.OrderProductID.AppearanceCell.Options.UseFont = true;
            this.OrderProductID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.OrderProductID.AppearanceHeader.Options.UseFont = true;
            this.OrderProductID.Caption = "Product ID";
            this.OrderProductID.FieldName = "ProductID";
            this.OrderProductID.MinWidth = 32;
            this.OrderProductID.Name = "OrderProductID";
            this.OrderProductID.Visible = true;
            this.OrderProductID.VisibleIndex = 1;
            this.OrderProductID.Width = 327;
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
            this.RowCount.Width = 279;
            // 
            // OrderedProduct
            // 
            this.OrderedProduct.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.OrderedProduct.AppearanceCell.Options.UseFont = true;
            this.OrderedProduct.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.OrderedProduct.AppearanceHeader.Options.UseFont = true;
            this.OrderedProduct.Caption = "Ordered Products";
            this.OrderedProduct.FieldName = "ProductName";
            this.OrderedProduct.MinWidth = 31;
            this.OrderedProduct.Name = "OrderedProduct";
            this.OrderedProduct.Visible = true;
            this.OrderedProduct.VisibleIndex = 2;
            this.OrderedProduct.Width = 568;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Quantity.AppearanceCell.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 31;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 3;
            this.Quantity.Width = 445;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.TotalPrice.AppearanceCell.Options.UseFont = true;
            this.TotalPrice.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.TotalPrice.AppearanceHeader.Options.UseFont = true;
            this.TotalPrice.Caption = "Total Price";
            this.TotalPrice.FieldName = "Price";
            this.TotalPrice.MinWidth = 30;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 4;
            this.TotalPrice.Width = 377;
            // 
            // gcOrder
            // 
            this.gcOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOrder.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            gridLevelNode1.RelationName = "Level1";
            this.gcOrder.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcOrder.Location = new System.Drawing.Point(996, 202);
            this.gcOrder.MainView = this.gvOrder;
            this.gcOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcOrder.MenuManager = this.ribbon;
            this.gcOrder.Name = "gcOrder";
            this.gcOrder.Size = new System.Drawing.Size(999, 418);
            this.gcOrder.TabIndex = 34;
            this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrder});
            this.gcOrder.Click += new System.EventHandler(this.gcOrder_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(444, 647);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(145, 26);
            this.labelControl2.TabIndex = 83;
            this.labelControl2.Text = "Product Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(444, 747);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 26);
            this.labelControl4.TabIndex = 86;
            this.labelControl4.Text = "Price";
            // 
            // tePrice
            // 
            this.tePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tePrice.Location = new System.Drawing.Point(444, 778);
            this.tePrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tePrice.MenuManager = this.ribbon;
            this.tePrice.Name = "tePrice";
            this.tePrice.Properties.AllowFocused = false;
            this.tePrice.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tePrice.Properties.Appearance.Options.UseFont = true;
            this.tePrice.Properties.ReadOnly = true;
            this.tePrice.Size = new System.Drawing.Size(302, 46);
            this.tePrice.TabIndex = 85;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Appearance.Options.UseBackColor = true;
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Location = new System.Drawing.Point(1770, 140);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(225, 45);
            this.btnRemove.TabIndex = 88;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(995, 661);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(109, 26);
            this.labelControl5.TabIndex = 91;
            this.labelControl5.Text = "Total Price";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(995, 756);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(215, 26);
            this.labelControl6.TabIndex = 93;
            this.labelControl6.Text = "Add Payment Amount";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(1342, 756);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 26);
            this.labelControl7.TabIndex = 95;
            this.labelControl7.Text = "Change";
            // 
            // seTotalPrice
            // 
            this.seTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seTotalPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTotalPrice.Location = new System.Drawing.Point(996, 696);
            this.seTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seTotalPrice.MenuManager = this.ribbon;
            this.seTotalPrice.Name = "seTotalPrice";
            this.seTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.seTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.seTotalPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTotalPrice.Properties.ReadOnly = true;
            this.seTotalPrice.Size = new System.Drawing.Size(291, 46);
            this.seTotalPrice.TabIndex = 96;
            // 
            // seAddAmount
            // 
            this.seAddAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seAddAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seAddAmount.Location = new System.Drawing.Point(995, 787);
            this.seAddAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seAddAmount.MenuManager = this.ribbon;
            this.seAddAmount.Name = "seAddAmount";
            this.seAddAmount.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.seAddAmount.Properties.Appearance.Options.UseFont = true;
            this.seAddAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seAddAmount.Size = new System.Drawing.Size(291, 46);
            this.seAddAmount.TabIndex = 97;
            this.seAddAmount.EditValueChanged += new System.EventHandler(this.seAddAmount_EditValueChanged);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmPayment.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnConfirmPayment.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.Appearance.Options.UseBackColor = true;
            this.btnConfirmPayment.Appearance.Options.UseFont = true;
            this.btnConfirmPayment.Location = new System.Drawing.Point(996, 867);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(291, 45);
            this.btnConfirmPayment.TabIndex = 98;
            this.btnConfirmPayment.Text = "CONFIRM PAYMENT";
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // seChange
            // 
            this.seChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.seChange.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seChange.Location = new System.Drawing.Point(1342, 787);
            this.seChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seChange.MenuManager = this.ribbon;
            this.seChange.Name = "seChange";
            this.seChange.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.seChange.Properties.Appearance.Options.UseFont = true;
            this.seChange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seChange.Properties.ReadOnly = true;
            this.seChange.Size = new System.Drawing.Size(291, 46);
            this.seChange.TabIndex = 100;
            this.seChange.EditValueChanged += new System.EventHandler(this.seChange_EditValueChanged);
            // 
            // teProductID
            // 
            this.teProductID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teProductID.Location = new System.Drawing.Point(95, 678);
            this.teProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teProductID.MenuManager = this.ribbon;
            this.teProductID.Name = "teProductID";
            this.teProductID.Properties.AllowFocused = false;
            this.teProductID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.teProductID.Properties.Appearance.Options.UseFont = true;
            this.teProductID.Properties.ReadOnly = true;
            this.teProductID.Size = new System.Drawing.Size(310, 46);
            this.teProductID.TabIndex = 102;
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(95, 646);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(107, 26);
            this.labelControl8.TabIndex = 103;
            this.labelControl8.Text = "Product ID";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2088, 1054);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.teProductID);
            this.Controls.Add(this.seChange);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.seAddAmount);
            this.Controls.Add(this.seTotalPrice);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.tePrice);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teProductName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gcOrder);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.seQuantity);
            this.Controls.Add(this.gcProducts);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddOrder.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrder";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.Text = "AddOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seAddAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seQuantity;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.TextEdit teProductName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Capacity;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrder;
        private DevExpress.XtraGrid.Columns.GridColumn RowCount;
        private DevExpress.XtraGrid.Columns.GridColumn OrderedProduct;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.GridControl gcOrder;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn Count;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tePrice;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SpinEdit seTotalPrice;
        private DevExpress.XtraEditors.SpinEdit seAddAmount;
        private DevExpress.XtraEditors.SimpleButton btnConfirmPayment;
        private DevExpress.XtraEditors.SpinEdit seChange;
        private DevExpress.XtraEditors.TextEdit teProductID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraGrid.Columns.GridColumn OrderProductID;
    }
}