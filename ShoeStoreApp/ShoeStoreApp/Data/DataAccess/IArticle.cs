using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess
{
    public interface IArticle
    {
        List<Article> GetAll();
        Article GetArticle(int id);
        bool AddArticle(Article article);
        bool UpdateArticle(Article article);
        bool DeleteArticle(Article article);
    }
}
