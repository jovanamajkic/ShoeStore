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
    public partial class FormSupplyView : Form
    {
        public FormSupplyView(Supply supply)
        {
            InitializeComponent();

            List<SupplyItem> items = Common.DataFactory.SupplyItem.GetBySupplyId(supply.supplyId);
            foreach (SupplyItem item in items)
            {
                ArticleItem articleItem = Common.DataFactory.ArticleItems.getItemById(item.articleItemId);
                dataGridViewElements.Rows.Add(articleItem.article.idArticle, articleItem.article.name, articleItem.size, item.quantity, item.price);
            }

            Employee employee = Common.DataFactory.Employees.getById(supply.employeeId);
            labelEmployee.Text += employee.name + " " + employee.lastname;
            labelDateTime.Text += supply.date;
            labelPrice.Text = supply.totalPrice.ToString() + " KM";

            BackColor = Theme.pickedTheme.light;
            dataGridViewElements.BackgroundColor = BackColor;
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    control.Font = new Font(control.Font, Theme.pickedTheme.fontStyle);
                }
            }
        }
    }
}
