using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Ruhul";


            Console.WriteLine(person.FirstName);

            //Console.WriteLine(person.GetFullName());
            //person.middleName = "Ruhul";
            //person.lastName = "Kuddus";
        }
    }
}
