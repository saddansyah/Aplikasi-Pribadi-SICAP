
namespace SICAP
{
    partial class Form_Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Homepage));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnCart = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSubManagement = new System.Windows.Forms.Panel();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnCashier = new Guna.UI2.WinForms.Guna2Button();
            this.btnManagement = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAccount = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblCashierLevel = new System.Windows.Forms.Label();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pbHomepage = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlSubManagement.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHomepage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnAbout);
            this.pnlMenu.Controls.Add(this.btnHistory);
            this.pnlMenu.Controls.Add(this.btnCart);
            this.pnlMenu.Controls.Add(this.pnlSubManagement);
            this.pnlMenu.Controls.Add(this.btnManagement);
            this.pnlMenu.Controls.Add(this.pnlAccount);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(279, 1041);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Animated = true;
            this.btnLogout.AutoRoundedCorners = true;
            this.btnLogout.BorderColor = System.Drawing.Color.Silver;
            this.btnLogout.BorderRadius = 21;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(68)))), ((int)(((byte)(141)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(45)))), ((int)(((byte)(69)))));
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::SICAP.Properties.Resources.round_power_settings_new_white_48;
            this.btnLogout.Location = new System.Drawing.Point(12, 984);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Animated = true;
            this.btnAbout.CheckedState.Parent = this.btnAbout;
            this.btnAbout.CustomImages.Parent = this.btnAbout;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.HoverState.Parent = this.btnAbout;
            this.btnAbout.Image = global::SICAP.Properties.Resources.round_face_white_48;
            this.btnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.Location = new System.Drawing.Point(0, 429);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ShadowDecoration.Parent = this.btnAbout;
            this.btnAbout.Size = new System.Drawing.Size(279, 45);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About Me";
            this.btnAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnHistory
            // 
            this.btnHistory.Animated = true;
            this.btnHistory.CheckedState.Parent = this.btnHistory;
            this.btnHistory.CustomImages.Parent = this.btnHistory;
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.Parent = this.btnHistory;
            this.btnHistory.Image = global::SICAP.Properties.Resources.sharp_category_white_48;
            this.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.Location = new System.Drawing.Point(0, 384);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(279, 45);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCart
            // 
            this.btnCart.Animated = true;
            this.btnCart.CheckedState.Parent = this.btnCart;
            this.btnCart.CustomImages.Parent = this.btnCart;
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.btnCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.HoverState.Parent = this.btnCart;
            this.btnCart.Image = global::SICAP.Properties.Resources.sharp_shopping_cart_white_48;
            this.btnCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCart.Location = new System.Drawing.Point(0, 339);
            this.btnCart.Name = "btnCart";
            this.btnCart.ShadowDecoration.Parent = this.btnCart;
            this.btnCart.Size = new System.Drawing.Size(279, 45);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlSubManagement
            // 
            this.pnlSubManagement.Controls.Add(this.btnCategory);
            this.pnlSubManagement.Controls.Add(this.btnInventory);
            this.pnlSubManagement.Controls.Add(this.btnCashier);
            this.pnlSubManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubManagement.Location = new System.Drawing.Point(0, 206);
            this.pnlSubManagement.Name = "pnlSubManagement";
            this.pnlSubManagement.Size = new System.Drawing.Size(279, 133);
            this.pnlSubManagement.TabIndex = 1;
            // 
            // btnCategory
            // 
            this.btnCategory.Animated = true;
            this.btnCategory.CheckedState.Parent = this.btnCategory;
            this.btnCategory.CustomImages.Parent = this.btnCategory;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(211)))));
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnCategory.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.btnCategory.HoverState.Image = global::SICAP.Properties.Resources.sharp_category_white_48___Copy;
            this.btnCategory.HoverState.Parent = this.btnCategory;
            this.btnCategory.Image = global::SICAP.Properties.Resources.sharp_category_white_48;
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.ImageOffset = new System.Drawing.Point(28, 0);
            this.btnCategory.Location = new System.Drawing.Point(0, 90);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnCategory.ShadowDecoration.Parent = this.btnCategory;
            this.btnCategory.Size = new System.Drawing.Size(279, 45);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Animated = true;
            this.btnInventory.CheckedState.Parent = this.btnInventory;
            this.btnInventory.CustomImages.Parent = this.btnInventory;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(211)))));
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnInventory.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.btnInventory.HoverState.Image = global::SICAP.Properties.Resources.sharp_inventory_2_white_48___Copy;
            this.btnInventory.HoverState.Parent = this.btnInventory;
            this.btnInventory.Image = global::SICAP.Properties.Resources.sharp_inventory_2_white_48;
            this.btnInventory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.ImageOffset = new System.Drawing.Point(28, 0);
            this.btnInventory.Location = new System.Drawing.Point(0, 45);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnInventory.ShadowDecoration.Parent = this.btnInventory;
            this.btnInventory.Size = new System.Drawing.Size(279, 45);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnCashier
            // 
            this.btnCashier.Animated = true;
            this.btnCashier.CheckedState.Parent = this.btnCashier;
            this.btnCashier.CustomImages.Parent = this.btnCashier;
            this.btnCashier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(211)))));
            this.btnCashier.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCashier.ForeColor = System.Drawing.Color.White;
            this.btnCashier.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.btnCashier.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.btnCashier.HoverState.Image = global::SICAP.Properties.Resources.sharp_person_white_48___Copy;
            this.btnCashier.HoverState.Parent = this.btnCashier;
            this.btnCashier.Image = global::SICAP.Properties.Resources.sharp_person_white_48;
            this.btnCashier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCashier.ImageOffset = new System.Drawing.Point(28, 0);
            this.btnCashier.Location = new System.Drawing.Point(0, 0);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnCashier.ShadowDecoration.Parent = this.btnCashier;
            this.btnCashier.Size = new System.Drawing.Size(279, 45);
            this.btnCashier.TabIndex = 2;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Animated = true;
            this.btnManagement.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.btnManagement.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnManagement.CheckedState.Parent = this.btnManagement;
            this.btnManagement.CustomImages.Parent = this.btnManagement;
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.HoverState.Parent = this.btnManagement;
            this.btnManagement.Image = global::SICAP.Properties.Resources.round_storage_black_48;
            this.btnManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManagement.Location = new System.Drawing.Point(0, 161);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.ShadowDecoration.Parent = this.btnManagement;
            this.btnManagement.Size = new System.Drawing.Size(279, 45);
            this.btnManagement.TabIndex = 0;
            this.btnManagement.Text = "Management";
            this.btnManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.lblCashierLevel);
            this.pnlAccount.Controls.Add(this.lblCashierName);
            this.pnlAccount.Controls.Add(this.pbLogo);
            this.pnlAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.ShadowDecoration.Parent = this.pnlAccount;
            this.pnlAccount.Size = new System.Drawing.Size(279, 161);
            this.pnlAccount.TabIndex = 0;
            // 
            // lblCashierLevel
            // 
            this.lblCashierLevel.AutoSize = true;
            this.lblCashierLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCashierLevel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCashierLevel.Location = new System.Drawing.Point(74, 80);
            this.lblCashierLevel.Name = "lblCashierLevel";
            this.lblCashierLevel.Size = new System.Drawing.Size(95, 22);
            this.lblCashierLevel.TabIndex = 2;
            this.lblCashierLevel.Text = "as Admin";
            // 
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCashierName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashierName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCashierName.Location = new System.Drawing.Point(74, 54);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(160, 23);
            this.lblCashierName.TabIndex = 1;
            this.lblCashierName.Text = "Hello, Username";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbLogo.Image = global::SICAP.Properties.Resources.Logo___Copy;
            this.pbLogo.Location = new System.Drawing.Point(30, 41);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(32, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.White;
            this.pnlChildForm.Controls.Add(this.pbHomepage);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(279, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1206, 1041);
            this.pnlChildForm.TabIndex = 1;
            // 
            // pbHomepage
            // 
            this.pbHomepage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHomepage.Image = global::SICAP.Properties.Resources.Homepage_01;
            this.pbHomepage.Location = new System.Drawing.Point(-228, 0);
            this.pbHomepage.Name = "pbHomepage";
            this.pbHomepage.Size = new System.Drawing.Size(1662, 1041);
            this.pbHomepage.TabIndex = 0;
            this.pbHomepage.TabStop = false;
            // 
            // Form_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 1041);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(290, 553);
            this.Name = "Form_Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Homepage_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlSubManagement.ResumeLayout(false);
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHomepage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel pnlSubManagement;
        private Guna.UI2.WinForms.Guna2Button btnManagement;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnCart;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblCashierLevel;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlAccount;
        private System.Windows.Forms.PictureBox pbHomepage;
        public Guna.UI2.WinForms.Guna2Button btnCashier;
        public Guna.UI2.WinForms.Guna2Button btnCategory;
        public Guna.UI2.WinForms.Guna2Button btnInventory;
    }
}