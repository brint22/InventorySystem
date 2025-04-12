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
            this.gcEmployeeView = new DevExpress.XtraGrid.GridControl();
            this.gvEmployeeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CivilStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateHired = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teSearch = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.EmployeeRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeRole.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(1306, 61);
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
            // gcEmployeeView
            // 
            this.gcEmployeeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEmployeeView.Location = new System.Drawing.Point(25, 144);
            this.gcEmployeeView.MainView = this.gvEmployeeView;
            this.gcEmployeeView.MenuManager = this.ribbon;
            this.gcEmployeeView.Name = "gcEmployeeView";
            this.gcEmployeeView.Size = new System.Drawing.Size(1249, 373);
            this.gcEmployeeView.TabIndex = 2;
            this.gcEmployeeView.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployeeView});
            // 
            // gvEmployeeView
            // 
            this.gvEmployeeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.Gender,
            this.CivilStatus,
            this.DateOfBirth,
            this.Age,
            this.PhoneNumber,
            this.RoleName,
            this.DateHired,
            this.Address});
            this.gvEmployeeView.GridControl = this.gcEmployeeView;
            this.gvEmployeeView.Name = "gvEmployeeView";
            this.gvEmployeeView.OptionsView.ShowGroupPanel = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.MinWidth = 25;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Visible = true;
            this.EmployeeID.VisibleIndex = 0;
            this.EmployeeID.Width = 97;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Employee Name";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.MinWidth = 25;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 1;
            this.EmployeeName.Width = 152;
            // 
            // Gender
            // 
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.MinWidth = 25;
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 2;
            this.Gender.Width = 83;
            // 
            // CivilStatus
            // 
            this.CivilStatus.Caption = "Civil Status";
            this.CivilStatus.FieldName = "CivilStatus";
            this.CivilStatus.MinWidth = 23;
            this.CivilStatus.Name = "CivilStatus";
            this.CivilStatus.Visible = true;
            this.CivilStatus.VisibleIndex = 3;
            this.CivilStatus.Width = 97;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Caption = "Date of Birth";
            this.DateOfBirth.FieldName = "DateOfBirth";
            this.DateOfBirth.MinWidth = 23;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Visible = true;
            this.DateOfBirth.VisibleIndex = 4;
            this.DateOfBirth.Width = 101;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.MinWidth = 23;
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 5;
            this.Age.Width = 82;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Caption = "Phone Number";
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.MinWidth = 23;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 6;
            this.PhoneNumber.Width = 123;
            // 
            // RoleName
            // 
            this.RoleName.Caption = "Role";
            this.RoleName.FieldName = "RoleName";
            this.RoleName.MinWidth = 25;
            this.RoleName.Name = "RoleName";
            this.RoleName.Visible = true;
            this.RoleName.VisibleIndex = 7;
            this.RoleName.Width = 93;
            // 
            // DateHired
            // 
            this.DateHired.Caption = "Date Hired";
            this.DateHired.FieldName = "DateHired";
            this.DateHired.MinWidth = 23;
            this.DateHired.Name = "DateHired";
            this.DateHired.Visible = true;
            this.DateHired.VisibleIndex = 8;
            this.DateHired.Width = 109;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 25;
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 9;
            this.Address.Width = 273;
            // 
            // teSearch
            // 
            this.teSearch.Location = new System.Drawing.Point(149, 81);
            this.teSearch.Name = "teSearch";
            this.teSearch.Properties.AutoHeight = false;
            this.teSearch.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.teSearch.Size = new System.Drawing.Size(339, 38);
            this.teSearch.TabIndex = 11;
            this.teSearch.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teSearch_EditValueChanging);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Search Keyword :";
            // 
            // EmployeeRole
            // 
            this.EmployeeRole.EditValue = "Employee Role";
            this.EmployeeRole.Location = new System.Drawing.Point(494, 81);
            this.EmployeeRole.MenuManager = this.ribbon;
            this.EmployeeRole.Name = "EmployeeRole";
            this.EmployeeRole.Properties.AutoHeight = false;
            this.EmployeeRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EmployeeRole.Properties.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.EmployeeRole.Size = new System.Drawing.Size(217, 41);
            this.EmployeeRole.TabIndex = 14;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseBackColor = true;
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(1035, 81);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(239, 38);
            this.BtnSubmit.TabIndex = 64;
            this.BtnSubmit.Text = "GENERATE REPORT";
            // 
            // GridViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 643);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.EmployeeRole);
            this.Controls.Add(this.teSearch);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gcEmployeeView);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("GridViewEmployee.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GridViewEmployee";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridViewEmployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GridViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeRole.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
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
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn RoleName;
        private DevExpress.XtraEditors.ComboBoxEdit EmployeeRole;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
    }
}