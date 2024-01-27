namespace ShoeStoreApp.Forms
{
    partial class FormArticlesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticlesView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerContent = new System.Windows.Forms.SplitContainer();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).BeginInit();
            this.splitContainerContent.Panel1.SuspendLayout();
            this.splitContainerContent.Panel2.SuspendLayout();
            this.splitContainerContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerContent
            // 
            resources.ApplyResources(this.splitContainerContent, "splitContainerContent");
            this.splitContainerContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.splitContainerContent.Name = "splitContainerContent";
            // 
            // splitContainerContent.Panel1
            // 
            resources.ApplyResources(this.splitContainerContent.Panel1, "splitContainerContent.Panel1");
            this.splitContainerContent.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.splitContainerContent.Panel1.Controls.Add(this.btnReset);
            this.splitContainerContent.Panel1.Controls.Add(this.btnFilter);
            this.splitContainerContent.Panel1.Controls.Add(this.lblGender);
            this.splitContainerContent.Panel1.Controls.Add(this.cbGender);
            this.splitContainerContent.Panel1.Controls.Add(this.lblCategory);
            this.splitContainerContent.Panel1.Controls.Add(this.cbCategory);
            this.splitContainerContent.Panel1.Controls.Add(this.pbSearch);
            this.splitContainerContent.Panel1.Controls.Add(this.searchBox);
            // 
            // splitContainerContent.Panel2
            // 
            resources.ApplyResources(this.splitContainerContent.Panel2, "splitContainerContent.Panel2");
            this.splitContainerContent.Panel2.Controls.Add(this.dataGridViewArticles);
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
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Name = "lblGender";
            // 
            // cbGender
            // 
            resources.ApplyResources(this.cbGender, "cbGender");
            this.cbGender.BackColor = System.Drawing.SystemColors.Window;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Name = "cbGender";
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategory.Name = "lblCategory";
            // 
            // cbCategory
            // 
            resources.ApplyResources(this.cbCategory, "cbCategory");
            this.cbCategory.BackColor = System.Drawing.SystemColors.Window;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Name = "cbCategory";
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
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dataGridViewArticles
            // 
            resources.ApplyResources(this.dataGridViewArticles, "dataGridViewArticles");
            this.dataGridViewArticles.AllowUserToAddRows = false;
            this.dataGridViewArticles.AllowUserToDeleteRows = false;
            this.dataGridViewArticles.AllowUserToResizeColumns = false;
            this.dataGridViewArticles.AllowUserToResizeRows = false;
            this.dataGridViewArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewArticles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewArticles.ColumnHeadersVisible = false;
            this.dataGridViewArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.article});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArticles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArticles.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.ReadOnly = true;
            this.dataGridViewArticles.RowHeadersVisible = false;
            this.dataGridViewArticles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArticles_CellContentDoubleClick);
            // 
            // article
            // 
            resources.ApplyResources(this.article, "article");
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // FormArticlesView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.splitContainerContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormArticlesView";
            this.splitContainerContent.Panel1.ResumeLayout(false);
            this.splitContainerContent.Panel1.PerformLayout();
            this.splitContainerContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerContent)).EndInit();
            this.splitContainerContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.SplitContainer splitContainerContent;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox searchBox;
    }
}