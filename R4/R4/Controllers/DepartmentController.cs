using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using R4.Models;
using R4.Repository;

namespace R4.Controllers
{
    public class DepartmentController : ApiController
    {
        IRepository<Department> repo;

        public DepartmentController()
        {
            this.repo = new DepartmentRepository();
        }

        [Route("api/departments")]
        public IHttpActionResult GetAllDepaartments()
        {
            return Ok(repo.GetAll());
        }

    }
}
