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
    public class EmployerRepository : IEmployerRepository
    {
        private readonly DataContext _context;
        public EmployerRepository(DataContext context)
        {
            _context = context;
        }
        public Employer GetById(int id)
        {
            return _context.Employers.FirstOrDefault(e => e.Id == id);
        }

        public DbSet<Employer> GetList()
        {
            return _context.Employers;
        }
        public async Task DeleteByIdAsync(int id)
        {
            Employer e = _context.Employers.FirstOrDefault(e => e.Id == id);
            if (e != null) {
                _context.Employers.Remove(e);
               await _context.SaveChangesAsync();
            }
            
        }
        public async Task< Employer> UpdateAsync(Employer employer)
        {
            Employer e = _context.Employers.FirstOrDefault(e => e.Id == employer.Id);
            if (e != null)
            {
                e.Status = employer.Status;
                e.City = employer.City;
                e.Email = employer.Email;
                e.Name = employer.Name; 
                
            }
            else
                _context.Employers.Add(employer);
            await _context.SaveChangesAsync();
            return employer;
        }

        public async Task<Employer> AddAsync(Employer employer)
        {
            _context.Employers.Add(employer);
            await _context.SaveChangesAsync();
            return employer;
        }
    }
}
