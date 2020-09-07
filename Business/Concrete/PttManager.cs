using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager :ISuplierService
    {
        private IAplicantServices _aplicantServices;

        public PttManager(IAplicantServices aplicantServices)
        {
            _aplicantServices = aplicantServices;
        }
        public void GiveMask(Person person)
        {
            if(_aplicantServices.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske Verilemedi");
            }
        }
    }
}
