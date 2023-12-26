using Job.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Job.Core.Entities;
using Job.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpressJobApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeServer;
        public EmployeeController(EmployeeService employeeServer)
        {
            _employeeServer = employeeServer;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeServer.GetList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeServer.Get(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee newEmployee)
        {
           _employeeServer.Post(newEmployee);
        }
       

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee emp)
        {
            _employeeServer.Put(id, emp);
        }
        [HttpPut("{id}/status")]
        public void PutStatus(int id )
        {
            _employeeServer.PutStatus(id);
        }


    }
}
