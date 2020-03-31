using RESTful_API_Spring_2019_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TechGiant_Limited_Spring_2019_20.Repository
{
    public class EmployeeRepository:Repository<Employee>,IEmployeeRepository
    {


        public IEnumerable<Employee> GetHighestPaidEmployees()
        {
            throw new NotImplementedException();
        }
    }
}