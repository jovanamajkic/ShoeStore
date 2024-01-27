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
    public class MySqlArticleItem : IArticleItem
    {
        private static readonly string SELECT = "SELECT * FROM `ArticleItem` WHERE Article_idArticle=@id";
        private static readonly string SELECT_id = "SELECT * FROM `ArticleItem` WHERE Article_idArticle=@aid and size=@s";
        private static readonly string INSERT = "INSERT INTO `ArticleItem` (size, quantity, Article_idArticle) VALUES (@s, @q, @aId)";
        private static readonly string SELECT_item = "SELECT * FROM `ArticleItem` WHERE id=@id";
        private static readonly string DELETE = "DELETE FROM `ArticleItem` WHERE Article_idArticle=@id";
        private static readonly string UPDATE = "UPDATE `ArticleItem` SET quantity=@q WHERE id=@id";

        public void AddArticleItem(ArticleItem item)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@s", item.size);
                cmd.Parameters.AddWithValue("@q", item.quantity);
                cmd.Parameters.AddWithValue("aId", item.article.idArticle);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticleItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }

        public bool DeleteItems(int articleId)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            bool res = false;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@id", articleId);
                res = cmd.ExecuteNonQuery() == 1;
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticleItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return res;
        }

        public ArticleItem getArticleItem(int articleId, int size)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            ArticleItem item = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_id;
                cmd.Parameters.AddWithValue("@aId", articleId);
                cmd.Parameters.AddWithValue("@s", size);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    item = new ArticleItem()
                    {
                        id = reader.GetInt32(0),
                        size = reader.GetInt32(1),
                        quantity = reader.GetInt32(2),
                        article = Common.DataFactory.Article.GetArticle(articleId)
                    };
                }

            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticleItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return item;
        }

        public ArticleItem getItemById(int id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            ArticleItem item = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT_item;
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    item = new ArticleItem()
                    {
                        id = reader.GetInt32(0),
                        size = reader.GetInt32(1),
                        quantity = (int)reader.GetDecimal(2),
                        article = Common.DataFactory.Article.GetArticle(reader.GetInt32(3))
                    };
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticleItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return item;
        }

        public List<ArticleItem> getItemsByArticle(int idArticle)
        {
            List<ArticleItem> articles = new List<ArticleItem>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = SELECT;
                cmd.Parameters.AddWithValue("@id", idArticle);
                reader = cmd.ExecuteReader();
                Article art = Common.DataFactory.Article.GetArticle(idArticle) as Article;
                while (reader.Read())
                {
                    articles.Add(new ArticleItem()
                    {
                        id = reader.GetInt32(0),
                        size = reader.GetInt32(1),
                        quantity = reader.GetInt32(2),
                        article = art
                    });
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticleItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return articles;
        }

        public void UpdateQuantity(int id, int quantity)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@q", quantity);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new DataAccessException("Exception in MySqlArticleItem", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
        }
    }
}
