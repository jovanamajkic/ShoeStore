namespace ShoeStoreApp.Forms
{
    partial class FormAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccounts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerContent = new System.Windows.Forms.SplitContainer();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridViewAccounts = new System.Windows.Forms.DataGridView();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerContent
            // 
            resources.ApplyResources(this.splitContainerContent, "splitContainerContent");
            this.splitContainerContent.Name = "splitContainerContent";
            // 
            // splitContainerContent.Panel1
            // 
            resources.ApplyResources(this.splitContainerContent.Panel1, "splitContainerContent.Panel1");
            this.splitContainerContent.Panel1.Controls.Add(this.btnReset);
            this.splitContainerContent.Panel1.Controls.Add(this.btnFilter);
            this.splitContainerContent.Panel1.Controls.Add(this.lblRole);
            this.splitContainerContent.Panel1.Controls.Add(this.cbStatus);
            this.splitContainerContent.Panel1.Controls.Add(this.pbSearch);
            this.splitContainerContent.Panel1.Controls.Add(this.searchBox);
            this.splitContainerContent.Panel1.Controls.Add(this.splitter1);
            // 
            // splitContainerContent.Panel2
            // 
            resources.ApplyResources(this.splitContainerContent.Panel2, "splitContainerContent.Panel2");
            this.splitContainerContent.Panel2.Controls.Add(this.dataGridViewAccounts);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Image = global::ShoeStoreApp.Properties.Resources.circle_of_two_clockwise_arrows_rotation;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFilter
            // 
            resources.ApplyResources(this.btnFilter, "btnFilter");
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFilter.Image = global::ShoeStoreApp.Properties.Resources.filter;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblRole
            // 
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblRole.Name = "lblRole";
            // 
            // cbStatus
            // 
            resources.ApplyResources(this.cbStatus, "cbStatus");
            this.cbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            resources.GetString("cbStatus.Items"),
            resources.GetString("cbStatus.Items1")});
            this.cbStatus.Name = "cbStatus";
            // 
            // pbSearch
            // 
            resources.ApplyResources(this.pbSearch, "pbSearch");
            this.pbSearch.BackColor = System.Drawing.Color.White;
            this.pbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSearch.Image = global::ShoeStoreApp.Properties.Resources.search_blue;
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.TabStop = false;
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Name = "searchBox";
            this.searchBox.Click += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // dataGridViewAccounts
            // 
            resources.ApplyResources(this.dataGridViewAccounts, "dataGridViewAccounts");
            this.dataGridViewAccounts.AllowUserToAddRows = false;
            this.dataGridViewAccounts.AllowUserToDeleteRows = false;
            this.dataGridViewAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccounts.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAccounts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccounts.ColumnHeadersVisible = false;
            this.dataGridViewAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccounts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccounts.Name = "dataGridViewAccounts";
            this.dataGridViewAccounts.ReadOnly = true;
            this.dataGridViewAccounts.RowHeadersVisible = false;
            this.dataGridViewAccounts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccounts_CellContentDoubleClick);
            // 
            // account
            // 
            resources.ApplyResources(this.account, "account");
            this.account.Name = "account";
            this.account.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormAccounts
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.splitContainerContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccounts";
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel1.PerformLayout();
            this.splitContainerContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerContent;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridViewAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}