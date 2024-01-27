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
    public class MySqlSupplier : ISupplier
    {
        private static readonly string SELECT_ID = "SELECT * FROM `Supplier` WHERE id=@id";
        private static readonly string SELECT = "SELECT * FROM `Supplier`";
        public Supplier GetSupplier(int id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Supplier supplier = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID;
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    supplier = new Supplier()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        PhoneNumber = reader.GetString(2),
                        Email = reader.GetString(3)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlSupplier", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return supplier;
        }

        public List<Supplier> GetSuppliers()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            List<Supplier> suppliers = new List<Supplier>();
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    suppliers.Add(new Supplier()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        PhoneNumber = reader.GetString(2),
                        Email = reader.GetString(3)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlSupplier", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return suppliers;
        }
    }
}
