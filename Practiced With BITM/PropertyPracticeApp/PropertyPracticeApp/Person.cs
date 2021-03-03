using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPracticeApp
{
    class Person //Class
    {
        //private string firstName; //Instance variable , field, class level variable
        //public string FirstName { get; set; }

        //private string middleName;
        //private string lastName;

        public string FirstName { get; set; }
        public string SecondName  { get; set; }
        public string LastName { get; set; }


        //public string FirstName
        //{
        //    get
        //    {
        //        return firstName;
        //    }
        //    set
        //    {
        //        firstName = value;
        //    }
        //}




        //public string GetFirstName()
        //{
        //    return firstName;
        //}
        //public void SetFirstName(string firstName)
        //{
        //    if (firstName.Length > 1)
        //    {
        //        this.firstName = firstName;    
        //    }            
        //}
        //public string GetMiddleName()
        //{
        //    return middleName;
        //}
        //public void SetMiddleName(string middleName)
        //{
        //    if (middleName.Length > 1)
        //    {
        //        this.middleName = middleName;
        //    }
        //}

        //public string GetLastName()
        //{
        //    return lastName;
        //}
        //public void SetLastName(string lastName)
        //{
        //    if (lastName.Length > 1)
        //    {
        //        this.lastName = lastName;
        //    }

        //}

        //public string GetFullName() //Method name, (argument)
        //{
        //    string fullName =GetFirstName() + " " + GetMiddleName() + " " + GetLastName();     //Local variable        
        //    return fullName;
        //}
    }
}
