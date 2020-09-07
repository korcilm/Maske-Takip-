using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAplicantServices
    {
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);
    }
}
