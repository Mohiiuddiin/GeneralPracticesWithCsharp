using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            nameList.Add("Ruhul");
            nameList.Add("Kuddus");
            nameList.Add("Nayem");
            nameList.Add("Jumman");
            nameList.Add("Ahmed");
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("------------------");

            //bool isRemove = nameList.Remove("Nayem");
            //Console.WriteLine(isRemove);
            //nameList.RemoveAt(3);
            //nameList.Clear();
            //bool isExist = nameList.Contains("Nayem");
            //Console.WriteLine(isExist);
            //nameList.Reverse();
            //string[] nameArray = nameList.ToArray();
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }












            //for (int i = 0; i < nameList.Count; i++)
            //{
            //    Console.WriteLine(nameList[i]);
            //}


        }
    }
}
