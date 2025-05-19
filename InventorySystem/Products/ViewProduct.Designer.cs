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
            this.CategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capacity = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcFacultyStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcFacultyStaff.Name = "gcFacultyStaff";
            this.gcFacultyStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.gcFacultyStaff.Size = new System.Drawing.Size(1097, 507);
            this.gcFacultyStaff.TabIndex = 6;
            this.gcFacultyStaff.Text = "   Filter By :";
            // 
            // gcProductList
            // 
            this.gcProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProductList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProductList.Location = new System.Drawing.Point(2, 108);
            this.gcProductList.MainView = this.gvProductList;
            this.gcProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcProductList.Name = "gcProductList";
            this.gcProductList.Size = new System.Drawing.Size(1093, 394);
            this.gcProductList.TabIndex = 7;
            this.gcProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProductList});
            // 
            // gvProductList
            // 
            this.gvProductList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductID,
            this.ProductName,
            this.CategoryName,
            this.Price,
            this.Capacity});
            this.gvProductList.FixedLineWidth = 1;
            this.gvProductList.GridControl = this.gcProductList;
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.OptionsView.ShowGroupPanel = false;
            this.gvProductList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // ProductID
            // 
            this.ProductID.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.ProductID.AppearanceCell.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.Caption = "Product ID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 0;
            this.ProductID.Width = 50;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.ProductName.AppearanceCell.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "Product Name";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 74;
            // 
            // CategoryName
            // 
            this.CategoryName.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.CategoryName.AppearanceCell.Options.UseFont = true;
            this.CategoryName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.CategoryName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.CategoryName.AppearanceHeader.Options.UseFont = true;
            this.CategoryName.AppearanceHeader.Options.UseForeColor = true;
            this.CategoryName.AppearanceHeader.Options.UseTextOptions = true;
            this.CategoryName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CategoryName.Caption = "Category";
            this.CategoryName.FieldName = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.OptionsColumn.AllowEdit = false;
            this.CategoryName.Visible = true;
            this.CategoryName.VisibleIndex = 2;
            this.CategoryName.Width = 61;
            // 
            // Price
            // 
            this.Price.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.Price.AppearanceCell.Options.UseFont = true;
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
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
            this.Price.VisibleIndex = 3;
            this.Price.Width = 61;
            // 
            // Capacity
            // 
            this.Capacity.AppearanceCell.Font = new System.Drawing.Font("Arial", 10F);
            this.Capacity.AppearanceCell.Options.UseFont = true;
            this.Capacity.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Capacity.AppearanceHeader.Options.UseFont = true;
            this.Capacity.AppearanceHeader.Options.UseTextOptions = true;
            this.Capacity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Capacity.Caption = "Capacity";
            this.Capacity.FieldName = "Capacity";
            this.Capacity.MinWidth = 21;
            this.Capacity.Name = "Capacity";
            this.Capacity.Visible = true;
            this.Capacity.VisibleIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(113, 64);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.AutoHeight = false;
            this.txtSearch.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtSearch.Size = new System.Drawing.Size(483, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtSearch_EditValueChanging);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 72);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(53, 21);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "FILTER";
            // 
            // cbFilter
            // 
            this.cbFilter.Location = new System.Drawing.Point(113, 13);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 507);
            this.Controls.Add(this.gcFacultyStaff);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ViewProduct.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewProduct";
            this.Text = "Product List";
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
        private DevExpress.XtraGrid.Columns.GridColumn CategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn Capacity;
    }
}