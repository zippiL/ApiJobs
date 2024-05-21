using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Work.Core.DTOs;
using Work.Core.Entities;
using Work.Core.Services;
using WorkAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WorkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeeController(IEmployeeService employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult Get()
        {
            var list=_employeeService.GetAll();
            var listDto=_mapper.Map<IEnumerable<EmployeeDto>>(list);
            return Ok(listDto);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _employeeService.GetById(id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task Post([FromBody] EmployeePostModel employee)
        {
            //await _employeeService.AddAsync(employee);
            await _employeeService.AddAsync(_mapper.Map<Employee>(employee));

        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task Put( [FromBody] Employee employee)
        {
           await _employeeService.UpdateAsync(employee);
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _employeeService.DeleteByIdAsync(id);
        }
    }
}
