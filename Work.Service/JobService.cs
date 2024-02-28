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
   
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task< Job> AddAsync(Job job)
        {
           return await _jobRepository.AddAsync(job);
            
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _jobRepository.DeleteByIdAsync(id);
        }

        public DbSet<Job> GetAll()
        {
           return _jobRepository.GetList();
        }

        public Job GetById(int id)
        {
            return _jobRepository.GetById(id);
        }

        public async Task<Job> UpdateAsync(Job job)
        {
           return await _jobRepository.UpdateAsync(job);
        }
    }
}
