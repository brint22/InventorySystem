namespace InventorySystem.Products
{
    partial class ViewStock
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcStock = new DevExpress.XtraGrid.GridControl();
            this.gvCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StockID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductReceived = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationCapacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teCategoryName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCategoryName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(39, 35, 39, 35);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 424;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1779, 73);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // gcStock
            // 
            this.gcStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcStock.Location = new System.Drawing.Point(36, 181);
            this.gcStock.MainView = this.gvCategory;
            this.gcStock.MenuManager = this.ribbon;
            this.gcStock.Name = "gcStock";
            this.gcStock.Size = new System.Drawing.Size(1702, 611);
            this.gcStock.TabIndex = 3;
            this.gcStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategory});
            // 
            // gvCategory
            // 
            this.gvCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StockID,
            this.ProductID,
            this.ProductName,
            this.ExpirationDate,
            this.Quantity,
            this.Supplier,
            this.ProductReceived,
            this.LocationID,
            this.LocationCapacity});
            this.gvCategory.DetailHeight = 351;
            this.gvCategory.GridControl = this.gcStock;
            this.gvCategory.Name = "gvCategory";
            this.gvCategory.OptionsEditForm.PopupEditFormWidth = 799;
            this.gvCategory.OptionsView.ShowGroupPanel = false;
            // 
            // StockID
            // 
            this.StockID.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.StockID.AppearanceCell.Options.UseFont = true;
            this.StockID.AppearanceCell.Options.UseTextOptions = true;
            this.StockID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.StockID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.StockID.AppearanceHeader.Options.UseFont = true;
            this.StockID.AppearanceHeader.Options.UseTextOptions = true;
            this.StockID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StockID.Caption = "Stock ID";
            this.StockID.FieldName = "StockID";
            this.StockID.MinWidth = 24;
            this.StockID.Name = "StockID";
            this.StockID.OptionsColumn.AllowEdit = false;
            this.StockID.Visible = true;
            this.StockID.VisibleIndex = 0;
            this.StockID.Width = 124;
            // 
            // ProductID
            // 
            this.ProductID.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ProductID.AppearanceCell.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.Caption = "Product ID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 30;
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 1;
            this.ProductID.Width = 169;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 24;
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 2;
            this.ProductName.Width = 220;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ExpirationDate.AppearanceCell.Options.UseFont = true;
            this.ExpirationDate.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ExpirationDate.AppearanceHeader.Options.UseFont = true;
            this.ExpirationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.ExpirationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ExpirationDate.Caption = "Expiration Date";
            this.ExpirationDate.FieldName = "ExpirationDate";
            this.ExpirationDate.MinWidth = 24;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.Visible = true;
            this.ExpirationDate.VisibleIndex = 4;
            this.ExpirationDate.Width = 244;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Quantity.AppearanceCell.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 24;
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 3;
            this.Quantity.Width = 180;
            // 
            // Supplier
            // 
            this.Supplier.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Supplier.AppearanceCell.Options.UseFont = true;
            this.Supplier.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Supplier.AppearanceHeader.Options.UseFont = true;
            this.Supplier.AppearanceHeader.Options.UseTextOptions = true;
            this.Supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Supplier.Caption = "Supplier";
            this.Supplier.FieldName = "Supplier";
            this.Supplier.MinWidth = 24;
            this.Supplier.Name = "Supplier";
            this.Supplier.Visible = true;
            this.Supplier.VisibleIndex = 5;
            this.Supplier.Width = 217;
            // 
            // ProductReceived
            // 
            this.ProductReceived.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ProductReceived.AppearanceCell.Options.UseFont = true;
            this.ProductReceived.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ProductReceived.AppearanceHeader.Options.UseFont = true;
            this.ProductReceived.Caption = "Product Received";
            this.ProductReceived.FieldName = "ProductReceived";
            this.ProductReceived.MinWidth = 30;
            this.ProductReceived.Name = "ProductReceived";
            this.ProductReceived.OptionsColumn.AllowEdit = false;
            this.ProductReceived.Visible = true;
            this.ProductReceived.VisibleIndex = 6;
            this.ProductReceived.Width = 292;
            // 
            // LocationID
            // 
            this.LocationID.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationID.AppearanceCell.Options.UseFont = true;
            this.LocationID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationID.AppearanceHeader.Options.UseFont = true;
            this.LocationID.Caption = "Location";
            this.LocationID.FieldName = "LocationID";
            this.LocationID.MinWidth = 31;
            this.LocationID.Name = "LocationID";
            this.LocationID.Visible = true;
            this.LocationID.VisibleIndex = 7;
            this.LocationID.Width = 169;
            // 
            // LocationCapacity
            // 
            this.LocationCapacity.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationCapacity.AppearanceCell.Options.UseFont = true;
            this.LocationCapacity.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationCapacity.AppearanceHeader.Options.UseFont = true;
            this.LocationCapacity.Caption = "Location Capacity";
            this.LocationCapacity.FieldName = "LocationCapacity";
            this.LocationCapacity.MinWidth = 31;
            this.LocationCapacity.Name = "LocationCapacity";
            this.LocationCapacity.Visible = true;
            this.LocationCapacity.VisibleIndex = 8;
            this.LocationCapacity.Width = 229;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Appearance.Options.UseBackColor = true;
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnDelete.Location = new System.Drawing.Point(1548, 117);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(190, 38);
            this.BtnDelete.TabIndex = 79;
            this.BtnDelete.Text = "DELETE";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnUpdate.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Appearance.Options.UseBackColor = true;
            this.BtnUpdate.Appearance.Options.UseFont = true;
            this.BtnUpdate.Location = new System.Drawing.Point(1360, 117);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(180, 38);
            this.BtnUpdate.TabIndex = 78;
            this.BtnUpdate.Text = "UPDATE";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(176, 27);
            this.labelControl1.TabIndex = 81;
            this.labelControl1.Text = "Search Keyword";
            // 
            // teCategoryName
            // 
            this.teCategoryName.Location = new System.Drawing.Point(36, 117);
            this.teCategoryName.Name = "teCategoryName";
            this.teCategoryName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCategoryName.Properties.Appearance.Options.UseFont = true;
            this.teCategoryName.Properties.AutoHeight = false;
            this.teCategoryName.Size = new System.Drawing.Size(393, 37);
            this.teCategoryName.TabIndex = 80;
            // 
            // ViewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 908);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teCategoryName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.gcStock);
            this.Controls.Add(this.ribbon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewStock";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCategoryName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gcStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategory;
        private DevExpress.XtraGrid.Columns.GridColumn StockID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn ExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn Supplier;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductReceived;
        private DevExpress.XtraGrid.Columns.GridColumn LocationID;
        private DevExpress.XtraGrid.Columns.GridColumn LocationCapacity;
    }
}