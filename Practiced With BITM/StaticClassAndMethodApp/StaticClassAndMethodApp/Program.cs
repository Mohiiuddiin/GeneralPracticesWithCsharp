using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndMethodApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            Calculator calculator1 = new Calculator();
            int sumResult1 = Calculator.Add(2, 3);
            int subResult1 = calculator1.Subtract(3, 2);
            Console.WriteLine(sumResult1);
            Console.WriteLine(subResult1);

            Console.WriteLine("-------------------");

            Calculator calculator2 = new Calculator();
            int sumResult2 = Calculator.Add(2, 3);
            int subResult2 = calculator2.Subtract(3, 2);
            int subResult3 = calculator2.Subtract(3, 2);
            Console.WriteLine(sumResult2);
            Console.WriteLine(subResult2);

            Console.WriteLine("---------------------");
            
            

            Console.WriteLine(Calculator.Count);



            //Console.WriteLine(calculator2.Count);
        }


        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
