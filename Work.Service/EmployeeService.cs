using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;
using Work.Core.Repositories;
using Work.Core.Services;

namespace Work.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task AddAsync(Employee employee)
        {
           await _employeeRepository.AddAsync(employee);
        }

        public async Task DeleteByIdAsync(int id)
        {
           await _employeeRepository.DeleteByIdAsync(id);
        }

        public DbSet<Employee> GetAll()
        {
          return _employeeRepository.GetList();
        }

        public Employee GetById(int id)
        {
           return _employeeRepository.GetById(id);
        }

        public async Task UpdateAsync(Employee employee)
        {
          await _employeeRepository.UpdateAsync(employee);
        }
    }
}
