using MySql.Data.MySqlClient;
using ShoeStoreApp.Data.DataAccess.Exceptions;
using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess.MySql
{
    public class MySqlSupply : ISupply
    {
        private static readonly string SELECT = "SELECT * FROM `Supply`";
        private static readonly string INSERT = "INSERT INTO `Supply`(totalPrice, date, Employee_id, Supplier_id) VALUES (@price, @date, @eId, @sId)";
        public int addSupply(Supply supply)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@price", supply.totalPrice);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@eId", supply.employeeId);
                cmd.Parameters.AddWithValue("@sId", supply.supplierId);
                cmd.ExecuteNonQuery();
                supply.supplyId = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlSupply", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return supply.supplyId;
        }

        public List<Supply> getAll()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            List<Supply> list = new List<Supply>();
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Supply()
                    {
                        supplyId = reader.GetInt32(0),
                        date = reader.GetDateTime(1),
                        totalPrice = (double)reader.GetDecimal(2),
                        employeeId = reader.GetInt32(3),
                        supplierId = reader.GetInt32(4)
                    });
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
            return list;
        }
    }
}
