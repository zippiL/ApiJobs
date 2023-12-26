using Job.Core.Entities;
using Job.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpressJobApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly IWorkService _workService;
        public WorkController(IWorkService workService)
        {
            _workService = workService;   
        }
        // GET: api/<JobController>
        [HttpGet]
        public IEnumerable<Work> Get()
        {
            return _workService.GetList();
        }

        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public Work Get(int id)
        {
            return _workService.Get(id);
        }

        // POST api/<JobController>
        [HttpPost]
        public void Post([FromBody] Work value)
        {
           _workService.Post(value);
        }

        // PUT api/<JobController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Work value)
        {
           _workService.Put(id, value);
        }

            // DELETE api/<JobController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            _workService.Delete(id);
            }
        }
    }
