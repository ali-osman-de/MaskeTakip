﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerService : IApplicantService
    {
        public void ApplyForMask(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Citizen citizen)
        {
            throw new NotImplementedException();
        }

        public List<Citizen> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
