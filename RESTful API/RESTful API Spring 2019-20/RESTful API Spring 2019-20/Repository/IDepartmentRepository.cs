using RESTful_API_Spring_2019_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGiant_Limited_Spring_2019_20.Repository;

namespace RESTful_API_Spring_2019_20.Repository
{
    interface IDepartmentRepository:IRepository<Department>
    {
        List<Employee> GetEmployeesByDepartment(int deptId);
    }
}
