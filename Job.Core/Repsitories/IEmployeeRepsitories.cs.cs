using Job.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Core.Repsitories
{
    public interface IEmployeeRepsitories
    {
        DbSet<Employee> GetList();
        Employee Get(int id);
        Employee Post(Employee newEmployee);
        Employee Put(int id, Employee emp);
        public Employee PutStatus(int id);
    }
}
