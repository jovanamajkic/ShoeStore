using ShoeStoreApp.Data.DataAccess;
using ShoeStoreApp.Data.Model;
using ShoeStoreApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStoreApp.Forms
{
    public partial class FormAddArticle : Form
    {
        private string imageName = null;
        private List<Article> allArticles = Common.DataFactory.Article.GetAll();

        public FormAddArticle()
        {
            InitializeComponent();

            cbGender.DataSource = Common.DataFactory.ArticleProperties.GetGenders();
            cbType.DataSource = Common.DataFactory.ArticleProperties.GetArticleTypes();

            BackColor = Theme.pickedTheme.light;
            btnChoosePic.BackColor = Theme.pickedTheme.dark;
            btnSave.BackColor = Theme.pickedTheme.dark;
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.Font = new Font(control.Font, Theme.pickedTheme.fontStyle);
            }
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                imageName = Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbId.Text) || String.IsNullOrEmpty(tbName.Text) || numUpDownSell.Value <= 0 || numUpDownSupply.Value <= 0 || cbType.SelectedItem == null || cbGender.SelectedItem == null)
            {
                MessageBox.Show(Properties.Resources.incompleteData, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool unique = true;
                foreach (Article article in allArticles)
                {
                    if (article.idArticle == int.Parse(tbId.Text))
                    {
                        MessageBox.Show(Properties.Resources.codeExists, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    Article newArticle = new Article()
                    {
                        idArticle = int.Parse(tbId.Text),
                        name = tbName.Text,
                        picture = imageName,
                        supplyPrice = (double)numUpDownSupply.Value,
                        sellPrice = (double)numUpDownSell.Value,
                        genderId = ((Gender)cbGender.SelectedItem).id,
                        typeId = ((ArticleType)cbType.SelectedItem).id
                    };
                    if (Common.DataFactory.Article.AddArticle(newArticle))
                    {
                        if (!File.Exists(FormArticle.PATH + newArticle.picture))
                        {
                            String destPath = FormArticle.PATH + imageName;
                            File.Copy(openFileDialog.FileName, destPath, true);
                        }
                        ResetControls(this);
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.errorMessage, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ResetControls(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox box)
                {
                    box.Clear();
                }
                else if (ctrl is NumericUpDown down)
                {
                    down.Value = 0;
                }
                else if (ctrl is ComboBox box1)
                {
                    box1.SelectedIndex = -1;
                }

                if (ctrl.HasChildren)
                {
                    ResetControls(ctrl);
                }
            }
        }
    }
}
