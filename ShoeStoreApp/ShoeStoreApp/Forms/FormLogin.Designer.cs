namespace ShoeStoreApp.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.pbShoes = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowPassword
            // 
            resources.ApplyResources(this.btnShowPassword, "btnShowPassword");
            this.btnShowPassword.BackColor = System.Drawing.SystemColors.Window;
            this.btnShowPassword.BackgroundImage = global::ShoeStoreApp.Properties.Resources.show;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // pbShoes
            // 
            resources.ApplyResources(this.pbShoes, "pbShoes");
            this.pbShoes.Image = global::ShoeStoreApp.Properties.Resources.shoe_shop0;
            this.pbShoes.Name = "pbShoes";
            this.pbShoes.TabStop = false;
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyUp);
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyUp);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblUsername.Name = "lblUsername";
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.pbShoes);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbShoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.PictureBox pbShoes;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
    }
}