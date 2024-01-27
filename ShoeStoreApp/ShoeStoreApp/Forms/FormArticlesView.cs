using ShoeStoreApp.Data.Model;
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
    public partial class FormArticlesView : Form
    {
        public FormArticlesView()
        {
            InitializeComponent();

            cbCategory.DataSource = Common.DataFactory.ArticleProperties.GetArticleTypes();
            cbGender.DataSource = Common.DataFactory.ArticleProperties.GetGenders();

            cbCategory.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;

            foreach (Article a in Common.DataFactory.Article.GetAll())
            {
                dataGridViewArticles.Rows.Add(a);
            }

            BackColor = Theme.pickedTheme.light;
            splitContainerContent.Panel1.BackColor = BackColor;
            btnFilter.BackColor = Theme.pickedTheme.dark;
            btnReset.BackColor = Theme.pickedTheme.dark;
            lblCategory.Font = new Font(lblCategory.Font, Theme.pickedTheme.fontStyle);
            lblGender.Font = new Font(lblGender.Font, Theme.pickedTheme.fontStyle);
        }


        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchBox.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridViewArticles.Rows)
            {
                string cellValue = row.Cells["article"].Value.ToString().ToLower();
                row.Visible = cellValue.Contains(searchValue);
            }
        }

        private void dataGridViewArticles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Article currArticle = dataGridViewArticles.Rows[e.RowIndex].Cells["article"].Value as Article;
            FormArticle formArticle = new FormArticle(currArticle);
            DialogResult result = formArticle.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGridViewArticles.Rows.Clear();
                foreach (Article a in Common.DataFactory.Article.GetAll())
                {
                    dataGridViewArticles.Rows.Add(a);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int genderId = ((Gender)cbGender.SelectedItem).id;
            int typeId = ((ArticleType)cbCategory.SelectedItem).id;

            if (genderId > -1 && typeId > -1)
            {
                foreach (DataGridViewRow row in dataGridViewArticles.Rows)
                {
                    Article a = (Article)row.Cells["article"].Value;
                    if (a.genderId == genderId && a.typeId == typeId)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewArticles.Rows)
            {
                row.Visible = true;
            }
            cbCategory.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;
        }

    }
}
