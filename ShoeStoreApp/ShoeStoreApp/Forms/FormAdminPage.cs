using ShoeStoreApp.Data.Model;
using ShoeStoreApp.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStoreApp.Forms
{
    public partial class FormAdminPage : Form
    {
        FormAccounts formAccounts;
        FormAddAccount formAddAcc;
        FormArticlesView itemsView;
        FormSupply formSupply;
        FormAddArticle formAddArticle;
        FormMyAccount formMyAccount;
        FormBillsView billsView;
        FormSuppliesView suppliesView;

        Employee admin;

        public FormAdminPage(Employee e)
        {
            SetLanguage(e.language);
            InitializeComponent();
            admin = e;
            SetTheme(e.theme);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            formAccounts = new FormAccounts(admin);
            formAccounts.FormClosed += FormAccounts_FormClosed;
            formAccounts.MdiParent = this;
            formAccounts.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            formAccounts.Show();
        }

        private void FormAccounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAccounts = null;
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            itemsView = new FormArticlesView();
            itemsView.FormClosed += ItemsView_FormClosed;
            itemsView.MdiParent = this;
            itemsView.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            itemsView.Show();
        }

        private void ItemsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            itemsView = null;
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            formSupply = new FormSupply(admin.id);
            formSupply.FormClosed += FormSupply_FormClosed;
            formSupply.MdiParent = this;
            formSupply.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            formSupply.Show();
        }

        private void FormSupply_FormClosed(object sender, FormClosedEventArgs e)
        {
            formSupply = null;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            formAddAcc = new FormAddAccount();
            formAddAcc.FormClosed += FormAddAcc_FormClosed;
            formAddAcc.MdiParent = this;
            formAddAcc.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            formAddAcc.Show();
        }

        private void FormAddAcc_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAddAcc = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Properties.Resources.logoutConfirm, Properties.Resources.confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            formAddArticle = new FormAddArticle();
            formAddArticle.FormClosed += FormAddArticle_FormClosed;
            formAddArticle.MdiParent = this;
            formAddArticle.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            formAddArticle.Show();
        }

        private void FormAddArticle_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAddArticle = null;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            formMyAccount = new FormMyAccount(admin);
            formMyAccount.FormClosed += FormMyAccount_FormClosed;
            formMyAccount.ReloadParent += FormMyAccount_ReloadParent;
            formMyAccount.MdiParent = this;
            formMyAccount.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            formMyAccount.Show();
        }

        private void FormMyAccount_ReloadParent(object sender, EventArgs e)
        {
            SetLanguage(admin.language);
            this.Controls.Clear();
            InitializeComponent();
            SetTheme(admin.theme);
        }

        private void FormMyAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMyAccount = null;
        }

        private void SetTheme(int theme)
        {
            Theme.SetTheme(theme);
            this.backPanel.BackColor = Theme.pickedTheme.light;
            this.pictureBoxShop.Image = Theme.pickedTheme.image;
            this.labelStore.ForeColor = Theme.pickedTheme.dark;
            this.sideMenuPanel.BackColor = Theme.pickedTheme.medium;
        }

        private void SetLanguage(int lang)
        {
            if (lang == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            }
            else if (lang == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sr-Latn-RS");
            }
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            billsView = new FormBillsView(admin);
            billsView.FormClosed += BillsView_FormClosed;
            billsView.MdiParent = this;
            billsView.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            billsView.Show();
        }

        private void BillsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            billsView = null;
        }

        private void btnSupplyView_Click(object sender, EventArgs e)
        {
            suppliesView = new FormSuppliesView();
            suppliesView.FormClosed += SuppliesView_FormClosed;
            suppliesView.MdiParent = this;
            suppliesView.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            suppliesView.Show();
        }

        private void SuppliesView_FormClosed(object sender, FormClosedEventArgs e)
        {
            suppliesView = null;
        }

        private void FormAdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
