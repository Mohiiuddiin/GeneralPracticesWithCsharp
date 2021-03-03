using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablePracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            byte b = 255;
            sbyte sb = -22;
            bool isExist = false;
            float f = 3.22f;
            double d = 3.22222d;
            decimal dm = 3.222m;
            char c = 'a';
            string st = "sab";



            int temp = (int)f;
            Console.WriteLine(temp);

            //int number1 = 33;
            //int number2 = number1;
            //number1 = 55;
            //Console.WriteLine(number2);

            Console.ReadKey();
        }
    }
}
