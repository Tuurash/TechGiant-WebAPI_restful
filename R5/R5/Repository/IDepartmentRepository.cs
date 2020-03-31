using R5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R5.Repository;

namespace R5.Repository
{
    interface IDepartmentRepository:IRepository<Department>
    {
        List<Employee> GetEmployeesByDepartment(int deptId);
    }
}
