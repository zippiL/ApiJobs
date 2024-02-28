using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;
using Work.Core.Repositories;

namespace Work.data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task DeleteByIdAsync(int id)
        {
            Employee e = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (e != null)
            {
                _context.Employees.Remove(e);
               await _context.SaveChangesAsync();
            }
        }

        public Employee GetById(int id)
        {
            return _context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public DbSet<Employee> GetList()
        {
            return _context.Employees;
        }

        public async Task UpdateAsync(Employee employee)
        {
            Employee e = _context.Employees.FirstOrDefault(e => e.Id == employee.Id);
            if (e != null)
            {
                e.Status = employee.Status;
                e.ExperienceYears = employee.ExperienceYears;
                e.TypeJob = employee.TypeJob;
                e.Email = employee.Email;
                e.Name = employee.Name;

            }
            else
                _context.Employees.Add(employee);
           await _context.SaveChangesAsync();
        }

        public async Task AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }
    }
}
