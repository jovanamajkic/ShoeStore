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
    public partial class FormAccount : Form
    {
        private Employee currEmp = null;

        public FormAccount(Employee employee)
        {
            InitializeComponent();
            currEmp = employee;

            textBoxName.Text = currEmp.name;
            textBoxLastname.Text = currEmp.lastname;
            textBoxUsername.Text = currEmp.username;
            textBoxEmail.Text = currEmp.email;
            textBoxPhone.Text = currEmp.phoneNumber;
            buttonDeActivate.Text = currEmp.active ? Properties.Resources.deactivate : Properties.Resources.activate;

            BackColor = Theme.pickedTheme.light;
            buttonDeActivate.BackColor = Theme.pickedTheme.dark;
            buttonSave.BackColor = Theme.pickedTheme.dark;
            foreach (Control control in tableInfo.Controls)
            {
                if (control is Label label)
                {
                    label.Font = new Font(label.Font, Theme.pickedTheme.fontStyle);
                }
            }

        }

        private void buttonDeActivate_Click(object sender, EventArgs e)
        {
            if (currEmp.active)
            {
                DialogResult result = MessageBox.Show(Properties.Resources.deactivateAccount, Properties.Resources.confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Common.DataFactory.Employees.deActivateEmployee(currEmp.id, 0))
                    {
                        buttonDeActivate.Text = Properties.Resources.activate;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.errorMessage, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(Properties.Resources.activateAccount, Properties.Resources.confirm, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (Common.DataFactory.Employees.deActivateEmployee(currEmp.id, 1))
                    {
                        buttonDeActivate.Text = Properties.Resources.deactivate;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.errorMessage, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxLastname.Text)
                || String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxEmail.Text)
                || String.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show(Properties.Resources.incompleteData, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (currEmp.username != textBoxUsername.Text && Common.UsernameExists(textBoxUsername.Text))
                {
                    MessageBox.Show(Properties.Resources.usernameExists, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    currEmp.name = textBoxName.Text;
                    currEmp.lastname = textBoxLastname.Text;
                    currEmp.email = textBoxEmail.Text;
                    currEmp.phoneNumber = textBoxPhone.Text;
                    currEmp.username = textBoxUsername.Text;
                    if (Common.DataFactory.Employees.updateEmployee(currEmp))
                    {
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(Properties.Resources.errorMessage, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
