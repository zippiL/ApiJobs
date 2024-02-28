using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Services
{
    public interface IEmployeeService
    {
        DbSet<Employee> GetAll();
        Employee GetById(int id);
        Task UpdateAsync(Employee employee);
        Task DeleteByIdAsync(int id);
        Task AddAsync(Employee employee);
    }
}
