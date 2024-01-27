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
    public partial class FormAddAccount : Form
    {
        public FormAddAccount()
        {
            InitializeComponent();

            tbPassword.UseSystemPasswordChar = true;

            BackColor = Theme.pickedTheme.light;
            btnSave.BackColor = Theme.pickedTheme.dark;
            foreach (Control control in Controls)
            {
                if (control is Label label)
                {
                    control.Font = new Font(control.Font, Theme.pickedTheme.fontStyle);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbPassword.Text)
                || String.IsNullOrEmpty(tbLastname.Text)
                || String.IsNullOrEmpty(tbPhoneNumber.Text) || String.IsNullOrEmpty(tbUsername.Text)
                || String.IsNullOrEmpty(textBoxEmail.Text) || comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show(Properties.Resources.incompleteData, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Common.UsernameExists(tbUsername.Text))
                {
                    MessageBox.Show(Properties.Resources.usernameExists, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Employee emp = new Employee
                    {
                        name = tbName.Text,
                        lastname = tbLastname.Text,
                        password = tbPassword.Text,
                        username = tbUsername.Text,
                        phoneNumber = tbPhoneNumber.Text,
                        email = textBoxEmail.Text,
                        active = true
                    };

                    if (comboBoxRole.SelectedIndex == 0)
                    {
                        emp.role = "admin";
                    }
                    else
                    {
                        emp.role = "emp";
                    }

                    if (Common.DataFactory.Employees.addEmployee(emp))
                    {
                        MessageBox.Show(Properties.Resources.successAccountAdding);
                        foreach (Control control in this.Controls)
                        {
                            if (control is TextBox textBox)
                            {
                                textBox.Clear();
                            }
                        }
                        comboBoxRole.SelectedItem = null;
                    }
                }
            }
        }


        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
            btnShowPassword.BackgroundImage = tbPassword.UseSystemPasswordChar ? Properties.Resources.show : Properties.Resources.hide;
        }
    }
}
