using ShoeStoreApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp.Data.DataAccess
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        bool addEmployee(Employee employee);
        bool deActivateEmployee(int employeeId, int active);
        bool updateEmployee(Employee employee);
        Employee getById(int id);
    }
}
