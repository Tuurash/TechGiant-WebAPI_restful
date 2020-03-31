using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTful_API_Spring_2019_20.Repository;
using RESTful_API_Spring_2019_20.Models;
using TechGiant_Limited_Spring_2019_20.Repository;
namespace RESTful_API_Spring_2019_20.Controllers
{
    [RoutePrefix("api/departments")]
    public class DepartmentController : ApiController
    {
        IRepository<Department> repo=new DepartmentRepository();
        IDepartmentRepository deptrepo;
        public DepartmentController()
        {
            this.repo = new DepartmentRepository();
            this.deptrepo = new DepartmentRepository();
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(repo.GetAll().ToList());
        }

       [Route("{id}/employees")]
        public IHttpActionResult GetEmployeesByDepartmentId(int id)
        {
            return Ok(deptrepo.GetEmployeesByDepartment(id));
        }

       [Route("{id}", Name = "GetDepartmentById")]
       public IHttpActionResult Get(int id)
       {
           return Ok(repo.Get(id));
       }

        [Route("")]
        public IHttpActionResult Post([FromBody]Department department)
        {
            repo.Insert(department);
            string url = Url.Link("GetDepartmentById", new { id=department.DepartmentId});
            return Created(url,department);
        }
        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Department department, [FromUri]int id)
        {
            department.DepartmentId = id;
            repo.Update(department);
            return Ok(department);
        }

        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            repo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
