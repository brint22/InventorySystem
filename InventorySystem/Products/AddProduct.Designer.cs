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
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(778, 49);
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
            this.labelControl2.Location = new System.Drawing.Point(29, 47);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 16);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Product Name";
            // 
            // teProductName
            // 
            this.teProductName.Location = new System.Drawing.Point(29, 67);
            this.teProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teProductName.MenuManager = this.ribbon;
            this.teProductName.Name = "teProductName";
            this.teProductName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teProductName.Properties.Appearance.Options.UseFont = true;
            this.teProductName.Properties.AutoHeight = false;
            this.teProductName.Size = new System.Drawing.Size(197, 28);
            this.teProductName.TabIndex = 21;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(429, 67);
            this.lookUpEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookUpEdit1.MenuManager = this.ribbon;
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.AutoHeight = false;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(197, 28);
            this.lookUpEdit1.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(429, 47);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 16);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Category";
            // 
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(29, 130);
            this.tePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tePrice.MenuManager = this.ribbon;
            this.tePrice.Name = "tePrice";
            this.tePrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.tePrice.Properties.Appearance.Options.UseFont = true;
            this.tePrice.Properties.AutoHeight = false;
            this.tePrice.Size = new System.Drawing.Size(197, 28);
            this.tePrice.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 110);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 16);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Price";
            // 
            // teQuantity
            // 
            this.teQuantity.Location = new System.Drawing.Point(29, 202);
            this.teQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teQuantity.MenuManager = this.ribbon;
            this.teQuantity.Name = "teQuantity";
            this.teQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teQuantity.Properties.Appearance.Options.UseFont = true;
            this.teQuantity.Properties.AutoHeight = false;
            this.teQuantity.Size = new System.Drawing.Size(197, 28);
            this.teQuantity.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(29, 179);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 16);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Quantity";
            // 
            // deExpirationDate
            // 
            this.deExpirationDate.EditValue = null;
            this.deExpirationDate.Location = new System.Drawing.Point(29, 261);
            this.deExpirationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deExpirationDate.MenuManager = this.ribbon;
            this.deExpirationDate.Name = "deExpirationDate";
            this.deExpirationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExpirationDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExpirationDate.Size = new System.Drawing.Size(197, 28);
            this.deExpirationDate.TabIndex = 28;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(29, 241);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 16);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "Expiration Date";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Appearance.Options.UseBackColor = true;
            this.BtnCancel.Appearance.Options.UseFont = true;
            this.BtnCancel.Location = new System.Drawing.Point(451, 398);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(249, 31);
            this.BtnCancel.TabIndex = 67;
            this.BtnCancel.Text = "CANCEL";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseBackColor = true;
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(81, 398);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(250, 31);
            this.BtnSubmit.TabIndex = 66;
            this.BtnSubmit.Text = "SUBMIT";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // teBrandName
            // 
            this.teBrandName.Location = new System.Drawing.Point(429, 130);
            this.teBrandName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teBrandName.MenuManager = this.ribbon;
            this.teBrandName.Name = "teBrandName";
            this.teBrandName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teBrandName.Properties.Appearance.Options.UseFont = true;
            this.teBrandName.Properties.AutoHeight = false;
            this.teBrandName.Size = new System.Drawing.Size(197, 28);
            this.teBrandName.TabIndex = 69;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(429, 182);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 16);
            this.labelControl6.TabIndex = 70;
            this.labelControl6.Text = "Supplier";
            // 
            // teSupplier
            // 
            this.teSupplier.Location = new System.Drawing.Point(429, 202);
            this.teSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teSupplier.MenuManager = this.ribbon;
            this.teSupplier.Name = "teSupplier";
            this.teSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.teSupplier.Properties.Appearance.Options.UseFont = true;
            this.teSupplier.Properties.AutoHeight = false;
            this.teSupplier.Size = new System.Drawing.Size(197, 28);
            this.teSupplier.TabIndex = 71;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(429, 110);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 16);
            this.labelControl7.TabIndex = 72;
            this.labelControl7.Text = "Brand";
            // 
            // groupControl1
            // 
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
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Location = new System.Drawing.Point(22, 67);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(733, 314);
            this.groupControl1.TabIndex = 74;
            this.groupControl1.Text = "groupControl1";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 453);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AddProduct.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExpirationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teProductName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
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
    }
}