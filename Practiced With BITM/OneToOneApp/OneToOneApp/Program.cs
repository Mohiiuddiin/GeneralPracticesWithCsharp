using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
     


            Person aPerson = new Person();
            aPerson.FirstName = "Ruhul";
            aPerson.MiddleName = "Kuddus";
            aPerson.LastName = "Nayem";
            aPerson.MyAddress.District = "Chittagong";
            aPerson.MyAddress.Thana = "Chokbazar";
            aPerson.MyAddress.HouseNo = "205/a";
            aPerson.MyAddress.RoadNo = "2";



            Console.WriteLine(aPerson.MyAddress.District);
        }
    }
}
