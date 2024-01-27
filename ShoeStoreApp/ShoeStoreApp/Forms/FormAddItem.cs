using ShoeStoreApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStoreApp.Forms
{
    public partial class FormAddItem : Form
    {
        public int quantityValue { get; private set; }
        public int sizeValue { get; private set; }

        public FormAddItem()
        {
            InitializeComponent();

            comboBoxSizes.DataSource = Common.Sizes;

            BackColor = Theme.pickedTheme.light;
            buttonConfirm.BackColor = Theme.pickedTheme.dark;
            labelQuantity.Font = new Font(labelQuantity.Font, Theme.pickedTheme.fontStyle);
            labelSize.Font = new Font(labelSize.Font, Theme.pickedTheme.fontStyle);
        }

        private void buttonComfirm_Click(object sender, EventArgs e)
        {
            if (numQuantity.Value > 0)
            {
                sizeValue = (int)comboBoxSizes.SelectedItem;
                quantityValue = (int)numQuantity.Value;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(Properties.Resources.zeroItems, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
