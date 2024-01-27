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
    public partial class FormMyAccount : Form
    {
        public event EventHandler ReloadParent;
        private Employee employee;
        private List<TextBox> boxes = new List<TextBox>();

        public FormMyAccount(Employee e)
        {
            InitializeComponent();

            textBoxName.Text = e.name;
            textBoxLastname.Text = e.lastname;
            textBoxEmail.Text = e.email;
            textBoxUsername.Text = e.username;
            textBoxPhone.Text = e.phoneNumber;
            textBoxPassword.Text = e.password;
            textBoxPassword.UseSystemPasswordChar = true;
            cbTheme.SelectedIndex = e.theme - 1;
            cbLanguage.SelectedIndex = e.language - 1;
            employee = e;

            if (Theme.pickedTheme != null)
            {
                BackColor = Theme.pickedTheme.light;
                btnSave.BackColor = Theme.pickedTheme.dark;
                foreach (Control control in this.Controls)
                {
                    if (control is Label)
                    {
                        control.Font = new Font(control.Font, Theme.pickedTheme.fontStyle);
                    }
                    else if (control is TextBox box)
                    {
                        boxes.Add(box);
                    }
                }
                boxes = boxes.OrderBy(x => x.TabIndex).ToList();
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
            btnShowPassword.BackgroundImage = textBoxPassword.UseSystemPasswordChar ? Properties.Resources.show : Properties.Resources.hide;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxLastname.Text)
                || String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxEmail.Text)
                || String.IsNullOrEmpty(textBoxPhone.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show(Properties.Resources.incompleteData, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (employee.username != textBoxUsername.Text && Common.UsernameExists(textBoxUsername.Text))
                {
                    MessageBox.Show(Properties.Resources.usernameExists, Properties.Resources.error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    employee.name = textBoxName.Text;
                    employee.lastname = textBoxLastname.Text;
                    employee.username = textBoxUsername.Text;
                    employee.email = textBoxEmail.Text;
                    employee.phoneNumber = textBoxPhone.Text;
                    employee.password = textBoxPassword.Text;
                    if (cbTheme.SelectedIndex >= 0)
                        employee.theme = cbTheme.SelectedIndex + 1;
                    if (cbLanguage.SelectedIndex >= 0)
                        employee.language = cbLanguage.SelectedIndex + 1;

                    if (Common.DataFactory.Employees.updateEmployee(employee))
                    {
                        MessageBox.Show(Properties.Resources.successChanges, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadParent?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                }
            }
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox currBox = sender as TextBox;
            int index = boxes.IndexOf(currBox);
            if (e.KeyCode == Keys.Down)
            {
                if (index >= 0 && index != (boxes.Count - 1))
                {
                    boxes[index + 1].Focus();
                }
                else if (index == (boxes.Count - 1))
                {
                    boxes[0].Focus();
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (index > 0)
                {
                    boxes[index - 1].Focus();
                }
                else if (index == 0)
                {
                    boxes[boxes.Count - 1].Focus();
                }
            }
        }
    }
}
