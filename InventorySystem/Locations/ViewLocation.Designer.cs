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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teLocationStart = new DevExpress.XtraEditors.TextEdit();
            this.gcLocation = new DevExpress.XtraGrid.GridControl();
            this.gvLocation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LocationID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LocationFinish = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Availability = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teLocationFinish = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teAvailability = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocationStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocationFinish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAvailability.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1398, 73);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 566);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1398, 55);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Appearance.Options.UseBackColor = true;
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(1103, 113);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(244, 45);
            this.BtnDelete.TabIndex = 82;
            this.BtnDelete.Text = "DELETE";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnUpdate.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Appearance.Options.UseBackColor = true;
            this.BtnUpdate.Appearance.Options.UseFont = true;
            this.BtnUpdate.Location = new System.Drawing.Point(861, 113);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(231, 45);
            this.BtnUpdate.TabIndex = 81;
            this.BtnUpdate.Text = "UPDATE";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(52, 86);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 27);
            this.labelControl1.TabIndex = 80;
            this.labelControl1.Text = "Location Start";
            // 
            // teLocationStart
            // 
            this.teLocationStart.Location = new System.Drawing.Point(52, 114);
            this.teLocationStart.Margin = new System.Windows.Forms.Padding(4);
            this.teLocationStart.Name = "teLocationStart";
            this.teLocationStart.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLocationStart.Properties.Appearance.Options.UseFont = true;
            this.teLocationStart.Properties.AutoHeight = false;
            this.teLocationStart.Size = new System.Drawing.Size(191, 44);
            this.teLocationStart.TabIndex = 79;
            // 
            // gcLocation
            // 
            this.gcLocation.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcLocation.Location = new System.Drawing.Point(52, 200);
            this.gcLocation.MainView = this.gvLocation;
            this.gcLocation.Margin = new System.Windows.Forms.Padding(4);
            this.gcLocation.MenuManager = this.ribbon;
            this.gcLocation.Name = "gcLocation";
            this.gcLocation.Size = new System.Drawing.Size(1295, 342);
            this.gcLocation.TabIndex = 78;
            this.gcLocation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLocation});
            // 
            // gvLocation
            // 
            this.gvLocation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.LocationID,
            this.LocationStart,
            this.LocationFinish,
            this.Availability});
            this.gvLocation.DetailHeight = 416;
            this.gvLocation.GridControl = this.gcLocation;
            this.gvLocation.Name = "gvLocation";
            this.gvLocation.OptionsEditForm.PopupEditFormWidth = 1029;
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
            this.LocationID.MinWidth = 32;
            this.LocationID.Name = "LocationID";
            this.LocationID.OptionsColumn.AllowEdit = false;
            this.LocationID.Visible = true;
            this.LocationID.VisibleIndex = 0;
            this.LocationID.Width = 353;
            // 
            // LocationStart
            // 
            this.LocationStart.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationStart.AppearanceCell.Options.UseFont = true;
            this.LocationStart.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationStart.AppearanceHeader.Options.UseFont = true;
            this.LocationStart.Caption = "Location Start";
            this.LocationStart.FieldName = "LocationStart";
            this.LocationStart.MinWidth = 32;
            this.LocationStart.Name = "LocationStart";
            this.LocationStart.OptionsColumn.AllowEdit = false;
            this.LocationStart.Visible = true;
            this.LocationStart.VisibleIndex = 1;
            this.LocationStart.Width = 708;
            // 
            // LocationFinish
            // 
            this.LocationFinish.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationFinish.AppearanceCell.Options.UseFont = true;
            this.LocationFinish.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.LocationFinish.AppearanceHeader.Options.UseFont = true;
            this.LocationFinish.Caption = "Location Finish";
            this.LocationFinish.FieldName = "LocationFinish";
            this.LocationFinish.MinWidth = 30;
            this.LocationFinish.Name = "LocationFinish";
            this.LocationFinish.OptionsColumn.AllowEdit = false;
            this.LocationFinish.Visible = true;
            this.LocationFinish.VisibleIndex = 2;
            this.LocationFinish.Width = 671;
            // 
            // Availability
            // 
            this.Availability.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Availability.AppearanceCell.Options.UseFont = true;
            this.Availability.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Availability.AppearanceHeader.Options.UseFont = true;
            this.Availability.Caption = "Availability";
            this.Availability.FieldName = "Availability";
            this.Availability.MinWidth = 30;
            this.Availability.Name = "Availability";
            this.Availability.OptionsColumn.AllowEdit = false;
            this.Availability.Visible = true;
            this.Availability.VisibleIndex = 3;
            this.Availability.Width = 378;
            // 
            // teLocationFinish
            // 
            this.teLocationFinish.Location = new System.Drawing.Point(277, 114);
            this.teLocationFinish.Margin = new System.Windows.Forms.Padding(4);
            this.teLocationFinish.Name = "teLocationFinish";
            this.teLocationFinish.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teLocationFinish.Properties.Appearance.Options.UseFont = true;
            this.teLocationFinish.Properties.AutoHeight = false;
            this.teLocationFinish.Size = new System.Drawing.Size(191, 44);
            this.teLocationFinish.TabIndex = 83;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(277, 86);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(162, 27);
            this.labelControl2.TabIndex = 84;
            this.labelControl2.Text = "Location Finish";
            // 
            // teAvailability
            // 
            this.teAvailability.Location = new System.Drawing.Point(495, 114);
            this.teAvailability.Margin = new System.Windows.Forms.Padding(4);
            this.teAvailability.Name = "teAvailability";
            this.teAvailability.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teAvailability.Properties.Appearance.Options.UseFont = true;
            this.teAvailability.Properties.AutoHeight = false;
            this.teAvailability.Size = new System.Drawing.Size(191, 44);
            this.teAvailability.TabIndex = 85;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(495, 86);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 27);
            this.labelControl3.TabIndex = 86;
            this.labelControl3.Text = "Availability";
            // 
            // ViewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 621);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.teAvailability);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teLocationFinish);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teLocationStart);
            this.Controls.Add(this.gcLocation);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "ViewLocation";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "ViewLocation";
            this.Load += new System.EventHandler(this.ViewLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocationStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocationFinish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAvailability.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teLocationStart;
        private DevExpress.XtraGrid.Columns.GridColumn LocationID;
        private DevExpress.XtraGrid.Columns.GridColumn LocationStart;
        private DevExpress.XtraGrid.Columns.GridColumn LocationFinish;
        private DevExpress.XtraGrid.Columns.GridColumn Availability;
        private DevExpress.XtraEditors.TextEdit teLocationFinish;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teAvailability;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraGrid.GridControl gcLocation;
        public DevExpress.XtraGrid.Views.Grid.GridView gvLocation;
    }
}