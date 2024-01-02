using Job.Core.Entities;
using Job.Core.Repsitories;
using Job.Core.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Job.Service
{
    public class WorkService : IWorkService
    {
        private readonly IWorkRepsitories _workRepsitories;
        public WorkService(IWorkRepsitories workRepsitories)
        {
            _workRepsitories = workRepsitories;
        }

        public void Delete(int id)
        {
            _workRepsitories.Delete(id);
        }

        public Work Get(int id)
        {
            return _workRepsitories.Get(id);
        }

        public DbSet<Work> GetList()
        {
            return _workRepsitories.GetList();
        }

        public void Post(Work value)
        {
             _workRepsitories.Post(value);
        }

        public void Put(int id, Work value)
        {
            _workRepsitories.Put(id, value);
        }
    }
}
