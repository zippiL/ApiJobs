using Job.Core.Entities;
using Job.Core.Repsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Data.Repsitories
{
    public class WorkRepsitories : IWorkRepsitories
    {
        private readonly DataContex _contex;
        public WorkRepsitories(DataContex contex)
        {
            _contex = contex;
        }

        public void Delete(int id)
        {
            Work w = _contex.works.Where(e => e.Id == id).FirstOrDefault();
            _contex.works.Remove(w);
        }

        public Work Get(int id)
        {
            return _contex.works.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<Work> GetList()
        {
            return _contex.works.ToList();
        }

        public void Post(Work value)
        {
            _contex.works.Add(value);
        }

        public void Put(int id, Work value)
        {
            Work jobToUpdate = _contex.works.Where(e => e.Id == id).FirstOrDefault();
            if (jobToUpdate != null)
            {
                jobToUpdate.Id = value.Id;
                jobToUpdate.Type = value.Type;
                jobToUpdate.Employer = value.Employer;
                jobToUpdate.ExperienceYearsRequired = value.ExperienceYearsRequired;
            }
            else
                _contex.works.Add(value);

        }
    }
}
