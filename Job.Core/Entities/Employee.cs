using System.ComponentModel.DataAnnotations;
public enum TypesJobs
{
    thecnut, cleaner, CPA, contractor, teacher, KindergartenTeacher, Director, secretary, gardener, librarian, author
}
namespace Job.Core.Entities
{
 
    
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ExperienceYears { get; set; }
        public TypesJobs TypeJob { get; set; }
        public bool Status { get; set; }


    }
}
