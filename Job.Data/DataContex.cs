using Job.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Data
{
    public class DataContex:DbContext
    {
        internal object employee;

        public DbSet<Work> works { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Employer> employers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }

        //public DataContex()
        //{
        //    this.employees = new List<Employee>
        //    {
        //        new Employee { Id = 1, Name = "John Doe", Email = "john.doe@example.com", ExperienceYears = 5, TypeJob = TypesJobs.CPA, Status = true },
        //        new Employee { Id = 2, Name = "Jane Doe", Email = "jane.doe@example.com", ExperienceYears = 3, TypeJob = TypesJobs.teacher, Status = true },
        //        new Employee { Id = 3, Name = "Alice Smith", Email = "alice.smith@example.com", ExperienceYears = 8, TypeJob = TypesJobs.contractor, Status = true },
        //    };
        //    employers = new List<Employer>
        //    {
        //        new Employer { Id = 1, Name = "ABC Company", Email = "info@abc.com", City = "City A", Status = true },
        //        new Employer { Id = 2, Name = "XYZ Corporation", Email = "info@xyzcorp.com", City = "City B", Status = true },
        //        new Employer { Id = 3, Name = "LMN Enterprises", Email = "info@lmnent.com", City = "City C", Status = false },
        //    };
        //    works = new List<Work>
        //    {
        //        new Work { Id = 1, Type = TypesJobs.CPA, Employer = new Employer { Id = 1, Name = "ABC Company", Email = "info@abc.com", City = "City A", Status = true }, ExperienceYearsRequired = 3 },
        //        new Work { Id = 2, Type = TypesJobs.teacher, Employer = new Employer { Id = 2, Name = "XYZ School", Email = "info@xyzschool.com", City = "City B", Status = true }, ExperienceYearsRequired = 2 },
        //        new Work { Id = 3, Type = TypesJobs.contractor, Employer = new Employer { Id = 3, Name = "LMN Construction", Email = "info@lmnconstruction.com", City = "City C", Status = false }, ExperienceYearsRequired = 5 },
        //    };

        //}

    }
}
