namespace InventorySystem.Employees
{
    partial class GridViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridViewEmployee));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcEmployeeView = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CivilStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateHired = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(39, 36, 39, 36);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 424;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1671, 73);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 709);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1671, 55);
            // 
            // gcEmployeeView
            // 
            this.gcEmployeeView.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcEmployeeView.Location = new System.Drawing.Point(32, 159);
            this.gcEmployeeView.MainView = this.gvEmployeeView;
            this.gcEmployeeView.Margin = new System.Windows.Forms.Padding(4);
            this.gcEmployeeView.MenuManager = this.ribbon;
            this.gcEmployeeView.Name = "gcEmployeeView";
            this.gcEmployeeView.Size = new System.Drawing.Size(1606, 528);
            this.gcEmployeeView.TabIndex = 2;
            this.gcEmployeeView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeView});
            // 
            // gvEmployeeView
            // 
            this.gvEmployeeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployeeName,
            this.Gender,
            this.CivilStatus,
            this.DateOfBirth,
            this.Age,
            this.PhoneNumber,
            this.DateHired});
            this.gvEmployeeView.DetailHeight = 416;
            this.gvEmployeeView.GridControl = this.gcEmployeeView;
            this.gvEmployeeView.Name = "gvEmployeeView";
            this.gvEmployeeView.OptionsEditForm.PopupEditFormWidth = 1029;
            this.gvEmployeeView.OptionsView.ShowGroupPanel = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Employee Name";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.MinWidth = 32;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 0;
            this.EmployeeName.Width = 121;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.MinWidth = 32;
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 1;
            this.Gender.Width = 121;
            // 
            // CivilStatus
            // 
            this.CivilStatus.Caption = "Civil Status";
            this.CivilStatus.FieldName = "CivilStatus";
            this.CivilStatus.MinWidth = 30;
            this.CivilStatus.Name = "CivilStatus";
            this.CivilStatus.Visible = true;
            this.CivilStatus.VisibleIndex = 2;
            this.CivilStatus.Width = 96;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Caption = "Date Of Birth";
            this.DateOfBirth.FieldName = "DateOfBirth";
            this.DateOfBirth.MinWidth = 30;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Visible = true;
            this.DateOfBirth.VisibleIndex = 3;
            this.DateOfBirth.Width = 96;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.MinWidth = 30;
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 4;
            this.Age.Width = 96;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "Phone Number";
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.MinWidth = 30;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 5;
            this.PhoneNumber.Width = 96;
            // 
            // DateHired
            // 
            this.DateHired.Caption = "Date Hired";
            this.DateHired.FieldName = "DateHired";
            this.DateHired.MinWidth = 30;
            this.DateHired.Name = "DateHired";
            this.DateHired.Visible = true;
            this.DateHired.VisibleIndex = 6;
            this.DateHired.Width = 96;
            // 
            // teSearch
            // 
            this.teSearch.Location = new System.Drawing.Point(164, 100);
            this.teSearch.Margin = new System.Windows.Forms.Padding(4);
            this.teSearch.Name = "teSearch";
            this.teSearch.Properties.AutoHeight = false;
            this.teSearch.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.teSearch.Size = new System.Drawing.Size(436, 32);
            this.teSearch.TabIndex = 11;
            this.teSearch.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teSearch_EditValueChanging);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(32, 107);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(124, 19);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Search Keyword :";
            // 
            // GridViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 764);
            this.Controls.Add(this.teSearch);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gcEmployeeView);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("GridViewEmployee.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GridViewEmployee";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "GridViewEmployee";
            this.Load += new System.EventHandler(this.GridViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gcEmployeeView;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployeeView;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn Gender;
        private DevExpress.XtraGrid.Columns.GridColumn CivilStatus;
        private DevExpress.XtraGrid.Columns.GridColumn DateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn DateHired;
        private DevExpress.XtraEditors.TextEdit teSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}