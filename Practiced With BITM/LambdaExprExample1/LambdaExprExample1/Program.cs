using System;
using System.Security.Cryptography.X509Certificates;

namespace LambdaExprExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use implicitly typed lambda expression.
            // ... Assign it to a Func instance.
            // Here, "x" is the parameter of method and "x+1" is the expression which will be executed and
            //returned the result when the method is called from.\



            Action<int,int> func1 = (x,y) => Console.WriteLine("X:"+x+" Y:"+y);
            func1.Invoke(3,2);

            






            //// Use lambda expression with statement body.
            ////
            //Func<int, int> func2 = x => { return x + 1; };
            ////
            //// Use formal parameters with expression body.
            ////
            //Func<int, int> func3 = (int x) => x + 1;
            ////
            //// Use parameters with a statement body.
            ////
            //Func<int, int> func4 = (int x) => { return x + 1; };
            ////
            //// Use multiple parameters.
            ////
            //Func<int, int, int> func5 = (x, y) => x * y;
            ////
            //// Use no parameters in a lambda expression.
            ////
            //Action func6 = () => Console.WriteLine();
            ////
            //// Use delegate method expression.
            ////
            //Func<int, int> func7 = delegate(int x) { return x + 1; };            
            ////
            //// Use delegate expression with no parameter list.
            ////
            //Func<int> func8 = delegate { return 1 + 1; };
            ////
            //// Invoke each of the lambda expressions and delegates we created.
            //// ... The methods above are executed.
            ////
            //Console.WriteLine(func1.Invoke(1));
            //Console.WriteLine(func2.Invoke(1));
            //Console.WriteLine(func3.Invoke(1));
            //Console.WriteLine(func4.Invoke(1));
            //Console.WriteLine(func5.Invoke(2, 2));
            //func6.Invoke();
            //Console.WriteLine(func7.Invoke(1));
            //Console.WriteLine(func8.Invoke());
            //Console.ReadLine();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
