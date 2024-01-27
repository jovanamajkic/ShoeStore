using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess
{
    public interface ISupplyItem
    {
        bool AddSuplyItem(SupplyItem item);
        List<SupplyItem> GetBySupplyId(int supplyId);
    }
}
