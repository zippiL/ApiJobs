using Job.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Core.Repsitories
{
    public interface IEmployerRepsitories
    {
        DbSet<Employer> GetList();
        Employer Get(int id);
        Employer Post(Employer newEmployer);
        Employer Put(int id, Employer emp);
        Employer PutStatus(int id);
    }
}
