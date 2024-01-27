using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess
{
    public interface IBillItem
    {
        List<BillItem> GetItems(int billId);
        bool AddItem(BillItem item);
    }
}
