using ShoeStoreApp.Data.Model;
using ShoeStoreApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStoreApp.Forms
{
    public partial class FormArticle : Form
    {
        private Article article;
        public static readonly string PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + "\\Resources\\Images\\";
        private bool picChanged = false;

        public FormArticle(Article a)
        {
            InitializeComponent();
            article = a;

            List<Gender> genders = Common.DataFactory.ArticleProperties.GetGenders();
            List<ArticleType> types = Common.DataFactory.ArticleProperties.GetArticleTypes();

            cbCategory.DataSource = types;
            cbGender.DataSource = genders;

            tbName.Text = a.name;
            numSupplyPrice.Value = (decimal)a.supplyPrice;
            numSellPrice.Value = (decimal)a.sellPrice;
            cbCategory.SelectedIndex = a.typeId - 1;
            cbGender.SelectedIndex = a.genderId - 1;
            if (File.Exists(PATH + a.picture))
            {
                pbPicture.Image = Image.FromFile(PATH + a.picture);
                pbPicture.Tag = a.picture;
                pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbPicture.Image = Properties.Resources.image;
                pbPicture.Tag = null;
                pbPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            BackColor = Theme.pickedTheme.light;
            btnSave.BackColor = Theme.pickedTheme.dark;
            btnDelete.BackColor = Theme.pickedTheme.dark;
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    control.Font = new Font(control.Font, Theme.pickedTheme.fontStyle);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Resources.deleteArticle, Properties.Resources.confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (Common.DataFactory.Article.DeleteArticle(article))
                {
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text) || cbCategory.SelectedItem == null || cbGender.SelectedItem == null)
            {
                MessageBox.Show(Properties.Resources.incompleteData, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                article.name = tbName.Text;
                article.supplyPrice = (double)numSupplyPrice.Value;
                article.sellPrice = (double)numSellPrice.Value;
                article.genderId = ((Gender)cbGender.SelectedItem).id;
                article.typeId = ((ArticleType)cbCategory.SelectedItem).id;
                article.picture = pbPicture.Tag.ToString();

                if (Common.DataFactory.Article.UpdateArticle(article))
                {
                    if (picChanged && !File.Exists(FormArticle.PATH + article.picture))
                    {
                        String destPath = FormArticle.PATH + article.picture;
                        File.Copy(openFileDialog.FileName, destPath, true);
                    }
                    DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.errorMessage, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbPicture_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pbPicture.Image = Image.FromFile(openFileDialog.FileName);
                pbPicture.Tag = Path.GetFileName(openFileDialog.FileName);
                picChanged = true;
            }
        }

        private void pbPicture_MouseEnter(object sender, EventArgs e)
        {
            pbPicture.Cursor = Cursors.Hand;
        }
    }
}
