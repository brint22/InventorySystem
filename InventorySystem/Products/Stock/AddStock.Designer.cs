namespace InventorySystem.Products.Stock
{
    partial class AddStock
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
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbProductName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbLocationGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbLocation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teSupplier = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.teBrandName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teQuantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deExpirationDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocationGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsExpandCollapseMenu.ShowRibbonGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.OptionsExpandCollapseMenu.ShowRibbonLayoutGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1296, 73);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Visible = false;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 674);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1296, 55);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(669, 598);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(373, 45);
            this.BtnCancel.TabIndex = 79;
            this.BtnCancel.Text = "CANCEL";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseBackColor = true;
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(264, 598);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(375, 45);
            this.BtnSubmit.TabIndex = 78;
            this.BtnSubmit.Text = "SUBMIT";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.cbProductName);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.cbLocationGroup);
            this.groupControl1.Controls.Add(this.cbLocation);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.teSupplier);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.tePrice);
            this.groupControl1.Controls.Add(this.teBrandName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.teQuantity);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.deExpirationDate);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(99, 86);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1099, 458);
            this.groupControl1.TabIndex = 80;
            this.groupControl1.Text = "Stock Information";
            // 
            // cbProductName
            // 
            this.cbProductName.Location = new System.Drawing.Point(44, 100);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(5);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Properties.AutoHeight = false;
            this.cbProductName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProductName.Size = new System.Drawing.Size(420, 45);
            this.cbProductName.TabIndex = 96;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(571, 72);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(55, 23);
            this.labelControl9.TabIndex = 95;
            this.labelControl9.Text = "Group";
            // 
            // cbLocationGroup
            // 
            this.cbLocationGroup.Location = new System.Drawing.Point(571, 100);
            this.cbLocationGroup.Margin = new System.Windows.Forms.Padding(5);
            this.cbLocationGroup.Name = "cbLocationGroup";
            this.cbLocationGroup.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocationGroup.Properties.Appearance.Options.UseFont = true;
            this.cbLocationGroup.Properties.AutoHeight = false;
            this.cbLocationGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLocationGroup.Properties.Items.AddRange(new object[] {
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
            // 
            // cbLocation
            // 
            this.cbLocation.Location = new System.Drawing.Point(754, 100);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(5);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Properties.AutoHeight = false;
            this.cbLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLocation.Size = new System.Drawing.Size(296, 45);
            this.cbLocation.TabIndex = 75;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(754, 73);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 24);
            this.labelControl8.TabIndex = 74;
            this.labelControl8.Text = "Location";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(570, 266);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 24);
            this.labelControl6.TabIndex = 70;
            this.labelControl6.Text = "Supplier";
            // 
            // teSupplier
            // 
            this.teSupplier.Location = new System.Drawing.Point(570, 296);
            this.teSupplier.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.teSupplier.Name = "teSupplier";
            this.teSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teSupplier.Properties.Appearance.Options.UseFont = true;
            this.teSupplier.Properties.AutoHeight = false;
            this.teSupplier.Size = new System.Drawing.Size(478, 40);
            this.teSupplier.TabIndex = 71;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(570, 160);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 24);
            this.labelControl7.TabIndex = 72;
            this.labelControl7.Text = "Brand";
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
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(44, 190);
            this.tePrice.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.tePrice.Name = "tePrice";
            this.tePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tePrice.Properties.Appearance.Options.UseFont = true;
            this.tePrice.Properties.AutoHeight = false;
            this.tePrice.Size = new System.Drawing.Size(420, 40);
            this.tePrice.TabIndex = 25;
            // 
            // teBrandName
            // 
            this.teBrandName.Location = new System.Drawing.Point(570, 190);
            this.teBrandName.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.teBrandName.Name = "teBrandName";
            this.teBrandName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teBrandName.Properties.Appearance.Options.UseFont = true;
            this.teBrandName.Properties.AutoHeight = false;
            this.teBrandName.Size = new System.Drawing.Size(478, 40);
            this.teBrandName.TabIndex = 69;
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
            this.teQuantity.Name = "teQuantity";
            this.teQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teQuantity.Properties.Appearance.Options.UseFont = true;
            this.teQuantity.Properties.AutoHeight = false;
            this.teQuantity.Size = new System.Drawing.Size(420, 40);
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
            this.deExpirationDate.Name = "deExpirationDate";
            this.deExpirationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExpirationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExpirationDate.Size = new System.Drawing.Size(420, 40);
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
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 729);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "AddStock";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocationGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbProductName;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cbLocationGroup;
        private DevExpress.XtraEditors.ComboBoxEdit cbLocation;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit teSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tePrice;
        private DevExpress.XtraEditors.TextEdit teBrandName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit deExpirationDate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}