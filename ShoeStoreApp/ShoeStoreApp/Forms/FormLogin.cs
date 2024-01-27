using ShoeStoreApp.Data.DataAccess.MySql;
using ShoeStoreApp.Data.Model;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
            btnShowPassword.BackgroundImage = tbPassword.UseSystemPasswordChar ? Properties.Resources.show : Properties.Resources.hide;
        }

        private void tbPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
            else if (e.KeyCode == Keys.Up)
            {
                tbUsername.Focus();
            }
        }

        private void login()
        {
            if (String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show(Properties.Resources.incompleteData, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Employee employee = MySqlUtil.SignIn(tbUsername.Text, tbPassword.Text);
                if (employee == null)
                {
                    MessageBox.Show(Properties.Resources.incorrectCredentials, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsername.ResetText();
                    tbPassword.ResetText();
                }
                else
                {
                    if (employee.active)
                    {
                        if (employee.role == "admin")
                        {
                            FormAdminPage formAdmin = new FormAdminPage(employee);
                            formAdmin.Show();
                        }
                        else
                        {
                            FormEmployee formEmployee = new FormEmployee(employee);
                            formEmployee.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.nonActiveAcc, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tbUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
            else if (e.KeyCode == Keys.Down)
            {
                tbPassword.Focus();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
