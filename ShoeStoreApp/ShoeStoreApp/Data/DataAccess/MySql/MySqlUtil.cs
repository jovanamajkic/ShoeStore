using ShoeStoreApp.Data.DataAccess.Exceptions;
using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace ShoeStoreApp.Data.DataAccess.MySql
{
    public static class MySqlUtil
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["ShoeStore"].ConnectionString;

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static void CloseQuietly(MySqlConnection conn)
        {
            try
            {
                conn?.Close();
            }
            catch { }
        }

        public static void CloseQuietly(MySqlDataReader reader)
        {
            try
            {
                reader?.Close();
            }
            catch { }
        }

        public static void CloseQuietly(MySqlDataReader reader, MySqlConnection conn)
        {
            CloseQuietly(reader);
            CloseQuietly(conn);
        }

        public static Employee SignIn(String username, String password)
        {
            bool signIn = false;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = GetConnection();
                cmd = new MySqlCommand("signin", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@uname", MySqlDbType.String).Value = username;
                cmd.Parameters.Add("@pass", MySqlDbType.String).Value = password;
                cmd.Parameters.Add("@signin", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@IdEmployee", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@R", MySqlDbType.String).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@N", MySqlDbType.String).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@LastN", MySqlDbType.String).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@phoneN", MySqlDbType.String).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@Em", MySqlDbType.String).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@A", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@L", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@T", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["@signin"].Value != DBNull.Value)
                    signIn = Convert.ToBoolean(cmd.Parameters["@signin"].Value);
                if (signIn)
                {
                    Employee e = new Employee()
                    {
                        id = Convert.ToInt32(cmd.Parameters["@IdEmployee"].Value),
                        name = Convert.ToString(cmd.Parameters["@N"].Value),
                        lastname = Convert.ToString(cmd.Parameters["@LastN"].Value),
                        username = username,
                        password = password,
                        email = Convert.ToString(cmd.Parameters["@Em"].Value),
                        phoneNumber = Convert.ToString(cmd.Parameters["@phoneN"].Value),
                        role = Convert.ToString(cmd.Parameters["@R"].Value),
                        active = Convert.ToBoolean(cmd.Parameters["@A"].Value),
                        language = Convert.ToInt32(cmd.Parameters["@L"].Value),
                        theme = Convert.ToInt32(cmd.Parameters["@T"].Value)
                    };
                    return e;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySQLUtil", ex);
            }
            finally
            {
                CloseQuietly(conn);
            }
        }
    }
}
