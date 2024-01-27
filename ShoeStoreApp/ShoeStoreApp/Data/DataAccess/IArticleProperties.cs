using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess
{
    public interface IArticleProperties
    {
        List<Gender> GetGenders();
        List<ArticleType> GetArticleTypes();
    }
}
