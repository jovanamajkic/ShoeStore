using MySql.Data.MySqlClient;
using ShoeStoreApp.Data.DataAccess.Exceptions;
using ShoeStoreApp.Data.Model;
using ShoeStoreApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess.MySql
{
    public class MySqlBillItem : IBillItem
    {
        private static readonly string SELECT = "SELECT * FROM `BillItem` WHERE Bill_id=@id";
        private static readonly string INSERT = "INSERT INTO `BillItem` (Bill_id, ArticleItem_id, quantity, price) VALUES (@bId, @aId, @q, @p)";
        public bool AddItem(BillItem item)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@bId", item.billId);
                cmd.Parameters.AddWithValue("@aId", item.articleItem.id);
                cmd.Parameters.AddWithValue("@q", item.quantity);
                cmd.Parameters.AddWithValue("@p", item.price);
                res = cmd.ExecuteNonQuery() == 1;
                if (res)
                {
                    int quantity = Common.DataFactory.ArticleItems.getItemById(item.articleItem.id).quantity;
                    quantity -= item.quantity;
                    Common.DataFactory.ArticleItems.UpdateQuantity(item.articleItem.id, quantity);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBillItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }

        public List<BillItem> GetItems(int billId)
        {
            List<BillItem> items = new List<BillItem>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                cmd.Parameters.AddWithValue("@id", billId);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(new BillItem()
                    {
                        quantity = reader.GetInt32(0),
                        price = (double)reader.GetDecimal(1),
                        billId = billId,
                        articleItem = Common.DataFactory.ArticleItems.getItemById(reader.GetInt32(3))
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBillItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return items;
        }
    }
}
