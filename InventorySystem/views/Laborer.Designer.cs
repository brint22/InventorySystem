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
            this.gcEmployeeList = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.cbFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Quantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductRecieved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFacultyStaff)).BeginInit();
            this.gcFacultyStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter.Properties)).BeginInit();
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
            // gcEmployeeList
            // 
            this.gcEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEmployeeList.Location = new System.Drawing.Point(0, 115);
            this.gcEmployeeList.MainView = this.gvEmployeeList;
            this.gcEmployeeList.Name = "gcEmployeeList";
            this.gcEmployeeList.Size = new System.Drawing.Size(942, 404);
            this.gcEmployeeList.TabIndex = 6;
            this.gcEmployeeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeList});
            // 
            // gvEmployeeList
            // 
            this.gvEmployeeList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.ExpirationDate,
            this.ProductRecieved,
            this.CategoryID});
            this.gvEmployeeList.FixedLineWidth = 1;
            this.gvEmployeeList.GridControl = this.gcEmployeeList;
            this.gvEmployeeList.Name = "gvEmployeeList";
            this.gvEmployeeList.OptionsView.ShowGroupPanel = false;
            this.gvEmployeeList.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
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
            this.btnFilter.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnFilter.Appearance.Options.UseBackColor = true;
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
            // ProductID
            // 
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.AppearanceHeader.ForeColor = System.Drawing.Color.Teal;
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Options.UseForeColor = true;
            this.ProductID.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductID.Caption = "ProductID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 0;
            this.ProductID.Width = 117;
            // 
            // ProductName
            // 
            this.ProductName.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.AppearanceHeader.ForeColor = System.Drawing.Color.Teal;
            this.ProductName.AppearanceHeader.Options.UseFont = true;
            this.ProductName.AppearanceHeader.Options.UseForeColor = true;
            this.ProductName.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductName.Caption = "ProductName";
            this.ProductName.FieldName = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.OptionsColumn.AllowEdit = false;
            this.ProductName.Visible = true;
            this.ProductName.VisibleIndex = 1;
            this.ProductName.Width = 135;
            // 
            // Price
            // 
            this.Price.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.AppearanceHeader.ForeColor = System.Drawing.Color.Teal;
            this.Price.AppearanceHeader.Options.UseFont = true;
            this.Price.AppearanceHeader.Options.UseForeColor = true;
            this.Price.AppearanceHeader.Options.UseTextOptions = true;
            this.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Price.Caption = "Price";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.OptionsColumn.AllowEdit = false;
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            this.Price.Width = 81;
            // 
            // Quantity
            // 
            this.Quantity.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.AppearanceHeader.ForeColor = System.Drawing.Color.Teal;
            this.Quantity.AppearanceHeader.Options.UseFont = true;
            this.Quantity.AppearanceHeader.Options.UseForeColor = true;
            this.Quantity.AppearanceHeader.Options.UseTextOptions = true;
            this.Quantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Quantity.Caption = "Quantity";
            this.Quantity.FieldName = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.OptionsColumn.AllowEdit = false;
            this.Quantity.Visible = true;
            this.Quantity.VisibleIndex = 3;
            this.Quantity.Width = 74;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDate.AppearanceHeader.ForeColor = System.Drawing.Color.Teal;
            this.ExpirationDate.AppearanceHeader.Options.UseFont = true;
            this.ExpirationDate.AppearanceHeader.Options.UseForeColor = true;
            this.ExpirationDate.AppearanceHeader.Options.UseTextOptions = true;
            this.ExpirationDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ExpirationDate.Caption = "ExpirationDate";
            this.ExpirationDate.FieldName = "ExpirationDate";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.OptionsColumn.AllowEdit = false;
            this.ExpirationDate.Visible = true;
            this.ExpirationDate.VisibleIndex = 4;
            this.ExpirationDate.Width = 92;
            // 
            // ProductRecieved
            // 
            this.ProductRecieved.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductRecieved.AppearanceHeader.ForeColor = System.Drawing.Color.Teal;
            this.ProductRecieved.AppearanceHeader.Options.UseFont = true;
            this.ProductRecieved.AppearanceHeader.Options.UseForeColor = true;
            this.ProductRecieved.AppearanceHeader.Options.UseTextOptions = true;
            this.ProductRecieved.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ProductRecieved.Caption = "ProductRecieved";
            this.ProductRecieved.FieldName = "ProductRecieved";
            this.ProductRecieved.Name = "ProductRecieved";
            this.ProductRecieved.OptionsColumn.AllowEdit = false;
            this.ProductRecieved.Visible = true;
            this.ProductRecieved.VisibleIndex = 5;
            this.ProductRecieved.Width = 80;
            // 
            // CategoryID
            // 
            this.CategoryID.AppearanceHeader.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryID.AppearanceHeader.ForeColor = System.Drawing.Color.Teal;
            this.CategoryID.AppearanceHeader.Options.UseFont = true;
            this.CategoryID.AppearanceHeader.Options.UseForeColor = true;
            this.CategoryID.AppearanceHeader.Options.UseTextOptions = true;
            this.CategoryID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CategoryID.Caption = "CategoryID";
            this.CategoryID.FieldName = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Visible = true;
            this.CategoryID.VisibleIndex = 6;
            this.CategoryID.Width = 111;
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
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilter.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcFacultyStaff;
        private DevExpress.XtraGrid.GridControl gcEmployeeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployeeList;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductName;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn Quantity;
        private DevExpress.XtraGrid.Columns.GridColumn ExpirationDate;
        private DevExpress.XtraGrid.Columns.GridColumn ProductRecieved;
        private DevExpress.XtraGrid.Columns.GridColumn CategoryID;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraEditors.ComboBoxEdit cbFilter;
    }
}