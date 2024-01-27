using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess.MySql
{
    public class MySqlDataFactory : DataFactory
    {
        private MySqlEmployee mySqlEmployee;
        private MySqlArticle mySqlArticle;
        private MySqlArticleProperties mySqlArticleProperties;
        private MySqlArticleItem mySqlArticleItem;
        private MySqlSupply mySqlSupply;
        private MySqlSupplyItem mySqlSupplyItem;
        private MySqlBill mySqlBill;
        private MySqlBillItem mySqlBillItem;
        private MySqlSupplier mySqlSupplier;

        public override IEmployee Employees
        {
            get
            {
                if (mySqlEmployee == null)
                {
                    mySqlEmployee = new MySqlEmployee();
                }
                return mySqlEmployee;
            }
        }

        public override IArticle Article
        {
            get
            {
                if (mySqlArticle == null)
                {
                    mySqlArticle = new MySqlArticle();
                }
                return mySqlArticle;
            }
        }

        public override IArticleProperties ArticleProperties
        {
            get
            {
                if (mySqlArticleProperties == null)
                {
                    mySqlArticleProperties = new MySqlArticleProperties();
                }
                return mySqlArticleProperties;
            }
        }

        public override IArticleItem ArticleItems
        {
            get
            {
                if (mySqlArticleItem == null)
                {
                    mySqlArticleItem = new MySqlArticleItem();
                }
                return mySqlArticleItem;
            }
        }

        public override ISupply Supply
        {
            get
            {
                if (mySqlSupply == null)
                {
                    mySqlSupply = new MySqlSupply();
                }
                return mySqlSupply;
            }
        }

        public override ISupplyItem SupplyItem
        {
            get
            {
                if (mySqlSupplyItem == null)
                {
                    mySqlSupplyItem = new MySqlSupplyItem();
                }
                return mySqlSupplyItem;
            }
        }

        public override IBill Bills
        {
            get
            {
                if (mySqlBill == null)
                {
                    mySqlBill = new MySqlBill();
                }
                return mySqlBill;
            }
        }

        public override IBillItem BillItems
        {
            get
            {
                if (mySqlBillItem == null)
                {
                    mySqlBillItem = new MySqlBillItem();
                }
                return mySqlBillItem;
            }
        }

        public override ISupplier Supplier
        {
            get
            {
                if (mySqlSupplier == null)
                {
                    mySqlSupplier = new MySqlSupplier();
                }
                return mySqlSupplier;
            }
        }
    }
}
