using System;
using System.Collections.Generic;
using System.Threading;

namespace AnonymousTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //var aCustomer = new
            //{
            //    Name = "Rumki", 
            //    Id = "09817", 
            //    Address = "Chittagong"
            //};
            
            //Console.WriteLine(aCustomer.Name);            

            //var aStudent = new {RegNo = "8176", Name = "Nadim", Email = "n@mail.com"};

            //var aBook = new {Name = "C# Prog...", ISBN = "3498757", Price = 340};
            //double p = aBook.Price;

            double price = 250;
            var aBook = new { Name = "C# Prog...", ISBN = "123456789", Price = price };
            
            


            ////Console.Write(aCustomer.Name + " " + aCustomer.Id);

            //var names = new[]
            //{
            //    "Kanta",
            //    "Zamil",
            //    "Rupom"
            //};


            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            var aList = new[]
                            {
                                new {Code = "i-001", ItemType = "Cosmetics", Name = "Cream"},
                                new {Code = "i-002", ItemType = "beverage", Name = "Coke"},
                                new {Code = "i-003", ItemType = "Book", Name = "Timelessness"}
                            };

            ShowObject(aList);
            //foreach (var aValue in aList)
            //{
            //    Console.WriteLine(aValue.);
            //}
            //Show(aList);
            Console.ReadKey();
        }
        public static void ShowObject(dynamic obj)
        {
            foreach (dynamic o in obj)
            {
                Console.WriteLine(o.Code);
            }           
        }
        //private static void Show(IEnumerable<dynamic> aList)
        //{
        //    foreach (var aValue in aList)
        //    {
        //        Console.WriteLine(aValue.ItemType);
        //    }
        //}
    }
}
