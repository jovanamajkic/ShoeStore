using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.Model
{
    public class Supply
    {
        public int supplyId { get; set; }
        public DateTime date { get; set; }
        public double totalPrice { get; set; }
        public int employeeId { get; set; }
        public int supplierId { get; set; }

        public override string ToString()
        {
            return supplyId.ToString();
        }
    }
}
