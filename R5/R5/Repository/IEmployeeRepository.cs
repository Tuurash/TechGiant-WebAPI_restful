using R5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace R5.Repository
{
    interface IEmployeeRepository:IRepository<Employee>
    {
        IEnumerable<Employee> GetHighestPaidEmployees();
    }
}
