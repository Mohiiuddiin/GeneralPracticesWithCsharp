using System;
using System.Collections.Generic;

namespace LambdaExprExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Rimi", 
                "Hasan", 
                "Arafeen", 
                "Haider"
            };


          

            //List<string> temp = names.FindAll(x=>x.StartsWith("H"));

            ////Console.WriteLine(temp);

            //foreach (string s in temp)
            //{
            //    Console.WriteLine(s);
            //}

            //string found = names.Find(name => name.StartsWith("H"));
            //string found = names.Find(x => x.Contains("m"));
            //Console.WriteLine(found);

            //List<double> values = new List<double>() { 4, 5, 77, 15, 3, 25 };
            ////double aNumber = values.Find(number => (number >= 10));
            //double aNumber = values.Find(x => x >= 15 && x <= 80);
            //Console.WriteLine(aNumber);

            List<Book> books = new List<Book> { 

                new Book { Author="Mcconnell",Name="Code Complete", Published=new DateTime(1993,05,14) },
                new Book { Author="Sussman",Name="SICP (2nd)", Published=new DateTime(1996,06,01) },
                new Book { Author="Hunt",Name="Pragmatic Programmer", Published=new DateTime(1999,10,30) },
            };

            List<Book> sBooks = books.FindAll(x=>x.Author.Contains("u"));

            foreach (var sBook in sBooks)
            {
                Console.WriteLine(sBook.Author);
            }

            //var selectedBooks = books.FindAll(y => y.Published > (new DateTime(1995, 12, 31)));

            //foreach (var book in selectedBooks)
            //{
            //    Console.WriteLine(book.Author);
            //}

            Console.ReadKey();
        }

        public static bool CustomStartsWith(string value ,char myChar)
        {
            if (value[0] == myChar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
