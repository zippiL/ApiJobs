using Job.Core.Entities;
using Job.Core.Repsitories;
using Job.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Service
{
    public class EmployerService: IEmployerService
    {
        private readonly IEmployerRepsitories _employerRepsitories;
        public EmployerService (IEmployerRepsitories employerRepsitories)
        {
            _employerRepsitories = employerRepsitories;
        }

        public Employer Get(int id)
        {
            return _employerRepsitories.Get(id);
        }

        public List<Employer> GetList()
        {
            return _employerRepsitories.GetList();
        }

        public void Post(Employer newEmployer)
        {
            _employerRepsitories.Post(newEmployer);
        }

        public void Put(int id, Employer emp)
        {
           _employerRepsitories.Put(id, emp); 
        }

        public void PutStatus(int id)
        {
           _employerRepsitories.PutStatus(id);
        }
    }
}
