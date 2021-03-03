using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVariableApp
{
    class Program
    {                
        static void Main(string[] args)
        {
            //Person aPerson = new Person("Md","Jumman","Ahmed")
            //{
            //    FirstName = "Ruhul",
            //    LastName = "Kuddus",
            //    MiddleName = "Nayem"
            //};
            //Console.WriteLine(aPerson.GetFullName());

            Person aPerson = new Person
            {
                FirstName = "Ruhul",
                MiddleName = "Kuddus",
                LastName = "Nayem"
            };


            List<Person> personList = new List<Person>
            {       
                aPerson,
                new Person{FirstName = "Md",MiddleName= "Jumman",LastName = "Ahmed"}
                
            };

            foreach (Person i in personList)
            {
                Console.WriteLine(i.GetFullName());
            }


        }
      
    }
}
