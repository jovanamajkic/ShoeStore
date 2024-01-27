using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.Model
{
    public class Article
    {
        public int idArticle { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public double supplyPrice { get; set; }
        public double sellPrice { get; set; }
        public int genderId { get; set; }
        public int typeId { get; set; }
        public bool active { get; set; }

        public override string ToString()
        {
            return idArticle + " " + name;
        }
    }
}
