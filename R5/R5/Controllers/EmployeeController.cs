using R5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using R5.Repository;

namespace R5.Controllers
{
    [RoutePrefix("api/employees")]
    public class EmployeeController : ApiController
    {
        IRepository<Employee> repo = new EmployeeRepository();
        public EmployeeController()
        {
            this.repo = new EmployeeRepository();
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll().ToList());
        }

        [Route("{id}", Name = "GetEmployeeById")]
        public IHttpActionResult Get(int id)
        {
            Employee employee = repo.Get(id);
            employee.Links.Add(new Links() { HRef = "http://localhost:4468/api/employees", Method = "GET", Rel = "Get all the employee list" });
            employee.Links.Add(new Links() { HRef = "http://localhost:4468/api/employees", Method = "POST", Rel = "Create a new Employee resource" });
            employee.Links.Add(new Links() { HRef = "http://localhost:4468/api/employees/" + employee.EmployeeId, Method = "PUT", Rel = "Modify an existing Employee resource" });
            employee.Links.Add(new Links() { HRef = "http://localhost:4468/api/employees/" + employee.EmployeeId, Method = "DELETE", Rel = "Delete an existing Employee resource" });
            return Ok(employee);
        }
        [Route("")]
        public IHttpActionResult Post([FromBody]Employee employee)
        {
            repo.Insert(employee);
            string url = Url.Link("GetEmployeeById", new { id = employee.EmployeeId });
            return Created(url, employee);
        }
        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Employee employee, [FromUri]int id)
        {
            employee.EmployeeId = id;
            repo.Update(employee);
            return Ok(employee);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
