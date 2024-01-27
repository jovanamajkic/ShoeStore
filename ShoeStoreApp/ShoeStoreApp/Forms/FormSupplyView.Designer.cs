namespace ShoeStoreApp.Forms
{
    partial class FormSupplyView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplyView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelSummaryPrice = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.dataGridViewElements = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelStore = new System.Windows.Forms.Label();
            this.pictureStore = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElements)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStore)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            resources.ApplyResources(this.panelFooter, "panelFooter");
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Name = "panelFooter";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelPrice);
            this.panel1.Controls.Add(this.labelDateTime);
            this.panel1.Controls.Add(this.labelEmployee);
            this.panel1.Name = "panel1";
            // 
            // panelPrice
            // 
            resources.ApplyResources(this.panelPrice, "panelPrice");
            this.panelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrice.Controls.Add(this.labelPrice);
            this.panelPrice.Controls.Add(this.labelSummaryPrice);
            this.panelPrice.Name = "panelPrice";
            // 
            // labelPrice
            // 
            resources.ApplyResources(this.labelPrice, "labelPrice");
            this.labelPrice.Name = "labelPrice";
            // 
            // labelSummaryPrice
            // 
            resources.ApplyResources(this.labelSummaryPrice, "labelSummaryPrice");
            this.labelSummaryPrice.Name = "labelSummaryPrice";
            // 
            // labelDateTime
            // 
            resources.ApplyResources(this.labelDateTime, "labelDateTime");
            this.labelDateTime.Name = "labelDateTime";
            // 
            // labelEmployee
            // 
            resources.ApplyResources(this.labelEmployee, "labelEmployee");
            this.labelEmployee.Name = "labelEmployee";
            // 
            // dataGridViewElements
            // 
            resources.ApplyResources(this.dataGridViewElements, "dataGridViewElements");
            this.dataGridViewElements.AllowUserToAddRows = false;
            this.dataGridViewElements.AllowUserToDeleteRows = false;
            this.dataGridViewElements.AllowUserToResizeColumns = false;
            this.dataGridViewElements.AllowUserToResizeRows = false;
            this.dataGridViewElements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewElements.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.dataGridViewElements.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewElements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.size,
            this.quantity,
            this.price});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewElements.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewElements.Name = "dataGridViewElements";
            this.dataGridViewElements.ReadOnly = true;
            this.dataGridViewElements.RowHeadersVisible = false;
            // 
            // panelHeader
            // 
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.labelEmail);
            this.panelHeader.Controls.Add(this.labelStore);
            this.panelHeader.Controls.Add(this.pictureStore);
            this.panelHeader.Name = "panelHeader";
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.Name = "labelEmail";
            // 
            // labelStore
            // 
            resources.ApplyResources(this.labelStore, "labelStore");
            this.labelStore.Name = "labelStore";
            // 
            // pictureStore
            // 
            resources.ApplyResources(this.pictureStore, "pictureStore");
            this.pictureStore.Name = "pictureStore";
            this.pictureStore.TabStop = false;
            // 
            // id
            // 
            this.id.FillWeight = 74.27142F;
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.FillWeight = 180.7107F;
            resources.ApplyResources(this.name, "name");
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // size
            // 
            this.size.FillWeight = 80F;
            resources.ApplyResources(this.size, "size");
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 72.50895F;
            resources.ApplyResources(this.quantity, "quantity");
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 72.50895F;
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // FormSupplyView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.dataGridViewElements);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.Name = "FormSupplyView";
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewElements)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSummaryPrice;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.DataGridView dataGridViewElements;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelStore;
        private System.Windows.Forms.PictureBox pictureStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}