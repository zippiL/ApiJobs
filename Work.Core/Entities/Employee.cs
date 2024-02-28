using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Core.Entities
{
    public enum TypesJobs
    {
        thecnut, cleaner, CPA, contractor, teacher, KindergartenTeacher, Director, secretary, gardener, librarian, author
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int ExperienceYears { get; set; }
        public TypesJobs TypeJob { get; set; }
        public bool Status { get; set; }

        public List<JobOffer> JobOffers { get; set; }

    }
}
