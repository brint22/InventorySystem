namespace InventorySystem.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAddEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.bbiViewEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.addProduct = new DevExpress.XtraBars.BarButtonItem();
            this.viewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.addAccount = new DevExpress.XtraBars.BarButtonItem();
            this.viewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.Main = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.addAccounts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.bbiListView = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTileView = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowMinimizeRibbon = false;
            this.ribbon.AutoUpdateMergedRibbons = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 37, 35, 37);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiAddEmployee,
            this.bbiViewEmployee,
            this.addProduct,
            this.viewProduct,
            this.addAccount,
            this.viewAccount,
            this.barSubItem1,
            this.barSubItem2,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barSubItem3,
            this.bbiListView,
            this.bbiTileView});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsExpandCollapseMenu.ShowRibbonGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.OptionsExpandCollapseMenu.ShowRibbonLayoutGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.OptionsMenuMinWidth = 385;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Main,
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1188, 217);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAddEmployee
            // 
            this.bbiAddEmployee.Caption = "Add Employee";
            this.bbiAddEmployee.Id = 1;
            this.bbiAddEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiAddEmployee.ImageOptions.SvgImage")));
            this.bbiAddEmployee.Name = "bbiAddEmployee";
            this.bbiAddEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bbiAddEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAddEmployee_ItemClick);
            // 
            // bbiViewEmployee
            // 
            this.bbiViewEmployee.Caption = "View Employee";
            this.bbiViewEmployee.Id = 2;
            this.bbiViewEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiViewEmployee.ImageOptions.SvgImage")));
            this.bbiViewEmployee.Name = "bbiViewEmployee";
            this.bbiViewEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // addProduct
            // 
            this.addProduct.Caption = "Add Product";
            this.addProduct.Id = 3;
            this.addProduct.Name = "addProduct";
            // 
            // viewProduct
            // 
            this.viewProduct.Caption = "View Product";
            this.viewProduct.Id = 4;
            this.viewProduct.Name = "viewProduct";
            // 
            // addAccount
            // 
            this.addAccount.Caption = "Add Account";
            this.addAccount.Id = 5;
            this.addAccount.Name = "addAccount";
            // 
            // viewAccount
            // 
            this.viewAccount.Caption = "View Account";
            this.viewAccount.Id = 6;
            this.viewAccount.Name = "viewAccount";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 7;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "View Employee";
            this.barSubItem2.Id = 8;
            this.barSubItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem2.ImageOptions.SvgImage")));
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tile View";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "List View";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // Main
            // 
            this.Main.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6,
            this.addAccounts});
            this.Main.Name = "Main";
            this.Main.Text = "Employees";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup1.ImageOptions.SvgImage")));
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAddEmployee);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // addAccounts
            // 
            this.addAccounts.ItemLinks.Add(this.viewAccount);
            this.addAccounts.Name = "addAccounts";
            this.addAccounts.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.addAccount);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Products";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.addProduct);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.viewProduct);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barSubItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "View Employee";
            this.barButtonItem3.Id = 11;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "View Employee";
            this.barSubItem3.Id = 12;
            this.barSubItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem3.ImageOptions.SvgImage")));
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiTileView),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiListView)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // bbiListView
            // 
            this.bbiListView.Caption = "List View";
            this.bbiListView.Id = 13;
            this.bbiListView.Name = "bbiListView";
            this.bbiListView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiListView_ItemClick);
            // 
            // bbiTileView
            // 
            this.bbiTileView.Caption = "Tile View";
            this.bbiTileView.Id = 14;
            this.bbiTileView.Name = "bbiTileView";
            this.bbiTileView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTileView_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 787);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Main;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbiAddEmployee;
        private DevExpress.XtraBars.BarButtonItem bbiViewEmployee;
        private DevExpress.XtraBars.BarButtonItem addProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem viewProduct;
        private DevExpress.XtraBars.BarButtonItem addAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup addAccounts;
        private DevExpress.XtraBars.BarButtonItem viewAccount;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem bbiTileView;
        private DevExpress.XtraBars.BarButtonItem bbiListView;
    }
}