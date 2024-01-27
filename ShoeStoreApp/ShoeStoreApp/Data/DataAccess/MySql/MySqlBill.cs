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
    public class MySqlBill : IBill
    {
        private static readonly string SELECT = "SELECT * FROM `Bill`";
        private static readonly string INSERT = "INSERT INTO `Bill` (date, totalPrice, Employee_id) VALUES (@date, @price, @eId)";

        public int AddBill(Bill bill)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            int id = 0;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@date", bill.date);
                cmd.Parameters.AddWithValue("@price", bill.totalPrice);
                cmd.Parameters.AddWithValue("@eId", bill.employeeId);
                cmd.ExecuteNonQuery();
                id = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBill", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return id;
        }

        public List<Bill> GetAll()
        {
            List<Bill> bills = new List<Bill>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bills.Add(new Bill()
                    {
                        id = reader.GetInt32(0),
                        date = reader.GetDateTime(1),
                        totalPrice = (double)reader.GetDecimal(2),
                        employeeId = reader.GetInt32(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlBill", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return bills;
        }
    }
}
