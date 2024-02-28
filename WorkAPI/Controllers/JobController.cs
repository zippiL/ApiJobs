using Microsoft.AspNetCore.Mvc;
using Work.Core.Entities;
using Work.Core.Services;
using Work.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }
        // GET: api/<JobController>
        [HttpGet]
        public IEnumerable<Job> Get()
        {
            return _jobService.GetAll();
        }

        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public Job Get(int id)
        {
            return _jobService.GetById(id);
        }

        // POST api/<JobController>
        [HttpPost]
        public async Task<Job> Post([FromBody] Job job)
        { 
            return await _jobService.AddAsync(job);
        }

        // PUT api/<JobController>/5
        [HttpPut("{id}")]
        public async Task<Job> Put( [FromBody] Job job)
        {
           return await _jobService.UpdateAsync(job);
        }

        // DELETE api/<JobController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _jobService.DeleteByIdAsync(id);
        }
    }
}
