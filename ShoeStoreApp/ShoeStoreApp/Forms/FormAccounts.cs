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
    public partial class FormAccounts : Form
    {
        private Employee admin;
        public FormAccounts(Employee me)
        {
            InitializeComponent();
            admin = me;
            FillTable();

            BackColor = Theme.pickedTheme.light;
            splitContainerContent.BackColor = BackColor;
            btnFilter.BackColor = Theme.pickedTheme.dark;
            btnReset.BackColor = Theme.pickedTheme.dark;
            lblRole.Font = new Font(lblRole.Font, Theme.pickedTheme.fontStyle);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchValue = searchBox.Text.Trim().ToLower();

            foreach (DataGridViewRow row in dataGridViewAccounts.Rows)
            {
                string cellValue = row.Cells["account"].Value.ToString().ToLower();
                row.Visible = cellValue.Contains(searchValue);
            }
        }

        private void dataGridViewAccounts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employee = (Employee)dataGridViewAccounts.Rows[e.RowIndex].Cells["account"].Value;
            FormAccount formAccount = new FormAccount(employee);
            if (formAccount.ShowDialog() == DialogResult.OK)
            {
                dataGridViewAccounts.Rows.Clear();
                FillTable();
            }
        }

        private void FillTable()
        {
            List<Employee> employees = Common.DataFactory.Employees.GetEmployees();
            foreach (Employee emp in employees)
            {
                if (emp.id != admin.id)
                {
                    dataGridViewAccounts.Rows.Add(emp);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex > -1)
            {
                bool active = cbStatus.SelectedIndex == 0;

                foreach (DataGridViewRow row in dataGridViewAccounts.Rows)
                {
                    Employee emp = (Employee)row.Cells["account"].Value;
                    row.Visible = (emp.active == active);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAccounts.Rows)
            {
                row.Visible = true;
            }
            cbStatus.SelectedIndex = -1;
        }
    }
}
