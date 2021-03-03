using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address MyAddress { get; set; }

        public Person()
        {
             MyAddress = new Address();
        }

        public string GetFullInfo()
        {
            return FirstName + " " + MiddleName + " " + LastName+" "+MyAddress.GetFullAddress();
        }

    }
}
