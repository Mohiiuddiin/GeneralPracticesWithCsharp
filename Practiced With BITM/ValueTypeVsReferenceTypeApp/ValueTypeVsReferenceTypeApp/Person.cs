using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeVsReferenceTypeApp
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public Person()
        {
            Console.WriteLine("Hello Tazim");
        }

        public Person(string firstName ,string lastName):this()
        {
            this.firstName = firstName;            
            this.lastName = lastName;
        }     
  
        public Person(string firstName, string middleName, string lastName) : this(firstName,lastName)
        {            
            this.middleName = middleName;            
        }



        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
        public string GetReverseFullName()
        {
            string fullName = GetFullName();

            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
