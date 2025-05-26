namespace InventorySystem.Products
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.lueCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.teCapacity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teProductID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teProductName = new DevExpress.XtraEditors.TextEdit();
            this.BtnCancal = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(20, 21, 20, 21);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 220;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(496, 49);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 393);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(496, 37);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tePrice);
            this.groupControl1.Controls.Add(this.lueCategory);
            this.groupControl1.Controls.Add(this.teCapacity);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.teProductID);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.teProductName);
            this.groupControl1.Location = new System.Drawing.Point(40, 81);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(415, 227);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Product";
            // 
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(15, 183);
            this.tePrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tePrice.Name = "tePrice";
            this.tePrice.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F);
            this.tePrice.Properties.Appearance.Options.UseFont = true;
            this.tePrice.Properties.AutoHeight = false;
            this.tePrice.Size = new System.Drawing.Size(151, 27);
            this.tePrice.TabIndex = 65;
            // 
            // lueCategory
            // 
            this.lueCategory.Location = new System.Drawing.Point(248, 122);
            this.lueCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lueCategory.MenuManager = this.ribbon;
            this.lueCategory.Name = "lueCategory";
            this.lueCategory.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lueCategory.Properties.Appearance.Options.UseFont = true;
            this.lueCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryID", "Category ID", 13, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category Name", 13, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueCategory.Properties.DisplayMember = "CategoryName";
            this.lueCategory.Properties.NullText = "";
            this.lueCategory.Properties.ValueMember = "CategoryID";
            this.lueCategory.Size = new System.Drawing.Size(151, 30);
            this.lueCategory.TabIndex = 64;
            // 
            // teCapacity
            // 
            this.teCapacity.Location = new System.Drawing.Point(248, 183);
            this.teCapacity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.teCapacity.Name = "teCapacity";
            this.teCapacity.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F);
            this.teCapacity.Properties.Appearance.Options.UseFont = true;
            this.teCapacity.Properties.AutoHeight = false;
            this.teCapacity.Size = new System.Drawing.Size(151, 27);
            this.teCapacity.TabIndex = 60;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(248, 161);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 16);
            this.labelControl3.TabIndex = 61;
            this.labelControl3.Text = "Capacity";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(248, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 16);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "Category";
            // 
            // teProductID
            // 
            this.teProductID.Location = new System.Drawing.Point(15, 57);
            this.teProductID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.teProductID.Name = "teProductID";
            this.teProductID.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F);
            this.teProductID.Properties.Appearance.Options.UseFont = true;
            this.teProductID.Properties.AutoHeight = false;
            this.teProductID.Size = new System.Drawing.Size(151, 27);
            this.teProductID.TabIndex = 52;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(23, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 16);
            this.labelControl5.TabIndex = 59;
            this.labelControl5.Text = "Price";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 16);
            this.labelControl2.TabIndex = 57;
            this.labelControl2.Text = "Product Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "Product ID";
            // 
            // teProductName
            // 
            this.teProductName.Location = new System.Drawing.Point(15, 122);
            this.teProductName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.teProductName.Name = "teProductName";
            this.teProductName.Properties.Appearance.Font = new System.Drawing.Font("Arial", 10.2F);
            this.teProductName.Properties.Appearance.Options.UseFont = true;
            this.teProductName.Properties.AutoHeight = false;
            this.teProductName.Size = new System.Drawing.Size(151, 27);
            this.teProductName.TabIndex = 53;
            // 
            // BtnCancal
            // 
            this.BtnCancal.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCancal.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancal.Appearance.Options.UseBackColor = true;
            this.BtnCancal.Appearance.Options.UseFont = true;
            this.BtnCancal.Location = new System.Drawing.Point(257, 335);
            this.BtnCancal.Name = "BtnCancal";
            this.BtnCancal.Size = new System.Drawing.Size(198, 31);
            this.BtnCancal.TabIndex = 66;
            this.BtnCancal.Text = "CANCEL";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Appearance.Options.UseBackColor = true;
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(40, 335);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(198, 31);
            this.BtnSubmit.TabIndex = 65;
            this.BtnSubmit.Text = "SUBMIT";
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 430);
            this.Controls.Add(this.BtnCancal);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("UpdateProduct.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateProduct";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teProductName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit teProductName;
        public DevExpress.XtraEditors.TextEdit teProductID;
        public DevExpress.XtraEditors.TextEdit teCapacity;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton BtnCancal;
        private DevExpress.XtraEditors.SimpleButton BtnSubmit;
        public DevExpress.XtraEditors.TextEdit tePrice;
        public DevExpress.XtraEditors.LookUpEdit lueCategory;
    }
}