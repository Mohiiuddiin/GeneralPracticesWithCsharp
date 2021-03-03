using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatementApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Pleaes input a number");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 10)
            {
                Console.WriteLine("The number is greater than 10");
            }
            else if(num == 10)
            {
                Console.WriteLine("The number is equal to 10");                
            }
            else if (num == 11)
            {
                Console.WriteLine("The number is equal to 10");
            }
            else if (num == 12)
            {
                Console.WriteLine("The number is equal to 10");
            }
            else
            {
                Console.WriteLine("The number is less than 10");
            }

            Console.ReadKey();

        }
    }
}
