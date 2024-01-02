using Job.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Core.Services
{
    public interface IEmployeeService
    {
        DbSet<Employee> GetList();
        Employee Get(int id);
        void Post(Employee newEmployee);
        void Put(int id, Employee emp);
        void PutStatus(int id);
    }
}
