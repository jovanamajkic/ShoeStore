using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.Model
{
    public class Bill
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public double totalPrice { get; set; }
        public int employeeId { get; set; }

        public override string ToString()
        {
            return id.ToString();
        }
    }
}
