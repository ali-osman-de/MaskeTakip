using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttService:ISupplierService
    {
        private IApplicantService _applicantService;

        //Constructor new yapıldıgında calısır.
        public PttService(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Citizen citizen)
        {

            if (_applicantService.CheckPerson(citizen))
            {

                Console.WriteLine(citizen.FirstName + " için maske düzenlendi.");

            }
            else
            {
                Console.WriteLine(citizen.FirstName + " için maske düzenlenemiyor.");
            }

        }

    }
}
