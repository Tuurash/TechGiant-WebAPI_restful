using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGiant_Limited_Spring_2019_20.Models;

namespace TechGiant_Limited_Spring_2019_20.Repository
{
    interface IEmployeeRepository:IRepository<Employee>
    {
        IEnumerable<Employee> GetHighestPaidEmployees();
    }
}
