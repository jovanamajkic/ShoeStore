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
    public partial class FormSupply : System.Windows.Forms.Form
    {
        private int adminId;
        private List<Article> articles = Common.DataFactory.Article.GetAll();
        private List<SupplyItem> supplyItems = new List<SupplyItem>();
        public FormSupply(int id)
        {
            InitializeComponent();

            adminId = id;

            comboBoxSupplier.DataSource = Common.DataFactory.Supplier.GetSuppliers();

            DataGridViewImageColumn imageColumn1 = new DataGridViewImageColumn
            {
                HeaderText = Properties.Resources.details,
                Name = "infoBtn",
                Image = Properties.Resources.dots1,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 36,
            };
            dataGridViewAllArticles.Columns.Add(imageColumn1);

            dataGridViewAllArticles.Columns.Add("article", Properties.Resources.article);
            dataGridViewAllArticles.Columns["article"].Width = 170;

            DataGridViewImageColumn imageColumn2 = new DataGridViewImageColumn
            {
                HeaderText = Properties.Resources.supply,
                Name = "supplyBtn",
                Image = Properties.Resources.plus,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 36,
            };
            dataGridViewAllArticles.Columns.Add(imageColumn2);

            foreach (Article article in articles)
            {
                dataGridViewAllArticles.Rows.Add(null, article, null);
            }

            BackColor = Theme.pickedTheme.light;
            panel2.BackColor = Theme.pickedTheme.light;
            panelHeader1.BackColor = Theme.pickedTheme.medium;
            panelHeader2.BackColor = Theme.pickedTheme.medium;
            btnFinish.BackColor = Theme.pickedTheme.dark;
            labelH1.Font = new Font(labelH1.Font, Theme.pickedTheme.fontStyle);
            labelH2.Font = new Font(labelH2.Font, Theme.pickedTheme.fontStyle);

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchBox.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridViewAllArticles.Rows)
            {
                string cellValue = row.Cells["article"].Value.ToString().ToLower();
                row.Visible = cellValue.Contains(searchValue);
            }
        }

        private void dataGridViewAllArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Article a = (Article)dataGridViewAllArticles.Rows[e.RowIndex].Cells["article"].Value;
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridViewAllArticles.Columns["supplyBtn"].Index)
            {
                FormAddItem inputDialog = new FormAddItem();

                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    int itemId = Common.DataFactory.ArticleItems.getArticleItem(a.idArticle, inputDialog.sizeValue).id;
                    if (itemAdded(itemId))
                    {
                        MessageBox.Show(Properties.Resources.itemAdded, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataGridViewSupply.Rows.Add(a.idArticle, inputDialog.sizeValue, inputDialog.quantityValue);
                        SupplyItem item = new SupplyItem
                        {
                            price = a.supplyPrice,
                            quantity = inputDialog.quantityValue,
                            articleItemId = itemId
                        };
                        supplyItems.Add(item);
                    }
                }
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridViewAllArticles.Columns["infoBtn"].Index)
            {
                List<ArticleItem> items = Common.DataFactory.ArticleItems.getItemsByArticle(a.idArticle);
                FormArticleItem formArticleItem = new FormArticleItem(items);
                formArticleItem.ShowDialog();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            double totalPrice = 0.0;
            foreach (SupplyItem item in supplyItems)
            {
                totalPrice += (item.price * item.quantity);
            }

            if (comboBoxSupplier.SelectedItem != null)
            {
                Supply supply = new Supply
                {
                    supplierId = ((Supplier)comboBoxSupplier.SelectedItem).Id,
                    employeeId = adminId,
                    totalPrice = totalPrice
                };

                int supplyId = Common.DataFactory.Supply.addSupply(supply);

                foreach (SupplyItem item in supplyItems)
                {
                    item.supplyId = supplyId;
                    Common.DataFactory.SupplyItem.AddSuplyItem(item);
                }

                MessageBox.Show(Properties.Resources.successSuply);
                dataGridViewAllArticles.Rows.Clear();
                articles = Common.DataFactory.Article.GetAll();
                foreach (Article article in articles)
                {
                    dataGridViewAllArticles.Rows.Add(null, article, null);
                }
                dataGridViewSupply.Rows.Clear();
                supplyItems.Clear();
            }
            else
            {
                MessageBox.Show(Properties.Resources.supplierError, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSupply_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewSupply.Columns["delete"].Index)
            {
                dataGridViewSupply.Rows.RemoveAt(e.RowIndex);
                supplyItems.RemoveAt(e.RowIndex);
            }
        }

        private bool itemAdded(int id)
        {
            foreach (SupplyItem item in supplyItems)
            {
                if (item.articleItemId == id)
                    return true;
            }
            return false;
        }
    }
}
