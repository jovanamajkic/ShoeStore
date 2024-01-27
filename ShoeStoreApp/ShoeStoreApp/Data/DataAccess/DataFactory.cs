using ShoeStoreApp.Data.DataAccess.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess
{
    public abstract class DataFactory
    {
        public abstract IEmployee Employees { get; }
        public abstract IArticle Article { get; }
        public abstract IArticleProperties ArticleProperties { get; }
        public abstract IArticleItem ArticleItems { get; }
        public abstract ISupply Supply { get; }
        public abstract ISupplyItem SupplyItem { get; }
        public abstract IBill Bills { get; }
        public abstract IBillItem BillItems { get; }
        public abstract ISupplier Supplier { get; }

        public static DataFactory GetDataFactory() { return new MySqlDataFactory(); }
    }
}
