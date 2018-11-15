using System.Collections.Generic;
using System.Linq;
using CoreAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPIDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController: ControllerBase
    {
        private IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public List<EmployeeModel> Get()
        {
            return _repo.GetEmployees().ToList();
        }

        [HttpPost]
        public bool Post([FromBody] EmployeeModel employee)
        {
          return  _repo.AddEmployee(employee);
        }
    }
}
