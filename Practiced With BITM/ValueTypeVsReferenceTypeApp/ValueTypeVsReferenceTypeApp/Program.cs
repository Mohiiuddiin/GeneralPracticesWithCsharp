using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeVsReferenceTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personeOne = new Person("Md.","Jumman","Ahmed");
            string fullName1 = personeOne.GetFullName();
            Console.WriteLine("Fullname: " + fullName1);







            //personeOne.firstName = "Ruhul";
            //personeOne.middleName = "Kuddus";
            //personeOne.lastName = "Nayem";










          
            //Person personTwo = new Person();
            //personTwo.firstName = "Md.";
            //personTwo.middleName = "Jumman";
            //personTwo.lastName = "Ahmed";
           
            //Person personThree;
            //personThree = personTwo;
            //personTwo = personeOne;
            //personeOne = personThree;

            //personeOne.middleName = "Ehan";
            //personThree.firstName = "Asif";
            //new Person();
            //personTwo.lastName = "Jahid";

            //string fullName1 = personTwo.GetFullName();
            //Console.WriteLine("Fullname: " + fullName1);

            //string fullName2 = personThree.GetFullName();
            //Console.WriteLine("Fullname: " + fullName2);


            //personeOne.lastName = "Monkey";
          



            Console.ReadKey();
        }           
    }
}
