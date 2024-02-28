using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Core.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public TypesJobs Type { get; set; }
        public Employer Employer { get; set; }

        public int ExperienceYearsRequired { get; set; }
    }
}
