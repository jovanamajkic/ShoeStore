namespace ShoeStoreApp.Forms
{
    partial class FormMyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMyAccount));
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelUN = new System.Windows.Forms.Label();
            this.labelEm = new System.Windows.Forms.Label();
            this.labelPN = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
            this.cbLanguage.Name = "cbLanguage";
            // 
            // cbTheme
            // 
            resources.ApplyResources(this.cbTheme, "cbTheme");
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Items.AddRange(new object[] {
            resources.GetString("cbTheme.Items"),
            resources.GetString("cbTheme.Items1"),
            resources.GetString("cbTheme.Items2")});
            this.cbTheme.Name = "cbTheme";
            // 
            // btnShowPassword
            // 
            resources.ApplyResources(this.btnShowPassword, "btnShowPassword");
            this.btnShowPassword.BackColor = System.Drawing.Color.White;
            this.btnShowPassword.BackgroundImage = global::ShoeStoreApp.Properties.Resources.show;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // textBoxPhone
            // 
            resources.ApplyResources(this.textBoxPhone, "textBoxPhone");
            this.textBoxPhone.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(this.textBoxEmail, "textBoxEmail");
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBoxUsername
            // 
            resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBoxLastname
            // 
            resources.ApplyResources(this.textBoxLastname, "textBoxLastname");
            this.textBoxLastname.BackColor = System.Drawing.Color.White;
            this.textBoxLastname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // labelN
            // 
            resources.ApplyResources(this.labelN, "labelN");
            this.labelN.ForeColor = System.Drawing.Color.Black;
            this.labelN.Name = "labelN";
            // 
            // labelUN
            // 
            resources.ApplyResources(this.labelUN, "labelUN");
            this.labelUN.ForeColor = System.Drawing.Color.Black;
            this.labelUN.Name = "labelUN";
            // 
            // labelEm
            // 
            resources.ApplyResources(this.labelEm, "labelEm");
            this.labelEm.ForeColor = System.Drawing.Color.Black;
            this.labelEm.Name = "labelEm";
            // 
            // labelPN
            // 
            resources.ApplyResources(this.labelPN, "labelPN");
            this.labelPN.ForeColor = System.Drawing.Color.Black;
            this.labelPN.Name = "labelPN";
            // 
            // labelLN
            // 
            resources.ApplyResources(this.labelLN, "labelLN");
            this.labelLN.ForeColor = System.Drawing.Color.Black;
            this.labelLN.Name = "labelLN";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMyAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelUN);
            this.Controls.Add(this.labelEm);
            this.Controls.Add(this.labelPN);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMyAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelUN;
        private System.Windows.Forms.Label labelEm;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Button btnSave;
    }
}