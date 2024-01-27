using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess
{
    public interface IArticleItem
    {
        List<ArticleItem> getItemsByArticle(int idArticle);
        ArticleItem getArticleItem(int articleId, int size);
        ArticleItem getItemById(int id);
        void AddArticleItem(ArticleItem item);
        bool DeleteItems(int articleId);
        void UpdateQuantity(int id, int quantity);
    }
}
