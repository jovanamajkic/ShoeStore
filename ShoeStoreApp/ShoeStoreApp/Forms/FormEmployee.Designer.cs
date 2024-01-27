namespace ShoeStoreApp.Forms
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.backPanel = new System.Windows.Forms.Panel();
            this.labelStore = new System.Windows.Forms.Label();
            this.pictureBoxShop = new System.Windows.Forms.PictureBox();
            this.sideMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAcc = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panelBills = new System.Windows.Forms.Panel();
            this.btnMyBills = new System.Windows.Forms.Button();
            this.panelAddBill = new System.Windows.Forms.Panel();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).BeginInit();
            this.sideMenuPanel.SuspendLayout();
            this.panelAcc.SuspendLayout();
            this.panelBills.SuspendLayout();
            this.panelAddBill.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            resources.ApplyResources(this.backPanel, "backPanel");
            this.backPanel.Controls.Add(this.labelStore);
            this.backPanel.Controls.Add(this.pictureBoxShop);
            this.backPanel.Name = "backPanel";
            // 
            // labelStore
            // 
            resources.ApplyResources(this.labelStore, "labelStore");
            this.labelStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            this.labelStore.Name = "labelStore";
            // 
            // pictureBoxShop
            // 
            resources.ApplyResources(this.pictureBoxShop, "pictureBoxShop");
            this.pictureBoxShop.Image = global::ShoeStoreApp.Properties.Resources.shoe_shop0;
            this.pictureBoxShop.Name = "pictureBoxShop";
            this.pictureBoxShop.TabStop = false;
            // 
            // sideMenuPanel
            // 
            resources.ApplyResources(this.sideMenuPanel, "sideMenuPanel");
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.sideMenuPanel.Controls.Add(this.panelAcc);
            this.sideMenuPanel.Controls.Add(this.panelBills);
            this.sideMenuPanel.Controls.Add(this.panelAddBill);
            this.sideMenuPanel.Controls.Add(this.panelContainer);
            this.sideMenuPanel.Name = "sideMenuPanel";
            // 
            // panelAcc
            // 
            resources.ApplyResources(this.panelAcc, "panelAcc");
            this.panelAcc.Controls.Add(this.btnAccount);
            this.panelAcc.Name = "panelAcc";
            // 
            // btnAccount
            // 
            resources.ApplyResources(this.btnAccount, "btnAccount");
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = global::ShoeStoreApp.Properties.Resources.user;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panelBills
            // 
            resources.ApplyResources(this.panelBills, "panelBills");
            this.panelBills.Controls.Add(this.btnMyBills);
            this.panelBills.Name = "panelBills";
            // 
            // btnMyBills
            // 
            resources.ApplyResources(this.btnMyBills, "btnMyBills");
            this.btnMyBills.ForeColor = System.Drawing.Color.White;
            this.btnMyBills.Image = global::ShoeStoreApp.Properties.Resources.bill;
            this.btnMyBills.Name = "btnMyBills";
            this.btnMyBills.UseVisualStyleBackColor = true;
            this.btnMyBills.Click += new System.EventHandler(this.btnMyBills_Click);
            // 
            // panelAddBill
            // 
            resources.ApplyResources(this.panelAddBill, "panelAddBill");
            this.panelAddBill.Controls.Add(this.btnAddBill);
            this.panelAddBill.Name = "panelAddBill";
            // 
            // btnAddBill
            // 
            resources.ApplyResources(this.btnAddBill, "btnAddBill");
            this.btnAddBill.ForeColor = System.Drawing.Color.White;
            this.btnAddBill.Image = global::ShoeStoreApp.Properties.Resources.add_button;
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // panelContainer
            // 
            resources.ApplyResources(this.panelContainer, "panelContainer");
            this.panelContainer.Controls.Add(this.panelLogout);
            this.panelContainer.Name = "panelContainer";
            // 
            // panelLogout
            // 
            resources.ApplyResources(this.panelLogout, "panelLogout");
            this.panelLogout.Controls.Add(this.btnLogout);
            this.panelLogout.Name = "panelLogout";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::ShoeStoreApp.Properties.Resources.logout;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormEmployee
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormEmployee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployee_FormClosing);
            this.backPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).EndInit();
            this.sideMenuPanel.ResumeLayout(false);
            this.panelAcc.ResumeLayout(false);
            this.panelBills.ResumeLayout(false);
            this.panelAddBill.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.PictureBox pictureBoxShop;
        private System.Windows.Forms.FlowLayoutPanel sideMenuPanel;
        private System.Windows.Forms.Panel panelAcc;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panelBills;
        private System.Windows.Forms.Button btnMyBills;
        private System.Windows.Forms.Panel panelAddBill;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button btnLogout;
    }
}