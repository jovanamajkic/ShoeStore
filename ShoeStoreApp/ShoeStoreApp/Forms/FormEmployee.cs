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
    public partial class FormEmployee : Form
    {
        FormMyAccount myAccount;
        FormBillsView myBills;
        FormAddBill addBill;

        private Employee myAcc;

        public FormEmployee(Employee e)
        {
            SetLanguage(e.language);
            InitializeComponent();
            myAcc = e;
            SetTheme(e.theme);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            myAccount = new FormMyAccount(myAcc);
            myAccount.FormClosed += MyAccount_FormClosed;
            myAccount.ReloadParent += FormMyAccount_ReloadParent;
            myAccount.MdiParent = this;
            myAccount.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            myAccount.Show();
        }

        private void FormMyAccount_ReloadParent(object sender, EventArgs e)
        {
            SetLanguage(myAcc.language);
            this.Controls.Clear();
            InitializeComponent();
            SetTheme(myAcc.theme);
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

        private void SetTheme(int theme)
        {
            Theme.SetTheme(theme);
            this.backPanel.BackColor = Theme.pickedTheme.light;
            this.pictureBoxShop.Image = Theme.pickedTheme.image;
            this.labelStore.ForeColor = Theme.pickedTheme.dark;
            this.sideMenuPanel.BackColor = Theme.pickedTheme.medium;
        }

        private void MyAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            myAccount = null;
        }

        private void btnMyBills_Click(object sender, EventArgs e)
        {
            myBills = new FormBillsView(myAcc);
            myBills.FormClosed += MyBills_FormClosed;
            myBills.MdiParent = this;
            myBills.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            myBills.Show();
        }

        private void MyBills_FormClosed(object sender, FormClosedEventArgs e)
        {
            myBills = null;
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            addBill = new FormAddBill(myAcc);
            addBill.FormClosed += AddBill_FormClosed;
            addBill.MdiParent = this;
            addBill.Dock = DockStyle.Fill;
            backPanel.Visible = false;
            addBill.Show();
        }

        private void AddBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            addBill = null;
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

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
