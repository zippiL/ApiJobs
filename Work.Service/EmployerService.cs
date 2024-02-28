using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;
using Work.Core.Repositories;
using Work.Core.Services;

namespace Work.Service
{
    public class EmployerService : IEmployerService
    {
        private readonly IEmployerRepository _employerRepository;
        public EmployerService(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public async Task<Employer> AddAsync(Employer employer)
        {
           return await _employerRepository.AddAsync(employer);
        }

        public async Task DeleteByIdAsync(int id)
        {
           await _employerRepository.DeleteByIdAsync(id);
        }

        public DbSet<Employer> GetAll()
        {
            return _employerRepository.GetList();
        }

        public Employer GetById(int id)
        {
            return _employerRepository.GetById(id);
        }

        public async Task<Employer> UpdateAsync(Employer employer)
        {
           return await _employerRepository.UpdateAsync(employer);
        }
    }
}
