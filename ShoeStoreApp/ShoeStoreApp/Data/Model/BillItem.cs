using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.Model
{
    public class BillItem
    {
        public int billId { get; set; }
        public ArticleItem articleItem { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
