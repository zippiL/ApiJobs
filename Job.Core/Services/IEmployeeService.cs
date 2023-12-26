using Job.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Core.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetList();
        Employee Get(int id);
        void Post(Employee newEmployee);
        void Put(int id, Employee emp);
        void PutStatus(int id);
    }
}
