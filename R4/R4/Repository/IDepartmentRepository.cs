using R4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R4.Repository;

namespace R4.Repository
{
    interface IDepartmentRepository:IRepository<Department>
    {
        List<Employee> GetEmployeesByDepartment(int deptId);
    }
}
