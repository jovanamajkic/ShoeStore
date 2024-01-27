namespace ShoeStoreApp.Forms
{
    partial class FormAdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPage));
            this.backPanel = new System.Windows.Forms.Panel();
            this.labelStore = new System.Windows.Forms.Label();
            this.pictureBoxShop = new System.Windows.Forms.PictureBox();
            this.sideMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnArticles = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSupply = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSupplyView = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnBills = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).BeginInit();
            this.sideMenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.sideMenuPanel.Controls.Add(this.panel1);
            this.sideMenuPanel.Controls.Add(this.panel2);
            this.sideMenuPanel.Controls.Add(this.panel3);
            this.sideMenuPanel.Controls.Add(this.panel4);
            this.sideMenuPanel.Controls.Add(this.panel7);
            this.sideMenuPanel.Controls.Add(this.panel8);
            this.sideMenuPanel.Controls.Add(this.panel9);
            this.sideMenuPanel.Controls.Add(this.panel10);
            this.sideMenuPanel.Controls.Add(this.panel5);
            this.sideMenuPanel.Name = "sideMenuPanel";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Name = "panel1";
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
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btnAccounts);
            this.panel2.Name = "panel2";
            // 
            // btnAccounts
            // 
            resources.ApplyResources(this.btnAccounts, "btnAccounts");
            this.btnAccounts.ForeColor = System.Drawing.Color.White;
            this.btnAccounts.Image = global::ShoeStoreApp.Properties.Resources.group;
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.btnAddAccount);
            this.panel3.Name = "panel3";
            // 
            // btnAddAccount
            // 
            resources.ApplyResources(this.btnAddAccount, "btnAddAccount");
            this.btnAddAccount.ForeColor = System.Drawing.Color.White;
            this.btnAddAccount.Image = global::ShoeStoreApp.Properties.Resources.new_user;
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Controls.Add(this.btnArticles);
            this.panel4.Name = "panel4";
            // 
            // btnArticles
            // 
            resources.ApplyResources(this.btnArticles, "btnArticles");
            this.btnArticles.ForeColor = System.Drawing.Color.White;
            this.btnArticles.Image = global::ShoeStoreApp.Properties.Resources.smart_shoe;
            this.btnArticles.Name = "btnArticles";
            this.btnArticles.UseVisualStyleBackColor = true;
            this.btnArticles.Click += new System.EventHandler(this.btnArticles_Click);
            // 
            // panel7
            // 
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Controls.Add(this.btnAddArticle);
            this.panel7.Name = "panel7";
            // 
            // btnAddArticle
            // 
            resources.ApplyResources(this.btnAddArticle, "btnAddArticle");
            this.btnAddArticle.ForeColor = System.Drawing.Color.White;
            this.btnAddArticle.Image = global::ShoeStoreApp.Properties.Resources.addArticle;
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Controls.Add(this.btnSupply);
            this.panel8.Name = "panel8";
            // 
            // btnSupply
            // 
            resources.ApplyResources(this.btnSupply, "btnSupply");
            this.btnSupply.ForeColor = System.Drawing.Color.White;
            this.btnSupply.Image = global::ShoeStoreApp.Properties.Resources.procurement;
            this.btnSupply.Name = "btnSupply";
            this.btnSupply.UseVisualStyleBackColor = true;
            this.btnSupply.Click += new System.EventHandler(this.btnSupply_Click);
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Controls.Add(this.btnSupplyView);
            this.panel9.Name = "panel9";
            // 
            // btnSupplyView
            // 
            resources.ApplyResources(this.btnSupplyView, "btnSupplyView");
            this.btnSupplyView.ForeColor = System.Drawing.Color.White;
            this.btnSupplyView.Image = global::ShoeStoreApp.Properties.Resources.checklist;
            this.btnSupplyView.Name = "btnSupplyView";
            this.btnSupplyView.UseVisualStyleBackColor = true;
            this.btnSupplyView.Click += new System.EventHandler(this.btnSupplyView_Click);
            // 
            // panel10
            // 
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Controls.Add(this.btnBills);
            this.panel10.Name = "panel10";
            // 
            // btnBills
            // 
            resources.ApplyResources(this.btnBills, "btnBills");
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Image = global::ShoeStoreApp.Properties.Resources.bill;
            this.btnBills.Name = "btnBills";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Name = "panel6";
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
            // FormAdminPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormAdminPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdminPage_FormClosing);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShop)).EndInit();
            this.sideMenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.PictureBox pictureBoxShop;
        private System.Windows.Forms.FlowLayoutPanel sideMenuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnArticles;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSupply;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnSupplyView;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLogout;
    }
}