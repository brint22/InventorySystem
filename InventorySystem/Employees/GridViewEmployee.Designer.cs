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
            this.cbEmployeeRole = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnGenerateReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEmployeeRole.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(39, 36, 39, 36);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 424;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1679, 73);
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
            this.gcEmployeeView.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcEmployeeView.Location = new System.Drawing.Point(32, 186);
            this.gcEmployeeView.MainView = this.gvEmployeeView;
            this.gcEmployeeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcEmployeeView.MenuManager = this.ribbon;
            this.gcEmployeeView.Name = "gcEmployeeView";
            this.gcEmployeeView.Size = new System.Drawing.Size(1606, 443);
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
            this.gvEmployeeView.DetailHeight = 416;
            this.gvEmployeeView.GridControl = this.gcEmployeeView;
            this.gvEmployeeView.Name = "gvEmployeeView";
            this.gvEmployeeView.OptionsEditForm.PopupEditFormWidth = 1029;
            this.gvEmployeeView.OptionsView.ShowGroupPanel = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.EmployeeID.AppearanceCell.Options.UseFont = true;
            this.EmployeeID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.EmployeeID.AppearanceHeader.Options.UseFont = true;
            this.EmployeeID.Caption = "Employee ID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.MinWidth = 32;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Visible = true;
            this.EmployeeID.VisibleIndex = 0;
            this.EmployeeID.Width = 125;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.EmployeeName.AppearanceCell.Options.UseFont = true;
            this.EmployeeName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.EmployeeName.AppearanceHeader.Options.UseFont = true;
            this.EmployeeName.Caption = "Employee Name";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.MinWidth = 32;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 1;
            this.EmployeeName.Width = 195;
            // 
            // Gender
            // 
            this.Gender.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Gender.AppearanceCell.Options.UseFont = true;
            this.Gender.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Gender.AppearanceHeader.Options.UseFont = true;
            this.Gender.Caption = "Gender";
            this.Gender.FieldName = "Gender";
            this.Gender.MinWidth = 32;
            this.Gender.Name = "Gender";
            this.Gender.Visible = true;
            this.Gender.VisibleIndex = 2;
            this.Gender.Width = 107;
            // 
            // CivilStatus
            // 
            this.CivilStatus.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.CivilStatus.AppearanceCell.Options.UseFont = true;
            this.CivilStatus.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.CivilStatus.AppearanceHeader.Options.UseFont = true;
            this.CivilStatus.Caption = "Civil Status";
            this.CivilStatus.FieldName = "CivilStatus";
            this.CivilStatus.MinWidth = 30;
            this.CivilStatus.Name = "CivilStatus";
            this.CivilStatus.Visible = true;
            this.CivilStatus.VisibleIndex = 3;
            this.CivilStatus.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.DateOfBirth.AppearanceCell.Options.UseFont = true;
            this.DateOfBirth.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.DateOfBirth.AppearanceHeader.Options.UseFont = true;
            this.DateOfBirth.Caption = "Date of Birth";
            this.DateOfBirth.FieldName = "DateOfBirth";
            this.DateOfBirth.MinWidth = 30;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Visible = true;
            this.DateOfBirth.VisibleIndex = 4;
            this.DateOfBirth.Width = 130;
            // 
            // Age
            // 
            this.Age.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Age.AppearanceCell.Options.UseFont = true;
            this.Age.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Age.AppearanceHeader.Options.UseFont = true;
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.MinWidth = 30;
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 5;
            this.Age.Width = 105;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.PhoneNumber.AppearanceCell.Options.UseFont = true;
            this.PhoneNumber.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.PhoneNumber.AppearanceHeader.Options.UseFont = true;
            this.PhoneNumber.Caption = "Phone Number";
            this.PhoneNumber.FieldName = "PhoneNumber";
            this.PhoneNumber.MinWidth = 30;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = true;
            this.PhoneNumber.VisibleIndex = 6;
            this.PhoneNumber.Width = 158;
            // 
            // RoleName
            // 
            this.RoleName.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.RoleName.AppearanceCell.Options.UseFont = true;
            this.RoleName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.RoleName.AppearanceHeader.Options.UseFont = true;
            this.RoleName.Caption = "Role";
            this.RoleName.FieldName = "RoleName";
            this.RoleName.MinWidth = 32;
            this.RoleName.Name = "RoleName";
            this.RoleName.Visible = true;
            this.RoleName.VisibleIndex = 7;
            this.RoleName.Width = 120;
            // 
            // DateHired
            // 
            this.DateHired.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.DateHired.AppearanceCell.Options.UseFont = true;
            this.DateHired.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.DateHired.AppearanceHeader.Options.UseFont = true;
            this.DateHired.Caption = "Date Hired";
            this.DateHired.FieldName = "DateHired";
            this.DateHired.MinWidth = 30;
            this.DateHired.Name = "DateHired";
            this.DateHired.Visible = true;
            this.DateHired.VisibleIndex = 8;
            this.DateHired.Width = 140;
            // 
            // Address
            // 
            this.Address.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Address.AppearanceCell.Options.UseFont = true;
            this.Address.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F);
            this.Address.AppearanceHeader.Options.UseFont = true;
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 32;
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 9;
            this.Address.Width = 351;
            // 
            // teSearch
            // 
            this.teSearch.Location = new System.Drawing.Point(210, 110);
            this.teSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teSearch.Name = "teSearch";
            this.teSearch.Properties.AutoHeight = false;
            this.teSearch.Properties.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.teSearch.Size = new System.Drawing.Size(436, 45);
            this.teSearch.TabIndex = 11;
            this.teSearch.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.teSearch_EditValueChanging);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(32, 124);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(152, 23);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Search Keyword:";
            // 
            // cbEmployeeRole
            // 
            this.cbEmployeeRole.EditValue = "Role";
            this.cbEmployeeRole.Location = new System.Drawing.Point(653, 110);
            this.cbEmployeeRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEmployeeRole.MenuManager = this.ribbon;
            this.cbEmployeeRole.Name = "cbEmployeeRole";
            this.cbEmployeeRole.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployeeRole.Properties.Appearance.Options.UseFont = true;
            this.cbEmployeeRole.Properties.AutoHeight = false;
            this.cbEmployeeRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEmployeeRole.Properties.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cbEmployeeRole.Size = new System.Drawing.Size(279, 49);
            this.cbEmployeeRole.TabIndex = 14;
            this.cbEmployeeRole.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeRole_SelectedIndexChanged);
            // 
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGenerateReport.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnGenerateReport.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateReport.Appearance.Options.UseBackColor = true;
            this.BtnGenerateReport.Appearance.Options.UseFont = true;
            this.BtnGenerateReport.Location = new System.Drawing.Point(1331, 110);
            this.BtnGenerateReport.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Size = new System.Drawing.Size(307, 45);
            this.BtnGenerateReport.TabIndex = 64;
            this.BtnGenerateReport.Text = "GENERATE REPORT";
            this.BtnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // GridViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1679, 764);
            this.Controls.Add(this.BtnGenerateReport);
            this.Controls.Add(this.cbEmployeeRole);
            this.Controls.Add(this.teSearch);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.gcEmployeeView);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("GridViewEmployee.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.cbEmployeeRole.Properties)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit cbEmployeeRole;
        private DevExpress.XtraEditors.SimpleButton BtnGenerateReport;
    }
}