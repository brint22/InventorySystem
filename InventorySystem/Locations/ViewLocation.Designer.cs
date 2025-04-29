namespace InventorySystem.Locations
{
    partial class ViewLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLocation));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teLocationID = new DevExpress.XtraEditors.TextEdit();
            this.gcLocation = new DevExpress.XtraGrid.GridControl();
            this.gvLocation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Availability = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capacity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teProductID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teAvailability = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.FilterBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cbFilterBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbLocationGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAvailability.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocationGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(23, 26, 23, 26);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 257;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1385, 61);
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
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Appearance.Options.UseBackColor = true;
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(1145, 130);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(190, 38);
            this.BtnDelete.TabIndex = 82;
            this.BtnDelete.Text = "DELETE";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnUpdate.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Appearance.Options.UseBackColor = true;
            this.BtnUpdate.Appearance.Options.UseFont = true;
            this.BtnUpdate.Location = new System.Drawing.Point(957, 130);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(180, 38);
            this.BtnUpdate.TabIndex = 81;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(42, 106);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 23);
            this.labelControl1.TabIndex = 80;
            this.labelControl1.Text = "Location ID";
            // 
            // teLocationID
            // 
            this.teLocationID.Location = new System.Drawing.Point(42, 131);
            this.teLocationID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teLocationID.Name = "teLocationID";
            this.teLocationID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLocationID.Properties.Appearance.Options.UseFont = true;
            this.teLocationID.Properties.AutoHeight = false;
            this.teLocationID.Size = new System.Drawing.Size(149, 37);
            this.teLocationID.TabIndex = 79;
            // 
            // gcLocation
            // 
            this.gcLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLocation.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcLocation.Location = new System.Drawing.Point(2, 65);
            this.gcLocation.MainView = this.gvLocation;
            this.gcLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcLocation.MenuManager = this.ribbon;
            this.gcLocation.Name = "gcLocation";
            this.gcLocation.Size = new System.Drawing.Size(1291, 276);
            this.gcLocation.TabIndex = 78;
            this.gcLocation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLocation});
            // 
            // gvLocation
            // 
            this.gvLocation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LocationID,
            this.ProductID,
            this.Availability,
            this.Capacity});
            this.gvLocation.DetailHeight = 351;
            this.gvLocation.FixedLineWidth = 3;
            this.gvLocation.GridControl = this.gcLocation;
            this.gvLocation.Name = "gvLocation";
            this.gvLocation.OptionsView.ShowGroupPanel = false;
            // 
            // LocationID
            // 
            this.LocationID.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationID.AppearanceCell.Options.UseFont = true;
            this.LocationID.AppearanceCell.Options.UseTextOptions = true;
            this.LocationID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.LocationID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationID.AppearanceHeader.Options.UseFont = true;
            this.LocationID.Caption = "Location ID";
            this.LocationID.FieldName = "LocationID";
            this.LocationID.MinWidth = 24;
            this.LocationID.Name = "LocationID";
            this.LocationID.OptionsColumn.AllowEdit = false;
            this.LocationID.Visible = true;
            this.LocationID.VisibleIndex = 0;
            this.LocationID.Width = 495;
            // 
            // ProductID
            // 
            this.ProductID.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ProductID.AppearanceCell.Options.UseFont = true;
            this.ProductID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.ProductID.AppearanceHeader.Options.UseFont = true;
            this.ProductID.Caption = "Product ID";
            this.ProductID.FieldName = "ProductID";
            this.ProductID.MinWidth = 24;
            this.ProductID.Name = "ProductID";
            this.ProductID.OptionsColumn.AllowEdit = false;
            this.ProductID.Visible = true;
            this.ProductID.VisibleIndex = 1;
            this.ProductID.Width = 602;
            // 
            // Availability
            // 
            this.Availability.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Availability.AppearanceCell.Options.UseFont = true;
            this.Availability.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Availability.AppearanceHeader.Options.UseFont = true;
            this.Availability.Caption = "Availability";
            this.Availability.FieldName = "Availability";
            this.Availability.MinWidth = 23;
            this.Availability.Name = "Availability";
            this.Availability.OptionsColumn.AllowEdit = false;
            this.Availability.Visible = true;
            this.Availability.VisibleIndex = 2;
            this.Availability.Width = 464;
            // 
            // Capacity
            // 
            this.Capacity.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Capacity.AppearanceHeader.Options.UseFont = true;
            this.Capacity.Caption = "Capacity";
            this.Capacity.FieldName = "Capacity";
            this.Capacity.MinWidth = 23;
            this.Capacity.Name = "Capacity";
            this.Capacity.OptionsColumn.AllowEdit = false;
            this.Capacity.Visible = true;
            this.Capacity.VisibleIndex = 3;
            this.Capacity.Width = 549;
            // 
            // teProductID
            // 
            this.teProductID.Location = new System.Drawing.Point(217, 131);
            this.teProductID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teProductID.Name = "teProductID";
            this.teProductID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teProductID.Properties.Appearance.Options.UseFont = true;
            this.teProductID.Properties.AutoHeight = false;
            this.teProductID.Size = new System.Drawing.Size(149, 37);
            this.teProductID.TabIndex = 83;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(217, 106);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 23);
            this.labelControl2.TabIndex = 84;
            this.labelControl2.Text = "Product ID";
            // 
            // teAvailability
            // 
            this.teAvailability.Location = new System.Drawing.Point(387, 131);
            this.teAvailability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teAvailability.Name = "teAvailability";
            this.teAvailability.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teAvailability.Properties.Appearance.Options.UseFont = true;
            this.teAvailability.Properties.AutoHeight = false;
            this.teAvailability.Size = new System.Drawing.Size(149, 37);
            this.teAvailability.TabIndex = 85;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(387, 106);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 23);
            this.labelControl3.TabIndex = 86;
            this.labelControl3.Text = "Availability";
            // 
            // FilterBtn
            // 
            this.FilterBtn.Appearance.BackColor = System.Drawing.Color.Teal;
            this.FilterBtn.Appearance.Options.UseBackColor = true;
            this.FilterBtn.Location = new System.Drawing.Point(282, 20);
            this.FilterBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(62, 26);
            this.FilterBtn.TabIndex = 89;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Location = new System.Drawing.Point(140, 20);
            this.cbFilterBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Properties.AutoHeight = false;
            this.cbFilterBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbFilterBy.Properties.Items.AddRange(new object[] {
            "all availability",
            "occupied",
            "available"});
            this.cbFilterBy.Size = new System.Drawing.Size(135, 26);
            this.cbFilterBy.TabIndex = 88;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.FilterBtn);
            this.groupControl1.Controls.Add(this.gcLocation);
            this.groupControl1.Controls.Add(this.cbFilterBy);
            this.groupControl1.Location = new System.Drawing.Point(42, 211);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1295, 343);
            this.groupControl1.TabIndex = 90;
            this.groupControl1.Text = "Filter By:";
            // 
            // cbLocationGroup
            // 
            this.cbLocationGroup.Location = new System.Drawing.Point(563, 130);
            this.cbLocationGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLocationGroup.MenuManager = this.ribbon;
            this.cbLocationGroup.Name = "cbLocationGroup";
            this.cbLocationGroup.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocationGroup.Properties.Appearance.Options.UseFont = true;
            this.cbLocationGroup.Properties.AutoHeight = false;
            this.cbLocationGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLocationGroup.Properties.Items.AddRange(new object[] {
            "ALL",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K"});
            this.cbLocationGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbLocationGroup.Size = new System.Drawing.Size(134, 38);
            this.cbLocationGroup.TabIndex = 92;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(563, 106);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 23);
            this.labelControl4.TabIndex = 93;
            this.labelControl4.Text = "Group";
            // 
            // ViewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 631);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbLocationGroup);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.teAvailability);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teProductID);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teLocationID);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ViewLocation.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "ViewLocation";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLocation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAvailability.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFilterBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbLocationGroup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teLocationID;
        private DevExpress.XtraGrid.Columns.GridColumn LocationID;
        private DevExpress.XtraGrid.Columns.GridColumn ProductID;
        private DevExpress.XtraGrid.Columns.GridColumn Availability;
        private DevExpress.XtraEditors.TextEdit teProductID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teAvailability;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraGrid.GridControl gcLocation;
        public DevExpress.XtraGrid.Views.Grid.GridView gvLocation;
        private DevExpress.XtraEditors.SimpleButton FilterBtn;
        private DevExpress.XtraEditors.ComboBoxEdit cbFilterBy;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbLocationGroup;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn Capacity;
    }
}