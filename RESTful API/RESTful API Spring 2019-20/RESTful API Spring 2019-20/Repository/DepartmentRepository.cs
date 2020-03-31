using RESTful_API_Spring_2019_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechGiant_Limited_Spring_2019_20.Repository;


namespace RESTful_API_Spring_2019_20.Repository
{
    public class DepartmentRepository:Repository<Department>,IDepartmentRepository
    {
        TechGiantDataContext context;
        public DepartmentRepository()
        {
            context = new TechGiantDataContext();
        }
        public List<Employee> GetEmployeesByDepartment(int deptId)
        {
            List<Employee> list = context.Employees.Where(emp=>emp.DepartmentId==deptId).ToList();
            return list;
        }
    }
}