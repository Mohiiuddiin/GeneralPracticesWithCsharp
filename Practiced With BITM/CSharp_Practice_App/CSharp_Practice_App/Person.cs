using System;

namespace CSharp_Practice_App
{
    public class Person
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Region;

        public Person()
        {
            Region = "Bangladesh";
        }
        public Person(string firstName,string middleName,string lastName):this()
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
        public void FullName()
        {
            Console.WriteLine(FirstName + MiddleName + LastName+" Region:"+Region);
        }
        public static void FullName(string fname,string mname,string lname)
        {            
            Console.WriteLine(fname+" "+mname+" "+lname);
        }




    }
}
