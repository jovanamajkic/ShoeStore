using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.Model
{
    public class Gender
    {
        public int id { get; set; }
        public string gender { get; set; }

        public override string ToString()
        {
            return gender;
        }
    }
}
