using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work.Core.Entities
{
    public class JobOffer
    {
        public int JobId { get; set; }

        public int EmployeeId { get; set; }

        public Job Job { get; set; }

        public Employee Employee { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }
    }
}
