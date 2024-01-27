using ShoeStoreApp.Data.DataAccess;
using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Util
{
    public static class Common
    {
        private static DataFactory dataFactory;
        public static DataFactory DataFactory
        {
            get
            {
                if (dataFactory == null)
                {
                    dataFactory = DataFactory.GetDataFactory();
                }
                return dataFactory;
            }
        }

        public static int[] Sizes = new int[] { 37, 38, 39, 40, 41, 42, 43, 44, 45 };

        public static bool UsernameExists(string username)
        {
            List<Employee> employees = DataFactory.Employees.GetEmployees();
            foreach (Employee employee in employees)
            {
                if (employee.username == username)
                    return true;
            }
            return false;
        }

    }
}
