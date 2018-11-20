using System.Collections.Generic;
using System.Linq;
using CoreAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPIDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController: ControllerBase
    {
        private IPatientRepository _repo;

        public PatientController(IPatientRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public List<PatientModel> Get()
        {
            return _repo.GetEmployees().ToList();
        }

        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            return _repo.GetEmployeeById(id);
        }

        [HttpPost]
        public bool Post([FromBody] PatientModel employee)
        {
          return  _repo.AddEmployee(employee);
        }
    }
}
