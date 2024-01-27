using MySql.Data.MySqlClient;
using ShoeStoreApp.Data.DataAccess.Exceptions;
using ShoeStoreApp.Data.Model;
using ShoeStoreApp.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess.MySql
{
    public class MySqlArticle : IArticle
    {
        private static readonly string SELECT = "SELECT * FROM `Article` WHERE active=1 ORDER BY idArticle";
        private static readonly string SELECT_ID = "SELECT * FROM `Article` WHERE idArticle=@id";
        private static readonly string UPDATE_ACTIVE = "UPDATE `Article` SET active=0 WHERE idArticle=@id";
        private static readonly string UPDATE = "UPDATE `Article` SET name=@name, picture=@picture, supplyPrice=@supplyPrice, sellPrice=@sellPrice, Gender_id=@gId, ArticleType_id=@tId WHERE idArticle=@id";
        private static readonly string INSERT = "INSERT INTO `Article`(idArticle, name, picture, supplyPrice, sellPrice, Gender_id, ArticleType_id, active) VALUES (@id, @name, @picture, @supply, @sell, @gId, @tId, 1)";
        public bool AddArticle(Article article)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@id", article.idArticle);
                cmd.Parameters.AddWithValue("@name", article.name);
                cmd.Parameters.AddWithValue("@picture", article.picture);
                cmd.Parameters.AddWithValue("@supply", article.supplyPrice);
                cmd.Parameters.AddWithValue("@sell", article.sellPrice);
                cmd.Parameters.AddWithValue("@gId", article.genderId);
                cmd.Parameters.AddWithValue("@tId", article.typeId);
                res = cmd.ExecuteNonQuery() == 1;

                if (res)
                {
                    int[] sizes = { 37, 38, 39, 40, 41, 42, 43, 44, 45 };
                    foreach (int s in sizes)
                    {
                        ArticleItem item = new ArticleItem
                        {
                            size = s,
                            quantity = 0,
                            article = article
                        };
                        Common.DataFactory.ArticleItems.AddArticleItem(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticle", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }

        public bool DeleteArticle(Article article)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE_ACTIVE;
                cmd.Parameters.AddWithValue("@id", article.idArticle);
                res = cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticle", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }

        public List<Article> GetAll()
        {
            List<Article> articles = new List<Article>();
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
                    articles.Add(new Article()
                    {
                        idArticle = reader.GetInt32(0),
                        name = reader.GetString(1),
                        picture = reader.GetString(2),
                        supplyPrice = (double)reader.GetDecimal(3),
                        sellPrice = (double)reader.GetDecimal(4),
                        genderId = reader.GetInt32(5),
                        typeId = reader.GetInt32(6),
                        active = reader.GetBoolean(7)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticle", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return articles;
        }

        public Article GetArticle(int id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            Article article = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_ID;
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                reader.Read();
                article = new Article()
                {
                    idArticle = reader.GetInt32(0),
                    name = reader.GetString(1),
                    picture = reader.GetString(2),
                    supplyPrice = (double)reader.GetDecimal(3),
                    sellPrice = (double)reader.GetDecimal(4),
                    genderId = reader.GetInt32(5),
                    typeId = reader.GetInt32(6),
                    active = reader.GetBoolean(7)
                };
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticle", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return article;
        }

        public bool UpdateArticle(Article article)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@name", article.name);
                cmd.Parameters.AddWithValue("@picture", article.picture);
                cmd.Parameters.AddWithValue("@supplyPrice", article.supplyPrice);
                cmd.Parameters.AddWithValue("@sellPrice", article.sellPrice);
                cmd.Parameters.AddWithValue("@gId", article.genderId);
                cmd.Parameters.AddWithValue("@tId", article.typeId);
                cmd.Parameters.AddWithValue("@id", article.idArticle);
                res = cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticle", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }
    }
}
