using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Repositories
{
    public interface IJobRepository
    {
        DbSet<Job> GetList();
        Job GetById(int id);
        
        Task DeleteByIdAsync(int id);
        Task<Job> UpdateAsync(Job job);

        Task<Job> AddAsync(Job job);
    }
}
