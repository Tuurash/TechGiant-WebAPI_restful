using R5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using R5.Repository;


namespace R5.Repository
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