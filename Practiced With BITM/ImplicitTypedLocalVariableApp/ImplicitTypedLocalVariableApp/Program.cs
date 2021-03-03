using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitTypedLocalVariableApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Person aPerson = new Person
            {
                FirstName = "Ruhul",
                MiddleName = "Kuddus",
                LastName = "Nayem"
            };
            var personList = new List<Person>
            {
                aPerson,
                new Person()
                {
                    FirstName = "Md."
                    ,MiddleName = "Jumman"
                    ,LastName = "Ahmed"
                },
                new Person()
                {FirstName = "Md."
                    ,MiddleName = "Jumman",
                    LastName = "Ahmed"
                }
            };

            foreach (Person person in personList)
            {
                Console.WriteLine(person.GetFullName());
            }


        }
    }
}
