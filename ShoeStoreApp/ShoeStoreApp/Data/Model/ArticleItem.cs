using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.Model
{
    public class ArticleItem
    {
        public int id { get; set; }
        public int size { get; set; }
        public int quantity { get; set; }
        public Article article { get; set; }
    }
}
