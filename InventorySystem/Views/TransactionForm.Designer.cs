namespace InventorySystem.Views
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.gcManageTransaction = new DevExpress.XtraEditors.GroupControl();
            this.gcProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.teInputProductName = new DevExpress.XtraEditors.TextEdit();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.btnRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.tePrice = new DevExpress.XtraEditors.TextEdit();
            this.lblTotalPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblAmountPaid = new DevExpress.XtraEditors.LabelControl();
            this.teAmountPaid = new DevExpress.XtraEditors.TextEdit();
            this.lblChange = new DevExpress.XtraEditors.LabelControl();
            this.teChange = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcManageTransaction)).BeginInit();
            this.gcManageTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teInputProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAmountPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teChange.Properties)).BeginInit();
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
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(916, 83);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // gcManageTransaction
            // 
            this.gcManageTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcManageTransaction.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(6);
            this.gcManageTransaction.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.gcManageTransaction.Controls.Add(this.btnRemoveProduct);
            this.gcManageTransaction.Controls.Add(this.btnEnter);
            this.gcManageTransaction.Controls.Add(this.teInputProductName);
            this.gcManageTransaction.Controls.Add(this.gcProducts);
            this.gcManageTransaction.Location = new System.Drawing.Point(12, 58);
            this.gcManageTransaction.Name = "gcManageTransaction";
            this.gcManageTransaction.Size = new System.Drawing.Size(598, 519);
            this.gcManageTransaction.TabIndex = 2;
            this.gcManageTransaction.Text = "Manage Transaction";
            // 
            // gcProducts
            // 
            this.gcProducts.Location = new System.Drawing.Point(0, 87);
            this.gcProducts.MainView = this.gvProducts;
            this.gcProducts.MenuManager = this.ribbon;
            this.gcProducts.Name = "gcProducts";
            this.gcProducts.Size = new System.Drawing.Size(598, 432);
            this.gcProducts.TabIndex = 0;
            this.gcProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProducts});
            // 
            // gvProducts
            // 
            this.gvProducts.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProducts.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvProducts.GridControl = this.gcProducts;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.OptionsBehavior.Editable = false;
            this.gvProducts.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Product Name";
            this.gridColumn1.FieldName = "ProductName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 373;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Price";
            this.gridColumn2.FieldName = "Price";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 394;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Qty";
            this.gridColumn3.FieldName = "Quantity";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 93;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.CaptionImageOptions.Padding = new System.Windows.Forms.Padding(6);
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage1")));
            this.groupControl1.Controls.Add(this.lblChange);
            this.groupControl1.Controls.Add(this.teChange);
            this.groupControl1.Controls.Add(this.lblAmountPaid);
            this.groupControl1.Controls.Add(this.teAmountPaid);
            this.groupControl1.Controls.Add(this.lblTotalPrice);
            this.groupControl1.Controls.Add(this.tePrice);
            this.groupControl1.Controls.Add(this.windowsUIButtonPanel1);
            this.groupControl1.Location = new System.Drawing.Point(616, 58);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(288, 519);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Transaction Summary";
            // 
            // teInputProductName
            // 
            this.teInputProductName.EditValue = "Enter Product Name";
            this.teInputProductName.Location = new System.Drawing.Point(6, 53);
            this.teInputProductName.MenuManager = this.ribbon;
            this.teInputProductName.Name = "teInputProductName";
            this.teInputProductName.Properties.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.teInputProductName.Properties.Appearance.Options.UseForeColor = true;
            this.teInputProductName.Size = new System.Drawing.Size(348, 28);
            this.teInputProductName.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(360, 53);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 28);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "ENTER";
            // 
            // windowsUIButtonPanel1
            // 
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            windowsUIButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions2.SvgImage")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Cancel", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(86, 450);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(113, 64);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.Text = "wuiBtnPnlPrintandCancel";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(467, 53);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(126, 28);
            this.btnRemoveProduct.TabIndex = 3;
            this.btnRemoveProduct.Text = "REMOVE PRODUCT";
            // 
            // tePrice
            // 
            this.tePrice.Location = new System.Drawing.Point(167, 80);
            this.tePrice.MenuManager = this.ribbon;
            this.tePrice.Name = "tePrice";
            this.tePrice.Size = new System.Drawing.Size(100, 28);
            this.tePrice.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(27, 87);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(50, 13);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.Location = new System.Drawing.Point(27, 121);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(60, 13);
            this.lblAmountPaid.TabIndex = 4;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // teAmountPaid
            // 
            this.teAmountPaid.Location = new System.Drawing.Point(167, 114);
            this.teAmountPaid.MenuManager = this.ribbon;
            this.teAmountPaid.Name = "teAmountPaid";
            this.teAmountPaid.Size = new System.Drawing.Size(100, 28);
            this.teAmountPaid.TabIndex = 3;
            // 
            // lblChange
            // 
            this.lblChange.Location = new System.Drawing.Point(27, 155);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(37, 13);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "Change";
            // 
            // teChange
            // 
            this.teChange.Location = new System.Drawing.Point(167, 148);
            this.teChange.MenuManager = this.ribbon;
            this.teChange.Name = "teChange";
            this.teChange.Size = new System.Drawing.Size(100, 28);
            this.teChange.TabIndex = 5;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 589);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcManageTransaction);
            this.Controls.Add(this.ribbon);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TransactionForm.IconOptions.SvgImage")));
            this.Name = "TransactionForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Transaction Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcManageTransaction)).EndInit();
            this.gcManageTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teInputProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAmountPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teChange.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraEditors.GroupControl gcManageTransaction;
        private DevExpress.XtraGrid.GridControl gcProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducts;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btnRemoveProduct;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraEditors.TextEdit teInputProductName;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.LabelControl lblChange;
        private DevExpress.XtraEditors.TextEdit teChange;
        private DevExpress.XtraEditors.LabelControl lblAmountPaid;
        private DevExpress.XtraEditors.TextEdit teAmountPaid;
        private DevExpress.XtraEditors.LabelControl lblTotalPrice;
        private DevExpress.XtraEditors.TextEdit tePrice;
    }
}