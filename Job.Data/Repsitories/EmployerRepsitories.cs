using Job.Core.Entities;
using Job.Core.Repsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Data.Repsitories
{
    public class EmployerRepsitories : IEmployerRepsitories
    {
        private readonly DataContex _contex;
        public EmployerRepsitories(DataContex contex)
        {
            _contex = contex; 
        }

        public Employer Get(int id)
        {
            return _contex.employers.Where(e => e.Id == id).FirstOrDefault(); 
        }

        public List<Employer> GetList()
        {
            return _contex.employers.ToList();
        }

        public void Post(Employer newEmployer)
        {
             _contex.employers.Add(newEmployer);
        }

        public void Put(int id, Employer emp)
        {
            Employer empToUpdate = _contex.employers.Where(e => e.Id == id).FirstOrDefault();
            if (empToUpdate != null)
            {
                empToUpdate.Id = emp.Id;
                empToUpdate.Name = emp.Name;
                empToUpdate.Email = emp.Email;
                empToUpdate.City = emp.City;
                empToUpdate.Status = emp.Status;


            }
            else
                _contex.employers.Add(empToUpdate);
        }

        public void PutStatus(int id)
        {
            Employer e = _contex.employers.Where(e => e.Id == id).FirstOrDefault();
            if (e != null)
            {
                if (e.Status)
                    e.Status = false;
                else e.Status = true;
            }
        }
    }
}
