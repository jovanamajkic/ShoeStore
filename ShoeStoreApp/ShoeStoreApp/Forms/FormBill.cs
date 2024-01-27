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
    public partial class FormBill : Form
    {
        public FormBill(Bill bill, string employee)
        {
            InitializeComponent();

            List<BillItem> items = Common.DataFactory.BillItems.GetItems(bill.id);

            foreach (BillItem item in items)
            {
                dataGridViewElements.Rows.Add(item.articleItem.article.idArticle, item.articleItem.article.name, item.articleItem.size, item.quantity, item.price);
            }

            labelPrice.Text = bill.totalPrice.ToString() + " KM";
            labelDateTime.Text += bill.date.ToString();

            if (String.IsNullOrEmpty(employee))
            {
                Employee e = Common.DataFactory.Employees.getById(bill.employeeId);
                labelEmployee.Text += e.name + " " + e.lastname;
            }
            else
            {
                labelEmployee.Text += employee;
            }

            BackColor = Theme.pickedTheme.light;
            dataGridViewElements.BackgroundColor = BackColor;
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    control.Font = new Font(control.Font, Theme.pickedTheme.fontStyle);
                }
            }
        }

    }
}
