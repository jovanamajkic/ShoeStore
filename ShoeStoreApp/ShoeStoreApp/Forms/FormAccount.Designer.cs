namespace ShoeStoreApp.Forms
{
    partial class FormAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDeActivate = new System.Windows.Forms.Button();
            this.tableInfo = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelUN = new System.Windows.Forms.Label();
            this.labelEm = new System.Windows.Forms.Label();
            this.labelPN = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tableInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDeActivate
            // 
            this.buttonDeActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            resources.ApplyResources(this.buttonDeActivate, "buttonDeActivate");
            this.buttonDeActivate.ForeColor = System.Drawing.Color.White;
            this.buttonDeActivate.Name = "buttonDeActivate";
            this.buttonDeActivate.UseVisualStyleBackColor = false;
            this.buttonDeActivate.Click += new System.EventHandler(this.buttonDeActivate_Click);
            // 
            // tableInfo
            // 
            resources.ApplyResources(this.tableInfo, "tableInfo");
            this.tableInfo.Controls.Add(this.textBoxPhone, 1, 4);
            this.tableInfo.Controls.Add(this.textBoxEmail, 1, 3);
            this.tableInfo.Controls.Add(this.textBoxUsername, 1, 2);
            this.tableInfo.Controls.Add(this.textBoxLastname, 1, 1);
            this.tableInfo.Controls.Add(this.labelN, 0, 0);
            this.tableInfo.Controls.Add(this.labelLN, 0, 1);
            this.tableInfo.Controls.Add(this.labelUN, 0, 2);
            this.tableInfo.Controls.Add(this.labelEm, 0, 3);
            this.tableInfo.Controls.Add(this.labelPN, 0, 4);
            this.tableInfo.Controls.Add(this.textBoxName, 1, 0);
            this.tableInfo.Name = "tableInfo";
            // 
            // textBoxPhone
            // 
            resources.ApplyResources(this.textBoxPhone, "textBoxPhone");
            this.textBoxPhone.Name = "textBoxPhone";
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(this.textBoxEmail, "textBoxEmail");
            this.textBoxEmail.Name = "textBoxEmail";
            // 
            // textBoxUsername
            // 
            resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
            this.textBoxUsername.Name = "textBoxUsername";
            // 
            // textBoxLastname
            // 
            resources.ApplyResources(this.textBoxLastname, "textBoxLastname");
            this.textBoxLastname.Name = "textBoxLastname";
            // 
            // labelN
            // 
            resources.ApplyResources(this.labelN, "labelN");
            this.labelN.Name = "labelN";
            // 
            // labelLN
            // 
            resources.ApplyResources(this.labelLN, "labelLN");
            this.labelLN.Name = "labelLN";
            // 
            // labelUN
            // 
            resources.ApplyResources(this.labelUN, "labelUN");
            this.labelUN.Name = "labelUN";
            // 
            // labelEm
            // 
            resources.ApplyResources(this.labelEm, "labelEm");
            this.labelEm.Name = "labelEm";
            // 
            // labelPN
            // 
            resources.ApplyResources(this.labelPN, "labelPN");
            this.labelPN.Name = "labelPN";
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            // 
            // FormAccount
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDeActivate);
            this.Controls.Add(this.tableInfo);
            this.MaximizeBox = false;
            this.Name = "FormAccount";
            this.tableInfo.ResumeLayout(false);
            this.tableInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDeActivate;
        private System.Windows.Forms.TableLayoutPanel tableInfo;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelUN;
        private System.Windows.Forms.Label labelEm;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.TextBox textBoxName;
    }
}