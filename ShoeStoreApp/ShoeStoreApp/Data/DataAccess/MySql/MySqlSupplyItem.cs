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
    public class MySqlSupplyItem : ISupplyItem
    {
        private static readonly string INSERT = "INSERT INTO `SupplyItem` (quantity, price, ArticleItem_id, Supply_idSupply) VALUES (@quantity, @price, @aId, @sId)";
        private static readonly string SELECT = "SELECT * FROM `SupplyItem` WHERE Supply_idSupply=@id";
        public bool AddSuplyItem(SupplyItem item)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@quantity", item.quantity);
                cmd.Parameters.AddWithValue("@price", item.price);
                cmd.Parameters.AddWithValue("@aId", item.articleItemId);
                cmd.Parameters.AddWithValue("@sId", item.supplyId);
                res = cmd.ExecuteNonQuery() == 1;
                if (res)
                {
                    int quantity = Common.DataFactory.ArticleItems.getItemById(item.articleItemId).quantity;
                    quantity += item.quantity;
                    Common.DataFactory.ArticleItems.UpdateQuantity(item.articleItemId, quantity);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlSupply", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }

        public List<SupplyItem> GetBySupplyId(int supplyId)
        {
            List<SupplyItem> items = new List<SupplyItem>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                cmd.Parameters.AddWithValue("@id", supplyId);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(new SupplyItem()
                    {
                        id = reader.GetInt32(0),
                        quantity = reader.GetInt32(1),
                        price = (double)reader.GetDecimal(2),
                        articleItemId = reader.GetInt32(3),
                        supplyId = reader.GetInt32(4)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlSupplyItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return items;
        }
    }
}
