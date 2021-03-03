using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndMethodApp
{
    class Calculator
    {
        public static int Count { get; set; }
        public static int Add(int firstNumber, int secondNumber)
        {
            
            return firstNumber + secondNumber;
        }
        public  int Subtract(int firstNumber, int secondNumber)
        {            
            return firstNumber - secondNumber;
        }
    }
}
