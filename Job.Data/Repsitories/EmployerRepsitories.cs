using Job.Core.Entities;
using Job.Core.Repsitories;
using Microsoft.EntityFrameworkCore;
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

        public DbSet<Employer> GetList()
        {
            return _contex.employers;
        }

        public Employer Post(Employer newEmployer)
        {
             _contex.employers.Add(newEmployer);
            _contex.SaveChanges();
            return newEmployer;
        }

        public Employer Put(int id, Employer emp)
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
            _contex.SaveChanges();
            return emp;
        }

        public Employer PutStatus(int id)
        {
            Employer e = _contex.employers.Where(e => e.Id == id).FirstOrDefault();
            if (e != null)
            {
                if (e.Status)
                    e.Status = false;
                else e.Status = true;
            }
            _contex.SaveChanges();
            return e;
        }
    }
}
