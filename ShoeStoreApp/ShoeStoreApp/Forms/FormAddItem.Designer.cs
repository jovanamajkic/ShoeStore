namespace ShoeStoreApp.Forms
{
    partial class FormAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddItem));
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxSizes = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirm
            // 
            resources.ApplyResources(this.buttonConfirm, "buttonConfirm");
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            this.buttonConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonComfirm_Click);
            // 
            // labelQuantity
            // 
            resources.ApplyResources(this.labelQuantity, "labelQuantity");
            this.labelQuantity.Name = "labelQuantity";
            // 
            // labelSize
            // 
            resources.ApplyResources(this.labelSize, "labelSize");
            this.labelSize.Name = "labelSize";
            // 
            // comboBoxSizes
            // 
            resources.ApplyResources(this.comboBoxSizes, "comboBoxSizes");
            this.comboBoxSizes.FormattingEnabled = true;
            this.comboBoxSizes.Name = "comboBoxSizes";
            // 
            // numQuantity
            // 
            resources.ApplyResources(this.numQuantity, "numQuantity");
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormAddItem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.comboBoxSizes);
            this.Controls.Add(this.numQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAddItem";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxSizes;
        private System.Windows.Forms.NumericUpDown numQuantity;
    }
}