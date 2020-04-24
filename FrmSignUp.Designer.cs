namespace _200424_YuGiOh_PoC_Lejkic_Edition
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEm = new System.Windows.Forms.TextBox();
            this.txtConEm = new System.Windows.Forms.TextBox();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(181, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtEm
            // 
            this.txtEm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtEm.Location = new System.Drawing.Point(159, 126);
            this.txtEm.Name = "txtEm";
            this.txtEm.Size = new System.Drawing.Size(187, 20);
            this.txtEm.TabIndex = 2;
            this.txtEm.Text = "Email";
            this.txtEm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEm_MouseClick);
            this.txtEm.Leave += new System.EventHandler(this.txtEm_Leave);
            // 
            // txtConEm
            // 
            this.txtConEm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtConEm.Location = new System.Drawing.Point(170, 161);
            this.txtConEm.Name = "txtConEm";
            this.txtConEm.Size = new System.Drawing.Size(187, 20);
            this.txtConEm.TabIndex = 3;
            this.txtConEm.Text = "Confirm Email";
            this.txtConEm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtConEm_MouseClick);
            this.txtConEm.Leave += new System.EventHandler(this.txtConEm_Leave);
            // 
            // txtConPass
            // 
            this.txtConPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtConPass.Location = new System.Drawing.Point(170, 235);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.Size = new System.Drawing.Size(173, 20);
            this.txtConPass.TabIndex = 4;
            this.txtConPass.Text = "Confirm Password";
            this.txtConPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtConPass_MouseClick);
            this.txtConPass.Leave += new System.EventHandler(this.txtConPass_Leave);
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPass.Location = new System.Drawing.Point(159, 200);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(173, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.Text = "Password";
            this.txtPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPass_MouseClick);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(178, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sign Up";
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.txtConEm);
            this.Controls.Add(this.txtEm);
            this.Controls.Add(this.txtUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSignUp";
            this.Text = "FrmSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEm;
        private System.Windows.Forms.TextBox txtConEm;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
    }
}