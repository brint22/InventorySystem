namespace InventorySystem.Employees
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.peProfile = new DevExpress.XtraEditors.PictureEdit();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.lueRole = new DevExpress.XtraEditors.LookUpEdit();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teMiddleName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teNameExtension = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.deDateOfBirth = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.meEmployeeImagePath = new DevExpress.XtraEditors.MemoEdit();
            this.rdGender = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mmAddress = new DevExpress.XtraEditors.MemoEdit();
            this.deDateHired = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.cbCivilStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tePhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peProfile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNameExtension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meEmployeeImagePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateHired.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateHired.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCivilStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
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
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1427, 61);
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
            // peProfile
            // 
            this.peProfile.EditValue = ((object)(resources.GetObject("peProfile.EditValue")));
            this.peProfile.Location = new System.Drawing.Point(1060, 64);
            this.peProfile.Margin = new System.Windows.Forms.Padding(4);
            this.peProfile.MenuManager = this.ribbon;
            this.peProfile.Name = "peProfile";
            this.peProfile.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peProfile.Properties.Appearance.Options.UseBackColor = true;
            this.peProfile.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peProfile.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.peProfile.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peProfile.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peProfile.Size = new System.Drawing.Size(173, 177);
            this.peProfile.TabIndex = 12;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Appearance.Options.UseBackColor = true;
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Location = new System.Drawing.Point(1095, 240);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(103, 36);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lueRole
            // 
            this.lueRole.Location = new System.Drawing.Point(645, 368);
            this.lueRole.Margin = new System.Windows.Forms.Padding(4);
            this.lueRole.MenuManager = this.ribbon;
            this.lueRole.Name = "lueRole";
            this.lueRole.Properties.AutoHeight = false;
            this.lueRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleID", "RoleID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "RoleName", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueRole.Properties.NullText = "";
            this.lueRole.Size = new System.Drawing.Size(239, 34);
            this.lueRole.TabIndex = 19;
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(29, 90);
            this.teFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.teFirstName.MenuManager = this.ribbon;
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Size = new System.Drawing.Size(290, 35);
            this.teFirstName.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(29, 61);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 19);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "First Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(645, 341);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 19);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Role";
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(339, 92);
            this.teMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.teMiddleName.MenuManager = this.ribbon;
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.AutoHeight = false;
            this.teMiddleName.Size = new System.Drawing.Size(204, 35);
            this.teMiddleName.TabIndex = 21;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(339, 61);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 19);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Middle Name";
            // 
            // teNameExtension
            // 
            this.teNameExtension.Location = new System.Drawing.Point(793, 92);
            this.teNameExtension.Margin = new System.Windows.Forms.Padding(4);
            this.teNameExtension.MenuManager = this.ribbon;
            this.teNameExtension.Name = "teNameExtension";
            this.teNameExtension.Properties.AutoHeight = false;
            this.teNameExtension.Size = new System.Drawing.Size(117, 35);
            this.teNameExtension.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(796, 63);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(114, 19);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Name Extension";
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(563, 92);
            this.teLastName.Margin = new System.Windows.Forms.Padding(4);
            this.teLastName.MenuManager = this.ribbon;
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Size = new System.Drawing.Size(204, 35);
            this.teLastName.TabIndex = 25;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(563, 63);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 19);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Last Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(645, 267);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(89, 19);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Date of Birth";
            // 
            // deDateOfBirth
            // 
            this.deDateOfBirth.EditValue = null;
            this.deDateOfBirth.Location = new System.Drawing.Point(645, 291);
            this.deDateOfBirth.Margin = new System.Windows.Forms.Padding(4);
            this.deDateOfBirth.MenuManager = this.ribbon;
            this.deDateOfBirth.Name = "deDateOfBirth";
            this.deDateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Size = new System.Drawing.Size(239, 34);
            this.deDateOfBirth.TabIndex = 29;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(74, 422);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 19);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Address";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseBackColor = true;
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(62, 664);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(239, 38);
            this.BtnSubmit.TabIndex = 32;
            this.BtnSubmit.Text = "SUBMIT";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // meEmployeeImagePath
            // 
            this.meEmployeeImagePath.Location = new System.Drawing.Point(1016, 324);
            this.meEmployeeImagePath.MenuManager = this.ribbon;
            this.meEmployeeImagePath.Name = "meEmployeeImagePath";
            this.meEmployeeImagePath.Size = new System.Drawing.Size(270, 96);
            this.meEmployeeImagePath.TabIndex = 34;
            this.meEmployeeImagePath.Visible = false;
            // 
            // rdGender
            // 
            this.rdGender.Location = new System.Drawing.Point(76, 284);
            this.rdGender.MenuManager = this.ribbon;
            this.rdGender.Name = "rdGender";
            this.rdGender.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdGender.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdGender.Properties.Appearance.Options.UseBackColor = true;
            this.rdGender.Properties.Appearance.Options.UseFont = true;
            this.rdGender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdGender.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Male"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Female")});
            this.rdGender.Size = new System.Drawing.Size(187, 43);
            this.rdGender.TabIndex = 36;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(76, 258);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(51, 19);
            this.labelControl8.TabIndex = 37;
            this.labelControl8.Text = "Gender";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.teNameExtension);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.teLastName);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.teFirstName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.teMiddleName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(45, 64);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(935, 159);
            this.groupControl1.TabIndex = 39;
            this.groupControl1.Text = "Employee Name";
            // 
            // mmAddress
            // 
            this.mmAddress.Location = new System.Drawing.Point(74, 457);
            this.mmAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mmAddress.MenuManager = this.ribbon;
            this.mmAddress.Name = "mmAddress";
            this.mmAddress.Size = new System.Drawing.Size(836, 70);
            this.mmAddress.TabIndex = 40;
            // 
            // deDateHired
            // 
            this.deDateHired.EditValue = null;
            this.deDateHired.Location = new System.Drawing.Point(353, 368);
            this.deDateHired.Margin = new System.Windows.Forms.Padding(4);
            this.deDateHired.MenuManager = this.ribbon;
            this.deDateHired.Name = "deDateHired";
            this.deDateHired.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateHired.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateHired.Size = new System.Drawing.Size(239, 34);
            this.deDateHired.TabIndex = 41;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(356, 341);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(75, 19);
            this.labelControl9.TabIndex = 42;
            this.labelControl9.Text = "Date Hired";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(356, 267);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(78, 19);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "Civil Status";
            // 
            // cbCivilStatus
            // 
            this.cbCivilStatus.Location = new System.Drawing.Point(353, 293);
            this.cbCivilStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbCivilStatus.MenuManager = this.ribbon;
            this.cbCivilStatus.Name = "cbCivilStatus";
            this.cbCivilStatus.Properties.AutoHeight = false;
            this.cbCivilStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCivilStatus.Properties.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Separated",
            ""});
            this.cbCivilStatus.Size = new System.Drawing.Size(239, 34);
            this.cbCivilStatus.TabIndex = 44;
            // 
            // tePhoneNumber
            // 
            this.tePhoneNumber.Location = new System.Drawing.Point(76, 368);
            this.tePhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tePhoneNumber.MenuManager = this.ribbon;
            this.tePhoneNumber.Name = "tePhoneNumber";
            this.tePhoneNumber.Properties.AutoHeight = false;
            this.tePhoneNumber.Size = new System.Drawing.Size(241, 35);
            this.tePhoneNumber.TabIndex = 45;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(76, 341);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(106, 19);
            this.labelControl11.TabIndex = 46;
            this.labelControl11.Text = "Phone Number";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.meEmployeeImagePath);
            this.groupControl2.Controls.Add(this.peProfile);
            this.groupControl2.Controls.Add(this.mmAddress);
            this.groupControl2.Controls.Add(this.btnBrowse);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.cbCivilStatus);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.groupControl1);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.deDateOfBirth);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.tePhoneNumber);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.lueRole);
            this.groupControl2.Controls.Add(this.deDateHired);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.rdGender);
            this.groupControl2.Location = new System.Drawing.Point(62, 103);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1309, 542);
            this.groupControl2.TabIndex = 48;
            this.groupControl2.Text = "Employee Data";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 727);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddEmployee.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Add Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peProfile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMiddleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNameExtension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meEmployeeImagePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateHired.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDateHired.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCivilStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PictureEdit peProfile;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.LookUpEdit lueRole;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teMiddleName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teNameExtension;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.DateEdit deDateOfBirth;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.MemoEdit meEmployeeImagePath;
        private DevExpress.XtraEditors.RadioGroup rdGender;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit mmAddress;
        private DevExpress.XtraEditors.DateEdit deDateHired;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.ComboBoxEdit cbCivilStatus;
        private DevExpress.XtraEditors.TextEdit tePhoneNumber;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}