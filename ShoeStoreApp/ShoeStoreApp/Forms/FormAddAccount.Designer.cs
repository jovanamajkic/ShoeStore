namespace ShoeStoreApp.Forms
{
    partial class FormAddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAccount));
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxRole
            // 
            resources.ApplyResources(this.comboBoxRole, "comboBoxRole");
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            resources.GetString("comboBoxRole.Items"),
            resources.GetString("comboBoxRole.Items1")});
            this.comboBoxRole.Name = "comboBoxRole";
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(this.textBoxEmail, "textBoxEmail");
            this.textBoxEmail.Name = "textBoxEmail";
            // 
            // labelRole
            // 
            resources.ApplyResources(this.labelRole, "labelRole");
            this.labelRole.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRole.Name = "labelRole";
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEmail.Name = "labelEmail";
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
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
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
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.Name = "tbUsername";
            // 
            // tbPhoneNumber
            // 
            resources.ApplyResources(this.tbPhoneNumber, "tbPhoneNumber");
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            // 
            // tbLastname
            // 
            resources.ApplyResources(this.tbLastname, "tbLastname");
            this.tbLastname.Name = "tbLastname";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Name = "lblPassword";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblPhoneNumber
            // 
            resources.ApplyResources(this.lblPhoneNumber, "lblPhoneNumber");
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            // 
            // lblLastname
            // 
            resources.ApplyResources(this.lblLastname, "lblLastname");
            this.lblLastname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLastname.Name = "lblLastname";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Name = "lblName";
            // 
            // FormAddAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblName;
    }
}