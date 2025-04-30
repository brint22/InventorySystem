namespace InventorySystem.Products
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teProductName = new DevExpress.XtraEditors.TextEdit();
            this.lueCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deExpirationDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.teBrandName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teSupplier = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbLocationGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbLocation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.numericChartRangeControlClient1 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocationGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(39, 36, 39, 36);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 424;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1167, 73);
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(44, 69);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 24);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Product Name";
            // 
            // teProductName
            // 
            this.teProductName.Location = new System.Drawing.Point(44, 97);
            this.teProductName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.teProductName.MenuManager = this.ribbon;
            this.teProductName.Name = "teProductName";
            this.teProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teProductName.Properties.Appearance.Options.UseFont = true;
            this.teProductName.Properties.AutoHeight = false;
            this.teProductName.Size = new System.Drawing.Size(296, 40);
            this.teProductName.TabIndex = 21;
            // 
            // lueCategory
            // 
            this.lueCategory.Location = new System.Drawing.Point(512, 97);
            this.lueCategory.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lueCategory.MenuManager = this.ribbon;
            this.lueCategory.Name = "lueCategory";
            this.lueCategory.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lueCategory.Properties.Appearance.Options.UseFont = true;
            this.lueCategory.Properties.AutoHeight = false;
            this.lueCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryID", "", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueCategory.Properties.NullText = "";
            this.lueCategory.Size = new System.Drawing.Size(296, 40);
            this.lueCategory.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(512, 69);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 24);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Category";
            // 
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(44, 190);
            this.tePrice.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tePrice.MenuManager = this.ribbon;
            this.tePrice.Name = "tePrice";
            this.tePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tePrice.Properties.Appearance.Options.UseFont = true;
            this.tePrice.Properties.AutoHeight = false;
            this.tePrice.Size = new System.Drawing.Size(296, 40);
            this.tePrice.TabIndex = 25;
            this.tePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tePrice_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(44, 160);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 24);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Price";
            // 
            // teQuantity
            // 
            this.teQuantity.Location = new System.Drawing.Point(44, 296);
            this.teQuantity.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.teQuantity.MenuManager = this.ribbon;
            this.teQuantity.Name = "teQuantity";
            this.teQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teQuantity.Properties.Appearance.Options.UseFont = true;
            this.teQuantity.Properties.AutoHeight = false;
            this.teQuantity.Size = new System.Drawing.Size(296, 40);
            this.teQuantity.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(44, 261);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 24);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Quantity";
            // 
            // deExpirationDate
            // 
            this.deExpirationDate.EditValue = null;
            this.deExpirationDate.Location = new System.Drawing.Point(44, 381);
            this.deExpirationDate.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.deExpirationDate.MenuManager = this.ribbon;
            this.deExpirationDate.Name = "deExpirationDate";
            this.deExpirationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExpirationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExpirationDate.Size = new System.Drawing.Size(296, 40);
            this.deExpirationDate.TabIndex = 28;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(44, 353);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(138, 24);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Expiration Date";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(577, 582);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(373, 45);
            this.BtnCancel.TabIndex = 67;
            this.BtnCancel.Text = "CANCEL";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseBackColor = true;
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(172, 582);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(375, 45);
            this.BtnSubmit.TabIndex = 66;
            this.BtnSubmit.Text = "SUBMIT";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // teBrandName
            // 
            this.teBrandName.Location = new System.Drawing.Point(512, 296);
            this.teBrandName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.teBrandName.MenuManager = this.ribbon;
            this.teBrandName.Name = "teBrandName";
            this.teBrandName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teBrandName.Properties.Appearance.Options.UseFont = true;
            this.teBrandName.Properties.AutoHeight = false;
            this.teBrandName.Size = new System.Drawing.Size(296, 40);
            this.teBrandName.TabIndex = 69;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(512, 350);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 24);
            this.labelControl6.TabIndex = 70;
            this.labelControl6.Text = "Supplier";
            // 
            // teSupplier
            // 
            this.teSupplier.Location = new System.Drawing.Point(512, 381);
            this.teSupplier.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.teSupplier.MenuManager = this.ribbon;
            this.teSupplier.Name = "teSupplier";
            this.teSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teSupplier.Properties.Appearance.Options.UseFont = true;
            this.teSupplier.Properties.AutoHeight = false;
            this.teSupplier.Size = new System.Drawing.Size(296, 40);
            this.teSupplier.TabIndex = 71;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(512, 266);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 24);
            this.labelControl7.TabIndex = 72;
            this.labelControl7.Text = "Brand";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.cbLocationGroup);
            this.groupControl1.Controls.Add(this.cbLocation);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.teSupplier);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.teProductName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tePrice);
            this.groupControl1.Controls.Add(this.teBrandName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.teQuantity);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.deExpirationDate);
            this.groupControl1.Controls.Add(this.lueCategory);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(33, 97);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1099, 458);
            this.groupControl1.TabIndex = 74;
            this.groupControl1.Text = "Product Information";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(512, 157);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 23);
            this.labelControl9.TabIndex = 95;
            this.labelControl9.Text = "Group";
            // 
            // cbLocationGroup
            // 
            this.cbLocationGroup.Location = new System.Drawing.Point(512, 185);
            this.cbLocationGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.cbLocationGroup.Size = new System.Drawing.Size(172, 45);
            this.cbLocationGroup.TabIndex = 94;
            this.cbLocationGroup.SelectedIndexChanged += new System.EventHandler(this.cbLocationGroup_SelectedIndexChanged);
            // 
            // cbLocation
            // 
            this.cbLocation.Location = new System.Drawing.Point(694, 185);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbLocation.MenuManager = this.ribbon;
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Properties.AutoHeight = false;
            this.cbLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLocation.Size = new System.Drawing.Size(296, 45);
            this.cbLocation.TabIndex = 75;
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.cbLocation_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(694, 158);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 24);
            this.labelControl8.TabIndex = 74;
            this.labelControl8.Text = "Location";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 663);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddProduct.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Add Product";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocationGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teProductName;
        private DevExpress.XtraEditors.LookUpEdit lueCategory;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tePrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit deExpirationDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.TextEdit teBrandName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit teSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbLocation;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cbLocationGroup;
    }
}