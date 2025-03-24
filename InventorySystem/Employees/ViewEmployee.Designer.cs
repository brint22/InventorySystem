namespace InventorySystem.Employees
{
    partial class ViewEmployee
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
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition4 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition4 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition5 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition6 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition7 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan2 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan3 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement5 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement6 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.ImageData = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.RoleName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.Address = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.DateOfBirth = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.tvEmployee = new DevExpress.XtraGrid.Views.Tile.TileView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageData
            // 
            this.ImageData.Caption = "Employee Image";
            this.ImageData.FieldName = "ImageData";
            this.ImageData.Name = "ImageData";
            this.ImageData.Visible = true;
            this.ImageData.VisibleIndex = 3;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Employee Name";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 1;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.OptionsColumn.ShowCaption = true;
            this.EmployeeID.Visible = true;
            this.EmployeeID.VisibleIndex = 0;
            // 
            // RoleName
            // 
            this.RoleName.Caption = "Employee Role";
            this.RoleName.FieldName = "RoleName";
            this.RoleName.MinWidth = 15;
            this.RoleName.Name = "RoleName";
            this.RoleName.OptionsColumn.ShowCaption = true;
            this.RoleName.Visible = true;
            this.RoleName.VisibleIndex = 2;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 21;
            this.Address.Name = "Address";
            this.Address.OptionsColumn.ShowCaption = true;
            this.Address.Visible = true;
            this.Address.VisibleIndex = 5;
            this.Address.Width = 81;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Caption = "Date of Birth";
            this.DateOfBirth.FieldName = "DateOfBirth";
            this.DateOfBirth.MinWidth = 21;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.OptionsColumn.ShowCaption = true;
            this.DateOfBirth.Visible = true;
            this.DateOfBirth.VisibleIndex = 4;
            this.DateOfBirth.Width = 81;
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
            this.ribbon.Size = new System.Drawing.Size(864, 49);
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
            // gcEmployee
            // 
            this.gcEmployee.Location = new System.Drawing.Point(89, 88);
            this.gcEmployee.MainView = this.tvEmployee;
            this.gcEmployee.MenuManager = this.ribbon;
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.Size = new System.Drawing.Size(688, 337);
            this.gcEmployee.TabIndex = 2;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvEmployee});
            // 
            // tvEmployee
            // 
            this.tvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.DateOfBirth,
            this.Address,
            this.RoleName,
            this.ImageData});
            this.tvEmployee.GridControl = this.gcEmployee;
            this.tvEmployee.Name = "tvEmployee";
            this.tvEmployee.OptionsEditForm.AllowHtmlCaptions = true;
            this.tvEmployee.OptionsTiles.ItemSize = new System.Drawing.Size(495, 500);
            this.tvEmployee.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tvEmployee.OptionsTiles.RowCount = 0;
            this.tvEmployee.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            tableColumnDefinition1.Length.Value = 56D;
            tableColumnDefinition2.Length.Value = 115D;
            tableColumnDefinition3.Length.Value = 0D;
            tableColumnDefinition4.Length.Value = 56D;
            this.tvEmployee.TileColumns.Add(tableColumnDefinition1);
            this.tvEmployee.TileColumns.Add(tableColumnDefinition2);
            this.tvEmployee.TileColumns.Add(tableColumnDefinition3);
            this.tvEmployee.TileColumns.Add(tableColumnDefinition4);
            tableRowDefinition1.Length.Value = 116D;
            tableRowDefinition2.Length.Value = 0D;
            tableRowDefinition3.Length.Value = 57D;
            tableRowDefinition4.Length.Value = 36D;
            tableRowDefinition5.Length.Value = 35D;
            tableRowDefinition6.Length.Value = 36D;
            tableRowDefinition7.Length.Value = 36D;
            this.tvEmployee.TileRows.Add(tableRowDefinition1);
            this.tvEmployee.TileRows.Add(tableRowDefinition2);
            this.tvEmployee.TileRows.Add(tableRowDefinition3);
            this.tvEmployee.TileRows.Add(tableRowDefinition4);
            this.tvEmployee.TileRows.Add(tableRowDefinition5);
            this.tvEmployee.TileRows.Add(tableRowDefinition6);
            this.tvEmployee.TileRows.Add(tableRowDefinition7);
            tableSpan1.ColumnSpan = 4;
            tableSpan1.RowIndex = 2;
            tableSpan2.ColumnSpan = 4;
            tableSpan2.RowIndex = 5;
            tableSpan3.ColumnSpan = 4;
            tableSpan3.RowIndex = 4;
            this.tvEmployee.TileSpans.Add(tableSpan1);
            this.tvEmployee.TileSpans.Add(tableSpan2);
            this.tvEmployee.TileSpans.Add(tableSpan3);
            tileViewItemElement1.Column = this.ImageData;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "EmployeeImage";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.EmployeeName;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 2;
            tileViewItemElement2.Text = "EmployeeName";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.EmployeeID;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 3;
            tileViewItemElement3.Text = "EmployeeID";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.RoleName;
            tileViewItemElement4.ColumnIndex = 1;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.RowIndex = 6;
            tileViewItemElement4.Text = "RoleName";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.Column = this.Address;
            tileViewItemElement5.ColumnIndex = 1;
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.RowIndex = 5;
            tileViewItemElement5.Text = "Address";
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.Column = this.DateOfBirth;
            tileViewItemElement6.ColumnIndex = 1;
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement6.RowIndex = 4;
            tileViewItemElement6.Text = "DateOfBirth";
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tvEmployee.TileTemplate.Add(tileViewItemElement1);
            this.tvEmployee.TileTemplate.Add(tileViewItemElement2);
            this.tvEmployee.TileTemplate.Add(tileViewItemElement3);
            this.tvEmployee.TileTemplate.Add(tileViewItemElement4);
            this.tvEmployee.TileTemplate.Add(tileViewItemElement5);
            this.tvEmployee.TileTemplate.Add(tileViewItemElement6);
            // 
            // ViewEmployee
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.gcEmployee);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ViewEmployee.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewEmployee";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | View Employee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Tile.TileView tvEmployee;
        private DevExpress.XtraGrid.Columns.TileViewColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.TileViewColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.TileViewColumn DateOfBirth;
        private DevExpress.XtraGrid.Columns.TileViewColumn Address;
        private DevExpress.XtraGrid.Columns.TileViewColumn RoleName;
        private DevExpress.XtraGrid.Columns.TileViewColumn ImageData;
    }
}