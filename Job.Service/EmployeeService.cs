using Job.Core.Entities;
using Job.Core.Repsitories;
using Job.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Service
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepsitories _employeeRepsitories;
        public EmployeeService(IEmployeeRepsitories employeeRepsitories)
        {
            _employeeRepsitories = employeeRepsitories;
        }

        public Employee Get(int id)
        {
            return _employeeRepsitories.Get(id);
        }

        public DbSet<Employee> GetList()
        {
            return _employeeRepsitories.GetList();
        }

        public void Post(Employee newEmployee)
        {
            _employeeRepsitories.Post(newEmployee);
        }

        public void Put(int id, Employee emp)
        {
            _employeeRepsitories.Put(id, emp);
        }

        public void PutStatus(int id)
        {
           _employeeRepsitories.PutStatus(id);
        }
    }
}
