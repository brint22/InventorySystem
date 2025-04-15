namespace InventorySystem.views
{
    partial class Laborer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laborer));
            this.gcFacultyStaff = new DevExpress.XtraEditors.GroupControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.cbFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcEmployeeList = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Category = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Brand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFacultyStaff)).BeginInit();
            this.gcFacultyStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFacultyStaff
            // 
            this.gcFacultyStaff.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.gcFacultyStaff.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gcFacultyStaff.CaptionImageOptions.SvgImage")));
            this.gcFacultyStaff.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(26, 26);
            this.gcFacultyStaff.Controls.Add(this.gcEmployeeList);
            this.gcFacultyStaff.Controls.Add(this.txtSearch);
            this.gcFacultyStaff.Controls.Add(this.labelControl1);
            this.gcFacultyStaff.Controls.Add(this.btnFilter);
            this.gcFacultyStaff.Controls.Add(this.cbFilter);
            this.gcFacultyStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFacultyStaff.Location = new System.Drawing.Point(0, 0);
            this.gcFacultyStaff.Name = "gcFacultyStaff";
            this.gcFacultyStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.gcFacultyStaff.Size = new System.Drawing.Size(947, 507);
            this.gcFacultyStaff.TabIndex = 6;
            this.gcFacultyStaff.Text = "   Filter By :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(113, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.AutoHeight = false;
            this.txtSearch.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtSearch.Properties.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtSearch_Properties_EditValueChanging);
            this.txtSearch.Size = new System.Drawing.Size(483, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Search Keyword :";
            // 
            // btnFilter
            // 
            this.btnFilter.Appearance.BackColor = System.Drawing.Color.Gray;
            this.btnFilter.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Appearance.Options.UseBackColor = true;
            this.btnFilter.Appearance.Options.UseForeColor = true;
            this.btnFilter.Location = new System.Drawing.Point(281, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(53, 21);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "FILTER";
            // 
            // cbFilter
            // 
            this.cbFilter.Location = new System.Drawing.Point(113, 13);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Properties.AutoHeight = false;
            this.cbFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFilter.Properties.Items.AddRange(new object[] {
            "All Records",
            "Faculty",
            "Staff"});
            this.cbFilter.Size = new System.Drawing.Size(162, 21);
            this.cbFilter.TabIndex = 1;
            // 
            // gcEmployeeList
            // 
            this.gcEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEmployeeList.Location = new System.Drawing.Point(2, 108);
            this.gcEmployeeList.MainView = this.gvEmployeeList;
            this.gcEmployeeList.Name = "gcEmployeeList";
            this.gcEmployeeList.Size = new System.Drawing.Size(942, 394);
            this.gcEmployeeList.TabIndex = 7;
            this.gcEmployeeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeList});
            // 
            // gvEmployeeList
            // 
            this.gvEmployeeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductName,
            this.Price,
            this.Quantity,
            this.ExpirationDate,
            this.Category,
            this.Brand,
            this.Supplier});
            this.gvEmployeeList.FixedLineWidth = 1;
            this.gvEmployeeList.GridControl = this.gcEmployeeList;
            this.gvEmployeeList.Name = "gvEmployeeList";
            this.gvEmployeeList.OptionsView.ShowGroupPanel = false;
            this.gvEmployeeList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 0;
            this.ProductName.Width = 120;
            // 
            // Price
            // 
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.AppearanceHeader.Options.UseForeColor = true;
            this.Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 1;
            this.Price.Width = 90;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Options.UseForeColor = true;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.AllowEdit = false;
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 2;
            this.Quantity.Width = 100;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.ExpirationDate.AppearanceHeader.Options.UseFont = true;
            this.ExpirationDate.AppearanceHeader.Options.UseForeColor = true;
            this.ExpirationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.ExpirationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ExpirationDate.Caption = "Expiration Date";
            this.ExpirationDate.FieldName = "ExpirationDate";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.OptionsColumn.AllowEdit = false;
            this.ExpirationDate.Visible = true;
            this.ExpirationDate.VisibleIndex = 3;
            this.ExpirationDate.Width = 130;
            // 
            // Category
            // 
            this.Category.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Category.AppearanceHeader.Options.UseFont = true;
            this.Category.AppearanceHeader.Options.UseForeColor = true;
            this.Category.AppearanceHeader.Options.UseTextOptions = true;
            this.Category.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Category.Caption = "Category";
            this.Category.FieldName = "Category";
            this.Category.Name = "Category";
            this.Category.OptionsColumn.AllowEdit = false;
            this.Category.Visible = true;
            this.Category.VisibleIndex = 4;
            this.Category.Width = 100;
            // 
            // Brand
            // 
            this.Brand.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Brand.AppearanceHeader.Options.UseFont = true;
            this.Brand.AppearanceHeader.Options.UseForeColor = true;
            this.Brand.AppearanceHeader.Options.UseTextOptions = true;
            this.Brand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Brand.Caption = "Brand";
            this.Brand.FieldName = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.OptionsColumn.AllowEdit = false;
            this.Brand.Visible = true;
            this.Brand.VisibleIndex = 5;
            this.Brand.Width = 100;
            // 
            // Supplier
            // 
            this.Supplier.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Supplier.AppearanceHeader.Options.UseFont = true;
            this.Supplier.AppearanceHeader.Options.UseForeColor = true;
            this.Supplier.AppearanceHeader.Options.UseTextOptions = true;
            this.Supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Supplier.Caption = "Supplier";
            this.Supplier.FieldName = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.Visible = true;
            this.Supplier.VisibleIndex = 6;
            this.Supplier.Width = 100;
            // 
            // Laborer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 507);
            this.Controls.Add(this.gcFacultyStaff);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Laborer.IconOptions.SvgImage")));
            this.Name = "Laborer";
            this.Text = "Laborer";
            ((System.ComponentModel.ISupportInitialize)(this.gcFacultyStaff)).EndInit();
            this.gcFacultyStaff.ResumeLayout(false);
            this.gcFacultyStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFacultyStaff;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.ComboBoxEdit cbFilter;
        private DevExpress.XtraGrid.GridControl gcEmployeeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployeeList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn ExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn Category;
        private DevExpress.XtraGrid.Columns.GridColumn Brand;
        private DevExpress.XtraGrid.Columns.GridColumn Supplier;
    }
}