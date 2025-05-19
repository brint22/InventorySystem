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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RowCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderedProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcOrder = new DevExpress.XtraGrid.GridControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1384, 49);
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
            this.BtnSubmit.Location = new System.Drawing.Point(56, 754);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(249, 31);
            this.BtnSubmit.TabIndex = 33;
            this.BtnSubmit.Text = "SUBMIT";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(58, 574);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(210, 31);
            this.simpleButton2.TabIndex = 79;
            this.simpleButton2.Text = "SUBMIT";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(58, 506);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 17);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Quantity";
            // 
            // spinEdit1
            // 
            this.spinEdit1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(58, 527);
            this.spinEdit1.MenuManager = this.ribbon;
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(211, 32);
            this.spinEdit1.TabIndex = 23;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(283, 574);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(193, 31);
            this.BtnCancel.TabIndex = 80;
            this.BtnCancel.Text = "CANCEL";
            // 
            // teProductName
            // 
            this.teProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teProductName.Location = new System.Drawing.Point(58, 461);
            this.teProductName.MenuManager = this.ribbon;
            this.teProductName.Name = "teProductName";
            this.teProductName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.teProductName.Properties.Appearance.Options.UseFont = true;
            this.teProductName.Size = new System.Drawing.Size(419, 32);
            this.teProductName.TabIndex = 82;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(58, 68);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(116, 17);
            this.labelControl3.TabIndex = 36;
            this.labelControl3.Text = "Search Keyword :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(58, 89);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtSearch.Size = new System.Drawing.Size(418, 28);
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
            this.gvProducts.DetailHeight = 285;
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsEditForm.PopupEditFormWidth = 686;
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
            this.Count.Name = "Count";
            this.Count.Visible = true;
            this.Count.VisibleIndex = 0;
            // 
            // ProductID
            // 
            this.ProductID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ProductID.AppearanceCell.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.Caption = "ProductID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 21;
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 1;
            this.ProductID.Width = 111;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 21;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 2;
            this.ProductName.Width = 194;
            // 
            // Capacity
            // 
            this.Capacity.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Capacity.AppearanceCell.Options.UseFont = true;
            this.Capacity.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Capacity.AppearanceHeader.Options.UseFont = true;
            this.Capacity.Caption = "Available Stocks";
            this.Capacity.FieldName = "Capacity";
            this.Capacity.MinWidth = 21;
            this.Capacity.Name = "Capacity";
            this.Capacity.OptionsColumn.AllowEdit = false;
            this.Capacity.Visible = true;
            this.Capacity.VisibleIndex = 3;
            this.Capacity.Width = 173;
            // 
            // Price
            // 
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 21;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 125;
            // 
            // gcProducts
            // 
            this.gcProducts.Location = new System.Drawing.Point(58, 130);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.MenuManager = this.ribbon;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(572, 286);
            this.gcProducts.TabIndex = 2;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RowCount,
            this.OrderedProduct,
            this.Quantity});
            this.gridView2.DetailHeight = 285;
            this.gridView2.FixedLineWidth = 3;
            this.gridView2.GridControl = this.gcOrder;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsEditForm.PopupEditFormWidth = 686;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // RowCount
            // 
            this.RowCount.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.RowCount.AppearanceCell.Options.UseFont = true;
            this.RowCount.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.RowCount.AppearanceHeader.Options.UseFont = true;
            this.RowCount.Caption = "#";
            this.RowCount.FieldName = "RowCount";
            this.RowCount.Name = "RowCount";
            this.RowCount.OptionsColumn.AllowEdit = false;
            this.RowCount.Visible = true;
            this.RowCount.VisibleIndex = 0;
            this.RowCount.Width = 100;
            // 
            // OrderedProduct
            // 
            this.OrderedProduct.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.OrderedProduct.AppearanceCell.Options.UseFont = true;
            this.OrderedProduct.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.OrderedProduct.AppearanceHeader.Options.UseFont = true;
            this.OrderedProduct.Caption = "Ordered Products";
            this.OrderedProduct.FieldName = "OrderedProduct";
            this.OrderedProduct.MinWidth = 21;
            this.OrderedProduct.Name = "OrderedProduct";
            this.OrderedProduct.Visible = true;
            this.OrderedProduct.VisibleIndex = 1;
            this.OrderedProduct.Width = 311;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Quantity.AppearanceCell.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 21;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 2;
            this.Quantity.Width = 177;
            // 
            // gcOrder
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gcOrder.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcOrder.Location = new System.Drawing.Point(664, 130);
            this.gcOrder.MainView = this.gridView2;
            this.gcOrder.MenuManager = this.ribbon;
            this.gcOrder.Name = "gcOrder";
            this.gcOrder.Size = new System.Drawing.Size(666, 286);
            this.gcOrder.TabIndex = 34;
            this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(58, 437);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 17);
            this.labelControl2.TabIndex = 83;
            this.labelControl2.Text = "Product Name";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 721);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teProductName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.gcOrder);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.gcProducts);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddOrder.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrder";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.Text = "AddOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn RowCount;
        private DevExpress.XtraGrid.Columns.GridColumn OrderedProduct;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.GridControl gcOrder;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn Count;
    }
}