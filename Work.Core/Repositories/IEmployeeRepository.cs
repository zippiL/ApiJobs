using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Repositories
{
    public interface IEmployeeRepository
    {
        DbSet<Employee> GetList();

        Employee GetById(int id);

        Task DeleteByIdAsync(int id);
        Task UpdateAsync(Employee employee);

        Task AddAsync(Employee employee);
    }
}
