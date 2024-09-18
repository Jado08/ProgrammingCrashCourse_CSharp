using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class Peeerson
    {
       public string firstName;
       public string lastName;
       public int age;
       public char sex;
    }

    class User
    {
        public string firstName;
        public string lastName;
        public string motto;

        public User(string firstName, string lastName, string motto)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.motto = motto;

            Console.WriteLine("\nName  : " + firstName + " " +  lastName + 
                          "\nMotto : " + motto);
        }
    }
}
