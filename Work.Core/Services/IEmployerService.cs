using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.Services
{
    public interface IEmployerService
    {
        DbSet<Employer> GetAll();
        Employer GetById(int id);
        Task<Employer> UpdateAsync(Employer employer);
        Task DeleteByIdAsync(int id);

        Task< Employer> AddAsync(Employer employer);

    }
}
