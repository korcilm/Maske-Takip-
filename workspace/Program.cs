using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.Write("Adınızı Giriniz:");
            person1.FirstName = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz:");
            person1.LastName = Console.ReadLine();
            Console.Write("Kimlik Numaranızı Giriniz:");
            person1.NationalIdentity = Int64.Parse(Console.ReadLine());
            Console.Write("Doğum Tarihinizi Giriniz:");
            person1.DateOfBirthYear = Int32.Parse(Console.ReadLine());

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}
