using System.ComponentModel.DataAnnotations;

namespace Job.Core.Entities
{
    public class Work
    {
        public int Id { get; set; }
        public TypesJobs Type { get; set; }
        public Employer Employer { get; set; }

        public int ExperienceYearsRequired { get; set; }
       
    }
}
