using Work.Core.Entities;

namespace WorkAPI.Models
{
    public class EmployeePostModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int ExperienceYears { get; set; }
        public TypesJobs TypeJob { get; set; }
        public bool Status { get; set; }

    }
}
