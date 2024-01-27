namespace ShoeStoreApp.Forms
{
    partial class FormAddBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.labelH1 = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridViewAllArticles = new System.Windows.Forms.DataGridView();
            this.panelHeader2 = new System.Windows.Forms.Panel();
            this.labelH2 = new System.Windows.Forms.Label();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelHeader1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllArticles)).BeginInit();
            this.panelHeader2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelHeader1);
            this.splitContainer1.Panel1.Controls.Add(this.pbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.searchBox);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewAllArticles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelHeader2);
            this.splitContainer1.Panel2.Controls.Add(this.btnSaveBill);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewBill);
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
            // btnSaveBill
            // 
            this.btnSaveBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            resources.ApplyResources(this.btnSaveBill, "btnSaveBill");
            this.btnSaveBill.ForeColor = System.Drawing.Color.White;
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.UseVisualStyleBackColor = false;
            this.btnSaveBill.Click += new System.EventHandler(this.btnSaveBill_Click);
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewBill.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.dataGridViewBill, "dataGridViewBill");
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.ReadOnly = true;
            this.dataGridViewBill.RowHeadersVisible = false;
            this.dataGridViewBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellContentClick);
            // 
            // article
            // 
            resources.ApplyResources(this.article, "article");
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // size
            // 
            resources.ApplyResources(this.size, "size");
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // quantity
            // 
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 80F;
            resources.ApplyResources(this.delete, "delete");
            this.delete.Image = global::ShoeStoreApp.Properties.Resources.bin;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // FormAddBill
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddBill";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelHeader1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllArticles)).EndInit();
            this.panelHeader2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelHeader1;
        private System.Windows.Forms.Label labelH1;
        private System.Windows.Forms.PictureBox pbSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridViewAllArticles;
        private System.Windows.Forms.Panel panelHeader2;
        private System.Windows.Forms.Label labelH2;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}