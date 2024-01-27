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
    public partial class FormBillsView : Form
    {
        private List<Bill> bills = null;
        Employee employee = null;

        public FormBillsView(Employee employee)
        {
            InitializeComponent();

            bills = Common.DataFactory.Bills.GetAll();
            this.employee = employee;

            foreach (Bill bill in bills)
            {
                if (employee.role == "admin")
                {
                    Employee emp = Common.DataFactory.Employees.getById(bill.employeeId);
                    dataGridViewBills.Rows.Add(bill, bill.date, bill.totalPrice, emp.name + " " + emp.lastname);
                }
                else
                {
                    if (employee.id == bill.employeeId)
                    {
                        dataGridViewBills.Rows.Add(bill, bill.date, bill.totalPrice, employee.name + " " + employee.lastname);
                    }
                }
            }

            dateTimePickerFrom.MaxDate = DateTime.Today;
            dateTimePickerTo.MaxDate = DateTime.Today;

            BackColor = Theme.pickedTheme.light;
            btnFilter.BackColor = Theme.pickedTheme.dark;
            btnReset.BackColor = Theme.pickedTheme.dark;
            foreach (Control control in splitContainer1.Panel1.Controls)
            {
                if (control is Label)
                {
                    control.Font = new Font(control.Font, Theme.pickedTheme.fontStyle);
                }
            }
        }

        private void dataGridViewBills_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Bill b = (Bill)dataGridViewBills.Rows[e.RowIndex].Cells["id"].Value;
            FormBill formBill = new FormBill(b, null);
            formBill.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerFrom.Value.Date;
            DateTime to = dateTimePickerTo.Value.Date;
            foreach (DataGridViewRow row in dataGridViewBills.Rows)
            {
                DateTime date = ((DateTime)row.Cells["date"].Value).Date;
                if (date > to || date < from)
                {
                    row.Visible = false;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewBills.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
