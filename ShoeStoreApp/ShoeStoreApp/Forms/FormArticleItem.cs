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
    public partial class FormArticleItem : System.Windows.Forms.Form
    {
        public FormArticleItem(List<ArticleItem> items)
        {
            InitializeComponent();

            foreach (ArticleItem item in items)
            {
                dataGridViewSizes.Rows.Add(item.size, item.quantity);
            }

            foreach (Control control in Controls)
            {
                control.Font = new Font(control.Font, Theme.pickedTheme.fontStyle);
            }
        }

    }
}
