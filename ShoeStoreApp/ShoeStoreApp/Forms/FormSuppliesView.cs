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
    public partial class FormSuppliesView : Form
    {
        public FormSuppliesView()
        {
            InitializeComponent();

            List<Supply> supplies = Common.DataFactory.Supply.getAll();
            foreach (Supply supply in supplies)
            {
                Employee employee = Common.DataFactory.Employees.getById(supply.employeeId);
                string supplier = Common.DataFactory.Supplier.GetSupplier(supply.supplierId).Name;
                dataGridViewSupplies.Rows.Add(supply, supply.date, supply.totalPrice, employee.name + " " + employee.lastname, supplier);
            }

            dateTimePickerFrom.MaxDate = DateTime.Today;
            dateTimePickerTo.MaxDate = DateTime.Today;

            splitContainer1.BackColor = Theme.pickedTheme.light;
            btnFilter.BackColor = Theme.pickedTheme.dark;
            btnReset.BackColor = Theme.pickedTheme.dark;
            lblDateFrom.Font = new Font(lblDateFrom.Font, Theme.pickedTheme.fontStyle);
            lblDateTo.Font = new Font(lblDateTo.Font, Theme.pickedTheme.fontStyle);
        }

        private void dataGridViewSupplies_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Supply supply = dataGridViewSupplies.Rows[e.RowIndex].Cells["id"].Value as Supply;
            FormSupplyView supplyView = new FormSupplyView(supply);
            supplyView.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerFrom.Value.Date;
            DateTime to = dateTimePickerTo.Value.Date;
            foreach (DataGridViewRow row in dataGridViewSupplies.Rows)
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
            foreach (DataGridViewRow row in dataGridViewSupplies.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
