using Job.Core.Entities;
using Job.Core.Repsitories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Data.Repsitories
{
    public class EmployeeRepsitories : IEmployeeRepsitories
    {
        private readonly DataContex _contex;
        public EmployeeRepsitories(DataContex contex)
        {
            _contex = contex;
        }
        public DbSet<Employee> GetList()
        {
            return _contex.employees;
        }
        public Employee Get(int id)
        {
            return _contex.employees.Find(id);
        }
      

        public Employee Post(Employee newEmployee)
        {
            _contex.employees.Add(newEmployee);
            _contex.SaveChanges();
            return newEmployee;
        }

        public Employee Put(int id, Employee emp)
        {
            Employee empToUpdate = _contex.employees.ToList().Find(e => e.Id == id);
            if (empToUpdate != null)
            {
                empToUpdate.Id = emp.Id;
                empToUpdate.Name = emp.Name;
                empToUpdate.Email = emp.Email;
                empToUpdate.ExperienceYears = emp.ExperienceYears;
                empToUpdate.TypeJob = emp.TypeJob;
                empToUpdate.Status = emp.Status;
            }
            else
                _contex.employees.Add(emp);
            _contex.SaveChanges();
            return emp;
        }

        public Employee PutStatus(int id)
        {
            Employee e = _contex.employees.Find( id);
            if (e != null)
            {
                if (e.Status)
                    e.Status = false;
                else e.Status = true;
            }
            _contex.SaveChanges();
            return e;
        }
    }
}
