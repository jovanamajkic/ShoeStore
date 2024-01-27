using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess
{
    public interface ISupplier
    {
        Supplier GetSupplier(int id);
        List<Supplier> GetSuppliers();
    }
}
