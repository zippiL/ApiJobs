﻿using Job.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Core.Repsitories
{
    public interface IWorkRepsitories
    {
        List<Work> GetList();
        Work Get(int id);
        void Post( Work value);
        void Put(int id, Work value);
        public void Delete(int id);
    }
}