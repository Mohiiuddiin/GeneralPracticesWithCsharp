using System;
using System.Collections;

namespace ArrayAndArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList valueArrayList = new ArrayList();
            valueArrayList.Add("Ruhul");
            valueArrayList.Add("Kuuds");
            valueArrayList.Add("Nayem");
           

            foreach (string myValue in valueArrayList)
            {
                Console.WriteLine(myValue);  
            }

            //for (int i = 0; i < valueArrayList.Count; i++)
            //{
            //    Console.WriteLine(valueArrayList[i]);
            //}
            













            //int[] basicSalary = new int[5];
            //basicSalary[0] = 10000;
            //basicSalary[1] = 15000;
            //basicSalary[2] = 17000;
            //basicSalary[3] = 19000;
            //basicSalary[4] = 20000;
            //basicSalary[5] = 3333;

            //int[] medicalAllowance = new int[5];
            //medicalAllowance[0] = 444;
            //medicalAllowance[1] = 244;
            //medicalAllowance[2] = 444;
            //medicalAllowance[3] = 333;
            //medicalAllowance[4] = 744;

            //int[] totalSalary = new int[5];
            //totalSalary[0] = basicSalary[0] + medicalAllowance[0];
            
            Console.ReadKey();


        }
    }
}
