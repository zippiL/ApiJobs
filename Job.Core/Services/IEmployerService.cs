﻿using Job.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Core.Services
{
    public interface IEmployerService
    {
        List<Employer> GetList();
        Employer Get(int id);
        void Post(Employer newEmployer);
        void Put(int id, Employer emp);
        void PutStatus(int id);
    }
}