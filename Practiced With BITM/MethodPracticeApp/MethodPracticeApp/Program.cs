using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please input your name");

            //string name = Console.ReadLine();

            //Fooo(name);


            int myResult  = Add(4, 3);
            Console.WriteLine(myResult);

            Console.ReadKey();
        }


        public static int Add(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }













        //public static void Fooo(string mName)
        //{
        //    Console.WriteLine("Hello " + mName);
        //}




    }
}
