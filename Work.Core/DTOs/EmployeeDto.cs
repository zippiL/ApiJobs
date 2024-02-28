using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work.Core.Entities;

namespace Work.Core.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int ExperienceYears { get; set; }
        public TypesJobs TypeJob { get; set; }
        public bool Status { get; set; }

    }
}
