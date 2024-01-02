using Job.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Core.Repsitories
{
    public interface IWorkRepsitories
    {
        DbSet<Work> GetList();
        Work Get(int id);
        Work Post( Work value);
        Work Put(int id, Work value);
        public void Delete(int id);
    }
}
