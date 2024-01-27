namespace ShoeStoreApp.Forms
{
    partial class FormBillsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBillsView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerTo);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerFrom);
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.btnFilter);
            this.splitContainer1.Panel1.Controls.Add(this.lblDateTo);
            this.splitContainer1.Panel1.Controls.Add(this.lblDateFrom);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewBills);
            // 
            // dateTimePickerTo
            // 
            resources.ApplyResources(this.dateTimePickerTo, "dateTimePickerTo");
            this.dateTimePickerTo.MaxDate = new System.DateTime(2024, 1, 27, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Value = new System.DateTime(2024, 1, 17, 0, 0, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            resources.ApplyResources(this.dateTimePickerFrom, "dateTimePickerFrom");
            this.dateTimePickerFrom.MaxDate = new System.DateTime(2024, 1, 17, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Value = new System.DateTime(2024, 1, 17, 0, 0, 0, 0);
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
            // lblDateTo
            // 
            resources.ApplyResources(this.lblDateTo, "lblDateTo");
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateTo.Name = "lblDateTo";
            // 
            // lblDateFrom
            // 
            resources.ApplyResources(this.lblDateFrom, "lblDateFrom");
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateFrom.Name = "lblDateFrom";
            // 
            // dataGridViewBills
            // 
            resources.ApplyResources(this.dataGridViewBills, "dataGridViewBills");
            this.dataGridViewBills.AllowUserToAddRows = false;
            this.dataGridViewBills.AllowUserToDeleteRows = false;
            this.dataGridViewBills.AllowUserToResizeColumns = false;
            this.dataGridViewBills.AllowUserToResizeRows = false;
            this.dataGridViewBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBills.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.price,
            this.emp});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBills.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBills.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBills_RowHeaderMouseDoubleClick);
            // 
            // id
            // 
            this.id.FillWeight = 40F;
            resources.ApplyResources(this.id, "id");
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 90F;
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // emp
            // 
            this.emp.FillWeight = 90F;
            resources.ApplyResources(this.emp, "emp");
            this.emp.Name = "emp";
            this.emp.ReadOnly = true;
            // 
            // FormBillsView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBillsView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp;
    }
}