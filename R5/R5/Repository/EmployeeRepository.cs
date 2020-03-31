using R5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace R5.Repository
{
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {


        public IEnumerable<Employee> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}