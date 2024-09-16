using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class ProgrammingTutorials
    {
        public static void ForEachLoop()
        {
            int[] evenNumber = { 2, 4, 6, 8, 10 };
            int total = 0;

            foreach (int eNumber in evenNumber)
            {
                total += eNumber;
            }

            Console.WriteLine("Total : " + total);
        }

        public static void Arrays()
        {
            string[] email = { "david@gmail.com", "julie@gmail.com", "daniel@gmail.com", "jeneth@gmail.com" };
            string[] username = { "david", "julie", "daniel", "jeneth" };
            string[] password = { "david123", "julie123", "daniel123", "jeneth123" };

            Console.Write("Input your index : ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email            : " + email[index]);
            Console.WriteLine("Username         : " + username[index]);
            Console.WriteLine("Password         : " + password[index]);
        }
    }
}
