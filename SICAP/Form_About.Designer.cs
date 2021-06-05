
namespace SICAP
{
    partial class Form_About
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAbout = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbAbout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1630, 1002);
            this.panel1.TabIndex = 0;
            // 
            // pbAbout
            // 
            this.pbAbout.Image = global::SICAP.Properties.Resources.AboutSICAP_02;
            this.pbAbout.Location = new System.Drawing.Point(0, -9);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.ShadowDecoration.Parent = this.pbAbout;
            this.pbAbout.Size = new System.Drawing.Size(1646, 1041);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAbout.TabIndex = 0;
            this.pbAbout.TabStop = false;
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 1002);
            this.Controls.Add(this.panel1);
            this.Name = "Form_About";
            this.Text = "Form_About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbAbout;
    }
}