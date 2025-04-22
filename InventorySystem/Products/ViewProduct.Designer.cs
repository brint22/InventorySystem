namespace InventorySystem.views
{
    partial class ViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            this.gcFacultyStaff = new DevExpress.XtraEditors.GroupControl();
            this.gcProductList = new DevExpress.XtraGrid.GridControl();
            this.gvProductList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Availability = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.cbFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFacultyStaff)).BeginInit();
            this.gcFacultyStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFacultyStaff
            // 
            this.gcFacultyStaff.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.gcFacultyStaff.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gcFacultyStaff.CaptionImageOptions.SvgImage")));
            this.gcFacultyStaff.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.gcFacultyStaff.Controls.Add(this.gcProductList);
            this.gcFacultyStaff.Controls.Add(this.txtSearch);
            this.gcFacultyStaff.Controls.Add(this.labelControl1);
            this.gcFacultyStaff.Controls.Add(this.btnFilter);
            this.gcFacultyStaff.Controls.Add(this.cbFilter);
            this.gcFacultyStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFacultyStaff.Location = new System.Drawing.Point(0, 0);
            this.gcFacultyStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcFacultyStaff.Name = "gcFacultyStaff";
            this.gcFacultyStaff.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.gcFacultyStaff.Size = new System.Drawing.Size(1384, 741);
            this.gcFacultyStaff.TabIndex = 6;
            this.gcFacultyStaff.Text = "   Filter By :";
            // 
            // gcProductList
            // 
            this.gcProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProductList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcProductList.Location = new System.Drawing.Point(3, 158);
            this.gcProductList.MainView = this.gvProductList;
            this.gcProductList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcProductList.Name = "gcProductList";
            this.gcProductList.Size = new System.Drawing.Size(1377, 576);
            this.gcProductList.TabIndex = 7;
            this.gcProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductList});
            // 
            // gvProductList
            // 
            this.gvProductList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.ExpirationDate,
            this.CategoryName,
            this.LocationID,
            this.BrandName,
            this.Supplier,
            this.Availability});
            this.gvProductList.DetailHeight = 512;
            this.gvProductList.FixedLineWidth = 1;
            this.gvProductList.GridControl = this.gcProductList;
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.OptionsEditForm.PopupEditFormWidth = 1200;
            this.gvProductList.OptionsView.ShowGroupPanel = false;
            this.gvProductList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // ProductID
            // 
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.Caption = "Product ID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 30;
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 0;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.ProductName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.MinWidth = 30;
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 111;
            // 
            // Price
            // 
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.Price.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.AppearanceHeader.Options.UseForeColor = true;
            this.Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 30;
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            this.Price.Width = 76;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.Quantity.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Options.UseForeColor = true;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.MinWidth = 30;
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.AllowEdit = false;
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 3;
            this.Quantity.Width = 82;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.ExpirationDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.ExpirationDate.AppearanceHeader.Options.UseFont = true;
            this.ExpirationDate.AppearanceHeader.Options.UseForeColor = true;
            this.ExpirationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.ExpirationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ExpirationDate.Caption = "Expiration Date";
            this.ExpirationDate.FieldName = "ExpirationDate";
            this.ExpirationDate.MinWidth = 30;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.OptionsColumn.AllowEdit = false;
            this.ExpirationDate.Visible = true;
            this.ExpirationDate.VisibleIndex = 4;
            this.ExpirationDate.Width = 115;
            // 
            // CategoryName
            // 
            this.CategoryName.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.CategoryName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.CategoryName.AppearanceHeader.Options.UseFont = true;
            this.CategoryName.AppearanceHeader.Options.UseForeColor = true;
            this.CategoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.CategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CategoryName.Caption = "Category";
            this.CategoryName.FieldName = "CategoryName";
            this.CategoryName.MinWidth = 30;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.OptionsColumn.AllowEdit = false;
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 5;
            this.CategoryName.Width = 91;
            // 
            // LocationID
            // 
            this.LocationID.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.LocationID.AppearanceHeader.Options.UseFont = true;
            this.LocationID.Caption = "Location";
            this.LocationID.FieldName = "LocationID";
            this.LocationID.MinWidth = 30;
            this.LocationID.Name = "LocationID";
            this.LocationID.OptionsColumn.AllowEdit = false;
            this.LocationID.Visible = true;
            this.LocationID.VisibleIndex = 6;
            // 
            // BrandName
            // 
            this.BrandName.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.BrandName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.BrandName.AppearanceHeader.Options.UseFont = true;
            this.BrandName.AppearanceHeader.Options.UseForeColor = true;
            this.BrandName.AppearanceHeader.Options.UseTextOptions = true;
            this.BrandName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BrandName.Caption = "Brand";
            this.BrandName.FieldName = "BrandName";
            this.BrandName.MinWidth = 30;
            this.BrandName.Name = "BrandName";
            this.BrandName.OptionsColumn.AllowEdit = false;
            this.BrandName.Visible = true;
            this.BrandName.VisibleIndex = 7;
            this.BrandName.Width = 91;
            // 
            // Supplier
            // 
            this.Supplier.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.Supplier.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Supplier.AppearanceHeader.Options.UseFont = true;
            this.Supplier.AppearanceHeader.Options.UseForeColor = true;
            this.Supplier.AppearanceHeader.Options.UseTextOptions = true;
            this.Supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Supplier.Caption = "Supplier";
            this.Supplier.FieldName = "Supplier";
            this.Supplier.MinWidth = 30;
            this.Supplier.Name = "Supplier";
            this.Supplier.Visible = true;
            this.Supplier.VisibleIndex = 8;
            this.Supplier.Width = 96;
            // 
            // Availability
            // 
            this.Availability.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold);
            this.Availability.AppearanceHeader.Options.UseFont = true;
            this.Availability.Caption = "Availability";
            this.Availability.FieldName = "Availability";
            this.Availability.MinWidth = 30;
            this.Availability.Name = "Availability";
            this.Availability.OptionsColumn.AllowEdit = false;
            this.Availability.Visible = true;
            this.Availability.VisibleIndex = 9;
            this.Availability.Width = 123;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(170, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.AutoHeight = false;
            this.txtSearch.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtSearch.Size = new System.Drawing.Size(724, 32);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtSearch_EditValueChanging);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 104);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 19);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Search Keyword :";
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.BackColor = System.Drawing.Color.Gray;
            this.btnFilter.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Appearance.Options.UseBackColor = true;
            this.btnFilter.Appearance.Options.UseForeColor = true;
            this.btnFilter.Location = new System.Drawing.Point(422, 19);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(80, 31);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "FILTER";
            // 
            // cbFilter
            // 
            this.cbFilter.Location = new System.Drawing.Point(170, 19);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Properties.AutoHeight = false;
            this.cbFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFilter.Properties.Items.AddRange(new object[] {
            "All Records",
            "Faculty",
            "Staff"});
            this.cbFilter.Size = new System.Drawing.Size(243, 31);
            this.cbFilter.TabIndex = 1;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 741);
            this.Controls.Add(this.gcFacultyStaff);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ViewProduct.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewProduct";
            this.Text = "Laborer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcFacultyStaff)).EndInit();
            this.gcFacultyStaff.ResumeLayout(false);
            this.gcFacultyStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFacultyStaff;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.ComboBoxEdit cbFilter;
        private DevExpress.XtraGrid.GridControl gcProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProductList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn ExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn BrandName;
        private DevExpress.XtraGrid.Columns.GridColumn Supplier;
        private DevExpress.XtraGrid.Columns.GridColumn LocationID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn Availability;
    }
}