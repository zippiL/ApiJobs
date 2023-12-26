using System.ComponentModel.DataAnnotations;

namespace Job.Core.Entities
{
   
   
    public class Employer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public bool Status { get; set; }

    }
}
