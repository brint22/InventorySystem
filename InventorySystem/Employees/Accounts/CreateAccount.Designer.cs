namespace InventorySystem.Account
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcAccounts = new DevExpress.XtraGrid.GridControl();
            this.gvAccounts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
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
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.Size = new System.Drawing.Size(705, 61);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(320, 259);
            this.tePassword.Margin = new System.Windows.Forms.Padding(4);
            this.tePassword.MenuManager = this.ribbon;
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Size = new System.Drawing.Size(326, 39);
            this.tePassword.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(320, 232);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 19);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Password";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.gcAccounts);
            this.groupControl1.Controls.Add(this.teUserName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tePassword);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(14, 78);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(677, 323);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "groupControl1";
            // 
            // gcAccounts
            // 
            this.gcAccounts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcAccounts.Location = new System.Drawing.Point(28, 32);
            this.gcAccounts.MainView = this.gvAccounts;
            this.gcAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.gcAccounts.MenuManager = this.ribbon;
            this.gcAccounts.Name = "gcAccounts";
            this.gcAccounts.Size = new System.Drawing.Size(618, 172);
            this.gcAccounts.TabIndex = 16;
            this.gcAccounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAccounts});
            // 
            // gvAccounts
            // 
            this.gvAccounts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.RoleName});
            this.gvAccounts.DetailHeight = 431;
            this.gvAccounts.GridControl = this.gcAccounts;
            this.gvAccounts.Name = "gvAccounts";
            this.gvAccounts.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Caption = "EmployeeID";
            this.EmployeeID.FieldName = "EmployeeID";
            this.EmployeeID.MinWidth = 23;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.OptionsColumn.AllowEdit = false;
            this.EmployeeID.OptionsColumn.AllowFocus = false;
            this.EmployeeID.Visible = true;
            this.EmployeeID.VisibleIndex = 0;
            this.EmployeeID.Width = 87;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Caption = "Employee Name";
            this.EmployeeName.FieldName = "EmployeeName";
            this.EmployeeName.MinWidth = 23;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.OptionsColumn.AllowEdit = false;
            this.EmployeeName.OptionsColumn.AllowFocus = false;
            this.EmployeeName.Visible = true;
            this.EmployeeName.VisibleIndex = 1;
            this.EmployeeName.Width = 87;
            // 
            // RoleName
            // 
            this.RoleName.Caption = "Role Name";
            this.RoleName.FieldName = "RoleName";
            this.RoleName.MinWidth = 23;
            this.RoleName.Name = "RoleName";
            this.RoleName.OptionsColumn.AllowEdit = false;
            this.RoleName.OptionsColumn.AllowFocus = false;
            this.RoleName.Visible = true;
            this.RoleName.VisibleIndex = 2;
            this.RoleName.Width = 87;
            // 
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(28, 256);
            this.teUserName.Margin = new System.Windows.Forms.Padding(4);
            this.teUserName.MenuManager = this.ribbon;
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Properties.ReadOnly = true;
            this.teUserName.Size = new System.Drawing.Size(261, 42);
            this.teUserName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 229);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 19);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Username";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(348, 450);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(239, 38);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Text = "CANCEL";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Appearance.Options.UseBackColor = true;
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.Location = new System.Drawing.Point(91, 450);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(240, 38);
            this.btnSubmit.TabIndex = 66;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CreateAccount
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 578);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("CreateAccount.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateAccount";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcAccounts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAccounts;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn EmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn RoleName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
    }
}