using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_App
{
    partial class Program
    {
        static void Main(string[] args)
        {
            UsePersonClass();
            UseCalculatorClass();
            UsePointClass();
            Console.ReadKey();
        }


        static void UsePersonClass()
        {
            var person = new Person("Golum", "Mohammed", "Mohiuddin");//initialize value by constructor

            person.FullName();  //non static calling

            var person2 = new Person()   //using object initializer
            {
                FirstName = "Golum",
                MiddleName = "Mohammed",
                LastName = "Mohiuddin"
            };
            person2.FullName();
            Person.FullName("Golum", "Mohammed", "Mohiuddin");//static method calling
        }

        static void UseCalculatorClass()
        {
            //Calculator Add Method using params
            Console.WriteLine("Sum: " + Calculator.Add(1, 2));
            Console.WriteLine("Sum: " + Calculator.Add(1, 2, 3));
            Console.WriteLine("Sum: " + Calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine("Sum: " + Calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePointClass()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(100, 200);
                Console.WriteLine("The point is at ({0},{1})", point.A, point.B);

                point.Move(new Point(20, 30));
                Console.WriteLine("The point is at ({0},{1})", point.A, point.B);

                point.Move(null);
                Console.WriteLine("The point is at ({0},{1})", point.A, point.B);
            }
            catch (Exception)
            {
                Console.WriteLine("An Unexpected Error Occured");
            }
        }
    }
}
