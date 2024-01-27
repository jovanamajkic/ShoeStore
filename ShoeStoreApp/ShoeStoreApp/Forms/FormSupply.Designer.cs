namespace ShoeStoreApp.Forms
{
    partial class FormSupply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupply));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridViewAllArticles = new System.Windows.Forms.DataGridView();
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.labelH1 = new System.Windows.Forms.Label();
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.dataGridViewSupply = new System.Windows.Forms.DataGridView();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFinish = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.labelH2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllArticles)).BeginInit();
            this.panelHeader1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelHeader2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.searchBox);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewAllArticles);
            this.splitContainer1.Panel1.Controls.Add(this.panelHeader1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSupplier);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewSupply);
            this.splitContainer1.Panel2.Controls.Add(this.btnFinish);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            // 
            // pbSearch
            // 
            this.pbSearch.BackColor = System.Drawing.Color.White;
            this.pbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSearch.Image = global::ShoeStoreApp.Properties.Resources.search_blue;
            resources.ApplyResources(this.pbSearch, "pbSearch");
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.Name = "searchBox";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dataGridViewAllArticles
            // 
            this.dataGridViewAllArticles.AllowUserToAddRows = false;
            this.dataGridViewAllArticles.AllowUserToDeleteRows = false;
            this.dataGridViewAllArticles.AllowUserToResizeColumns = false;
            this.dataGridViewAllArticles.AllowUserToResizeRows = false;
            this.dataGridViewAllArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllArticles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAllArticles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAllArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllArticles.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAllArticles.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewAllArticles, "dataGridViewAllArticles");
            this.dataGridViewAllArticles.Name = "dataGridViewAllArticles";
            this.dataGridViewAllArticles.ReadOnly = true;
            this.dataGridViewAllArticles.RowHeadersVisible = false;
            this.dataGridViewAllArticles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllArticles_CellContentClick);
            // 
            // panelHeader1
            // 
            this.panelHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.panelHeader1.Controls.Add(this.labelH1);
            resources.ApplyResources(this.panelHeader1, "panelHeader1");
            this.panelHeader1.Name = "panelHeader1";
            // 
            // labelH1
            // 
            resources.ApplyResources(this.labelH1, "labelH1");
            this.labelH1.ForeColor = System.Drawing.SystemColors.Window;
            this.labelH1.Name = "labelH1";
            // 
            // comboBoxSupplier
            // 
            resources.ApplyResources(this.comboBoxSupplier, "comboBoxSupplier");
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            // 
            // dataGridViewSupply
            // 
            this.dataGridViewSupply.AllowUserToAddRows = false;
            this.dataGridViewSupply.AllowUserToDeleteRows = false;
            this.dataGridViewSupply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupply.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSupply.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSupply.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.article,
            this.size,
            this.quantity,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSupply.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.dataGridViewSupply, "dataGridViewSupply");
            this.dataGridViewSupply.Name = "dataGridViewSupply";
            this.dataGridViewSupply.ReadOnly = true;
            this.dataGridViewSupply.RowHeadersVisible = false;
            this.dataGridViewSupply.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSupply.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupply_CellContentClick);
            // 
            // article
            // 
            this.article.FillWeight = 125F;
            resources.ApplyResources(this.article, "article");
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // size
            // 
            this.size.FillWeight = 95F;
            resources.ApplyResources(this.size, "size");
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 95F;
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 90F;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = global::ShoeStoreApp.Properties.Resources.bin;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            resources.ApplyResources(this.btnFinish, "btnFinish");
            this.btnFinish.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.panel2.Controls.Add(this.panelHeader2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panelHeader2
            // 
            this.panelHeader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(163)))), ((int)(((byte)(226)))));
            this.panelHeader2.Controls.Add(this.labelH2);
            resources.ApplyResources(this.panelHeader2, "panelHeader2");
            this.panelHeader2.Name = "panelHeader2";
            // 
            // labelH2
            // 
            resources.ApplyResources(this.labelH2, "labelH2");
            this.labelH2.ForeColor = System.Drawing.SystemColors.Window;
            this.labelH2.Name = "labelH2";
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // FormSupply
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupply";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllArticles)).EndInit();
            this.panelHeader1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupply)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelHeader2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Label labelH2;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.Label labelH1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridViewAllArticles;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.DataGridView dataGridViewSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}