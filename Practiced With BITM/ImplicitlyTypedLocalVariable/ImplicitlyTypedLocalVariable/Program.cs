using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyTypedLocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            var s = "Hello World";
            var d = 26.7;
            var b = true;
            var c = 'A';

            var intList = new List<int>();
            intList.Add(12);
            intList.Add(12);
            intList.Add(12);
            intList.Add(12);

            var aTrainee = new Trainee();
            aTrainee.SEID = "123456";
            aTrainee.Name = "XYZ";

            foreach (var i1 in intList)
            {
                Console.WriteLine(i1);
            }

            var trainees = new List<Trainee>();

            Console.ReadKey();
        }
    }
}
