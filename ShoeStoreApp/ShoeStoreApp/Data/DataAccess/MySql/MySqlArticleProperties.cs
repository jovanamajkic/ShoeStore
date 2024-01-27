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
    public class MySqlArticleProperties : IArticleProperties
    {
        private static readonly string SELECT_G = "SELECT * FROM `Gender` ORDER BY id";
        private static readonly string SELECT_T = "SELECT * FROM `ArticleType` ORDER BY id";

        public List<ArticleType> GetArticleTypes()
        {
            List<ArticleType> types = new List<ArticleType>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_T;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    types.Add(new ArticleType()
                    {
                        id = reader.GetInt32(0),
                        type = reader.GetString(1)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticleProperties", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return types;
        }

        public List<Gender> GetGenders()
        {
            List<Gender> genders = new List<Gender>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_G;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    genders.Add(new Gender()
                    {
                        id = reader.GetInt32(0),
                        gender = reader.GetString(1),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticleProperties", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return genders;
        }
    }
}
