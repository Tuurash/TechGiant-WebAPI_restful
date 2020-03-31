using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using R4.Models;

namespace R4.Repository
{
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {

        public IEnumerable<Employee> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}