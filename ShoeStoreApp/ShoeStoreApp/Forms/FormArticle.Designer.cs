namespace ShoeStoreApp.Forms
{
    partial class FormArticle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArticle));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.numSellPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.numSupplyPrice = new System.Windows.Forms.NumericUpDown();
            this.lblSuplyPrice = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSupplyPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Name = "btnDelete";
            this.toolTip1.SetToolTip(this.btnDelete, resources.GetString("btnDelete.ToolTip"));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(107)))), ((int)(((byte)(171)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.toolTip1.SetToolTip(this.btnSave, resources.GetString("btnSave.ToolTip"));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbPicture
            // 
            resources.ApplyResources(this.pbPicture, "pbPicture");
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.pbPicture, resources.GetString("pbPicture.ToolTip"));
            this.pbPicture.Click += new System.EventHandler(this.pbPicture_Click);
            this.pbPicture.MouseEnter += new System.EventHandler(this.pbPicture_MouseEnter);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            this.toolTip1.SetToolTip(this.lblName, resources.GetString("lblName.ToolTip"));
            // 
            // numSellPrice
            // 
            resources.ApplyResources(this.numSellPrice, "numSellPrice");
            this.numSellPrice.DecimalPlaces = 2;
            this.numSellPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSellPrice.Name = "numSellPrice";
            this.toolTip1.SetToolTip(this.numSellPrice, resources.GetString("numSellPrice.ToolTip"));
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            this.toolTip1.SetToolTip(this.lblCategory, resources.GetString("lblCategory.ToolTip"));
            // 
            // lblGender
            // 
            resources.ApplyResources(this.lblGender, "lblGender");
            this.lblGender.Name = "lblGender";
            this.toolTip1.SetToolTip(this.lblGender, resources.GetString("lblGender.ToolTip"));
            // 
            // numSupplyPrice
            // 
            resources.ApplyResources(this.numSupplyPrice, "numSupplyPrice");
            this.numSupplyPrice.DecimalPlaces = 2;
            this.numSupplyPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSupplyPrice.Name = "numSupplyPrice";
            this.toolTip1.SetToolTip(this.numSupplyPrice, resources.GetString("numSupplyPrice.ToolTip"));
            // 
            // lblSuplyPrice
            // 
            resources.ApplyResources(this.lblSuplyPrice, "lblSuplyPrice");
            this.lblSuplyPrice.Name = "lblSuplyPrice";
            this.toolTip1.SetToolTip(this.lblSuplyPrice, resources.GetString("lblSuplyPrice.ToolTip"));
            // 
            // cbGender
            // 
            resources.ApplyResources(this.cbGender, "cbGender");
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Name = "cbGender";
            this.toolTip1.SetToolTip(this.cbGender, resources.GetString("cbGender.ToolTip"));
            // 
            // lblSellPrice
            // 
            resources.ApplyResources(this.lblSellPrice, "lblSellPrice");
            this.lblSellPrice.Name = "lblSellPrice";
            this.toolTip1.SetToolTip(this.lblSellPrice, resources.GetString("lblSellPrice.ToolTip"));
            // 
            // cbCategory
            // 
            resources.ApplyResources(this.cbCategory, "cbCategory");
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Name = "cbCategory";
            this.toolTip1.SetToolTip(this.cbCategory, resources.GetString("cbCategory.ToolTip"));
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            this.toolTip1.SetToolTip(this.tbName, resources.GetString("tbName.ToolTip"));
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialogPic";
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.Pictures)";
            // 
            // FormArticle
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(189)))), ((int)(((byte)(234)))));
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.numSellPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.numSupplyPrice);
            this.Controls.Add(this.lblSuplyPrice);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbName);
            this.MaximizeBox = false;
            this.Name = "FormArticle";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSupplyPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numSellPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.NumericUpDown numSupplyPrice;
        private System.Windows.Forms.Label lblSuplyPrice;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}