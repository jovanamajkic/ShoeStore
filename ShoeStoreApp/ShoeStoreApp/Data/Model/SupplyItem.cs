using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.Model
{
    public class SupplyItem
    {
        public int id { get; set; }
        public int articleItemId { get; set; }
        public int supplyId { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
    }
}
