using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_App
{
    public class Calculator
    {
        public static int sum = 0;
        public static int Add(params int[] numbers)
        {
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //    sum += num[i];
            //}            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
                sum += number;
            }
            return sum;
        }
    }
}
