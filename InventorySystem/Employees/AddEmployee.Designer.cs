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
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1186, 49);
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
            this.peProfile.Location = new System.Drawing.Point(909, 52);
            this.peProfile.MenuManager = this.ribbon;
            this.peProfile.Name = "peProfile";
            this.peProfile.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peProfile.Properties.Appearance.Options.UseBackColor = true;
            this.peProfile.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peProfile.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.peProfile.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peProfile.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peProfile.Size = new System.Drawing.Size(148, 144);
            this.peProfile.TabIndex = 12;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.btnBrowse.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Appearance.Options.UseBackColor = true;
            this.btnBrowse.Appearance.Options.UseFont = true;
            this.btnBrowse.Location = new System.Drawing.Point(939, 195);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(88, 29);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lueRole
            // 
            this.lueRole.Location = new System.Drawing.Point(553, 299);
            this.lueRole.MenuManager = this.ribbon;
            this.lueRole.Name = "lueRole";
            this.lueRole.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lueRole.Properties.Appearance.Options.UseFont = true;
            this.lueRole.Properties.AutoHeight = false;
            this.lueRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleID", "Role ID", 17, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueRole.Properties.NullText = "";
            this.lueRole.Size = new System.Drawing.Size(205, 28);
            this.lueRole.TabIndex = 19;
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(25, 73);
            this.teFirstName.MenuManager = this.ribbon;
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teFirstName.Properties.Appearance.Options.UseFont = true;
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Size = new System.Drawing.Size(249, 28);
            this.teFirstName.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 16);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "First Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(553, 277);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 16);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Role";
            // 
            // teMiddleName
            // 
            this.teMiddleName.Location = new System.Drawing.Point(291, 75);
            this.teMiddleName.MenuManager = this.ribbon;
            this.teMiddleName.Name = "teMiddleName";
            this.teMiddleName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teMiddleName.Properties.Appearance.Options.UseFont = true;
            this.teMiddleName.Properties.AutoHeight = false;
            this.teMiddleName.Size = new System.Drawing.Size(175, 28);
            this.teMiddleName.TabIndex = 21;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(291, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 16);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Middle Name";
            // 
            // teNameExtension
            // 
            this.teNameExtension.Location = new System.Drawing.Point(680, 75);
            this.teNameExtension.MenuManager = this.ribbon;
            this.teNameExtension.Name = "teNameExtension";
            this.teNameExtension.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teNameExtension.Properties.Appearance.Options.UseFont = true;
            this.teNameExtension.Properties.AutoHeight = false;
            this.teNameExtension.Size = new System.Drawing.Size(100, 28);
            this.teNameExtension.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(682, 51);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 16);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "Name Extension";
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(483, 75);
            this.teLastName.MenuManager = this.ribbon;
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teLastName.Properties.Appearance.Options.UseFont = true;
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Size = new System.Drawing.Size(175, 28);
            this.teLastName.TabIndex = 25;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(483, 51);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 16);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "Last Name";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(553, 217);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 16);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Date of Birth";
            // 
            // deDateOfBirth
            // 
            this.deDateOfBirth.EditValue = null;
            this.deDateOfBirth.Location = new System.Drawing.Point(553, 236);
            this.deDateOfBirth.MenuManager = this.ribbon;
            this.deDateOfBirth.Name = "deDateOfBirth";
            this.deDateOfBirth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.deDateOfBirth.Properties.Appearance.Options.UseFont = true;
            this.deDateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateOfBirth.Size = new System.Drawing.Size(205, 30);
            this.deDateOfBirth.TabIndex = 29;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(63, 343);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 16);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "Address";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseBackColor = true;
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(32, 485);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(205, 31);
            this.BtnSubmit.TabIndex = 32;
            this.BtnSubmit.Text = "SUBMIT";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // meEmployeeImagePath
            // 
            this.meEmployeeImagePath.Location = new System.Drawing.Point(871, 263);
            this.meEmployeeImagePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.meEmployeeImagePath.MenuManager = this.ribbon;
            this.meEmployeeImagePath.Name = "meEmployeeImagePath";
            this.meEmployeeImagePath.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.meEmployeeImagePath.Properties.Appearance.Options.UseFont = true;
            this.meEmployeeImagePath.Size = new System.Drawing.Size(231, 78);
            this.meEmployeeImagePath.TabIndex = 34;
            this.meEmployeeImagePath.Visible = false;
            // 
            // rdGender
            // 
            this.rdGender.Location = new System.Drawing.Point(65, 231);
            this.rdGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.rdGender.Size = new System.Drawing.Size(160, 35);
            this.rdGender.TabIndex = 36;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(65, 210);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 16);
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
            this.groupControl1.Location = new System.Drawing.Point(39, 52);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(801, 129);
            this.groupControl1.TabIndex = 39;
            this.groupControl1.Text = "Employee Name";
            // 
            // mmAddress
            // 
            this.mmAddress.Location = new System.Drawing.Point(63, 371);
            this.mmAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mmAddress.MenuManager = this.ribbon;
            this.mmAddress.Name = "mmAddress";
            this.mmAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.mmAddress.Properties.Appearance.Options.UseFont = true;
            this.mmAddress.Size = new System.Drawing.Size(717, 31);
            this.mmAddress.TabIndex = 40;
            // 
            // deDateHired
            // 
            this.deDateHired.EditValue = null;
            this.deDateHired.Location = new System.Drawing.Point(303, 299);
            this.deDateHired.MenuManager = this.ribbon;
            this.deDateHired.Name = "deDateHired";
            this.deDateHired.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.deDateHired.Properties.Appearance.Options.UseFont = true;
            this.deDateHired.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateHired.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDateHired.Size = new System.Drawing.Size(205, 30);
            this.deDateHired.TabIndex = 41;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(305, 277);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 16);
            this.labelControl9.TabIndex = 42;
            this.labelControl9.Text = "Date Hired";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(305, 217);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(63, 16);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "Civil Status";
            // 
            // cbCivilStatus
            // 
            this.cbCivilStatus.Location = new System.Drawing.Point(303, 238);
            this.cbCivilStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCivilStatus.MenuManager = this.ribbon;
            this.cbCivilStatus.Name = "cbCivilStatus";
            this.cbCivilStatus.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cbCivilStatus.Properties.Appearance.Options.UseFont = true;
            this.cbCivilStatus.Properties.AutoHeight = false;
            this.cbCivilStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCivilStatus.Properties.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Widowed",
            "Separated",
            ""});
            this.cbCivilStatus.Size = new System.Drawing.Size(205, 28);
            this.cbCivilStatus.TabIndex = 44;
            // 
            // tePhoneNumber
            // 
            this.tePhoneNumber.Location = new System.Drawing.Point(65, 299);
            this.tePhoneNumber.MenuManager = this.ribbon;
            this.tePhoneNumber.Name = "tePhoneNumber";
            this.tePhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tePhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.tePhoneNumber.Properties.AutoHeight = false;
            this.tePhoneNumber.Size = new System.Drawing.Size(207, 28);
            this.tePhoneNumber.TabIndex = 45;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(65, 277);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(84, 16);
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
            this.groupControl2.Location = new System.Drawing.Point(32, 51);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1122, 418);
            this.groupControl2.TabIndex = 48;
            this.groupControl2.Text = "Employee Data";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl2_Paint);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 591);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddEmployee.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmployee";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Add Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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