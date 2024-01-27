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
    public partial class FormAddBill : Form
    {
        private List<BillItem> items = new List<BillItem>();
        private double totalPrice = 0.0;
        private Employee myAccount;

        public FormAddBill(Employee me)
        {
            InitializeComponent();

            myAccount = me;

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
                Name = "addBtn",
                Image = Properties.Resources.plus,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 36,
            };
            dataGridViewAllArticles.Columns.Add(imageColumn2);

            List<Article> articles = Common.DataFactory.Article.GetAll();
            foreach (Article article in articles)
            {
                dataGridViewAllArticles.Rows.Add(null, article, null);
            }

            BackColor = Theme.pickedTheme.light;
            panelHeader1.BackColor = Theme.pickedTheme.medium;
            panelHeader2.BackColor = Theme.pickedTheme.medium;
            btnSaveBill.BackColor = Theme.pickedTheme.dark;
            labelH1.Font = new Font(labelH1.Font, Theme.pickedTheme.fontStyle);
            labelH2.Font = labelH1.Font;
        }



        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill
            {
                date = DateTime.Now,
                totalPrice = totalPrice,
                employeeId = myAccount.id
            };

            int id = Common.DataFactory.Bills.AddBill(bill);
            bill.id = id;

            if (id > 0)
            {
                foreach (BillItem item in items)
                {
                    item.billId = id;
                    Common.DataFactory.BillItems.AddItem(item);
                }

                FormBill formBill = new FormBill(bill, myAccount.name + " " + myAccount.lastname);
                formBill.ShowDialog();

                dataGridViewBill.Rows.Clear();
                items.Clear();
                totalPrice = 0.0;
            }
            else
            {
                MessageBox.Show(Properties.Resources.errorMessage, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAllArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Article a = (Article)dataGridViewAllArticles.Rows[e.RowIndex].Cells["article"].Value;
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridViewAllArticles.Columns["addBtn"].Index)
            {
                FormAddItem inputDialog = new FormAddItem();

                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    ArticleItem articleItem = Common.DataFactory.ArticleItems.getArticleItem(a.idArticle, inputDialog.sizeValue);
                    if (inputDialog.quantityValue > articleItem.quantity)
                    {
                        MessageBox.Show(Properties.Resources.quantityError, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (itemAdded(articleItem.id))
                    {
                        MessageBox.Show(Properties.Resources.itemAdded, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataGridViewBill.Rows.Add(a.idArticle, inputDialog.sizeValue, inputDialog.quantityValue);
                        BillItem item = new BillItem()
                        {
                            quantity = inputDialog.quantityValue,
                            price = a.sellPrice,
                            articleItem = articleItem
                        };
                        items.Add(item);
                        totalPrice += item.price * item.quantity;
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

        private void dataGridViewBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewBill.Columns["delete"].Index)
            {
                dataGridViewBill.Rows.RemoveAt(e.RowIndex);
                totalPrice -= (items[e.RowIndex].price * items[e.RowIndex].quantity);
                items.RemoveAt(e.RowIndex);
            }
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

        private bool itemAdded(int id)
        {
            foreach (BillItem item in items)
            {
                if (item.articleItem.id == id)
                    return true;
            }
            return false;
        }
    }
}
