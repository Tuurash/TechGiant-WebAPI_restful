using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R4.Models;

namespace R4.Repository
{
    interface IEmployeeRepository:IRepository<Employee>
    {
        IEnumerable<Employee> GetHighestPaidEmployees();
    }
}
