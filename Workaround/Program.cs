using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Concrete;
using Entities.Concrete;


namespace Workaround2
{
    public class Program
    {

        static void Main(string[] args)
        {


            Person person1 = new Person();
            person1.FirstName = "Erdem";
            person1.LastName = "Karataş";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentity = 123;



            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
    }
}
