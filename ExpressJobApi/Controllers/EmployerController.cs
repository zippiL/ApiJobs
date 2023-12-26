using Job.Core.Entities;
using Job.Core.Services;
using Job.Service;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpressJobApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerService _employerService;
        public EmployerController(IEmployerService employerService)
        {
            _employerService = employerService;
        }

        // GET: api/<EmployerController>
        [HttpGet]
        public IEnumerable<Employer> Get()
        {
            return _employerService.GetList();
        }

        // GET api/<EmployerController>/5
        [HttpGet("{id}")]
        public Employer Get(int id)
        {
            return _employerService.Get(id);
        }

        // POST api/<EmployerController>
        [HttpPost]
        public void Post([FromBody] Employer newEmployer)
        {
            _employerService.Post(newEmployer);
        }


        // PUT api/<EmployerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employer emp)
        {
            _employerService.Put(id, emp);
        }
        [HttpPut("{id}/status")]
        public void PutStatus(int id)
        {
            _employerService.PutStatus(id);
        }


    }
}
