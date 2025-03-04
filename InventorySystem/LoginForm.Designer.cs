namespace InventorySystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teUserName
            // 
            this.teUserName.EditValue = "Username";
            this.teUserName.Location = new System.Drawing.Point(34, 84);
            this.teUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teUserName.Properties.Appearance.Options.UseFont = true;
            this.teUserName.Properties.AutoHeight = false;
            this.teUserName.Size = new System.Drawing.Size(299, 32);
            this.teUserName.TabIndex = 0;
            this.teUserName.Enter += new System.EventHandler(this.teUserName_Enter);
            this.teUserName.Leave += new System.EventHandler(this.teUserName_Leave);
            // 
            // tePassword
            // 
            this.tePassword.EditValue = "Password";
            this.tePassword.Location = new System.Drawing.Point(34, 162);
            this.tePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.AutoHeight = false;
            this.tePassword.Size = new System.Drawing.Size(299, 32);
            this.tePassword.TabIndex = 1;
            this.tePassword.Enter += new System.EventHandler(this.tePassword_Enter);
            this.tePassword.Leave += new System.EventHandler(this.tePassword_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Appearance.Options.UseBackColor = true;
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.Location = new System.Drawing.Point(34, 238);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(299, 35);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(181, 34);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // LoginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 365);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUserName);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LoginForm.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

