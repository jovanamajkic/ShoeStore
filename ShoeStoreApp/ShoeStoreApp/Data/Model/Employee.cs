using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.Model
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string role { get; set; }
        public bool active { get; set; }
        public int theme { get; set; }
        public int language { get; set; }

        public override string ToString()
        {
            return name + " " + lastname;
        }
    }
}
