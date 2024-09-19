using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class ProgrammingTutorials
    {
        public static void ForEachLoop() // connected to case # 10
        {
            int[] evenNumber = { 2, 4, 6, 8, 10 };
            int total = 0;

            foreach (int eNumber in evenNumber)
            {
                total += eNumber;
            }

            Console.WriteLine("Total : " + total);
        }

        public static void Arrays() // connected to case # 11
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

        // Exception Handling connected to case # 19
        public static void ExceptionHandling()
        {
            try
            {
                float decimalnum1, decimalnum2, divide;

                Console.Write("Number 1 : ");
                decimalnum1 = Convert.ToSingle(Console.ReadLine());

                Console.Write("Number 2 : ");
                decimalnum2 = Convert.ToSingle(Console.ReadLine());

                divide = (decimalnum1 / decimalnum2);

                Console.WriteLine("Quotient : " + divide);
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Working With Strings : connected to case # 23
        public static void WorkingWithString()
        {
            string sentence = "Hello World";

            Console.WriteLine("The Word is    : " + sentence);
            Console.WriteLine(value: $"Length         : {sentence.Length}");
            Console.WriteLine("Upper Case     : " + sentence.ToUpper());
            Console.WriteLine("Lower Case     : " + sentence.ToLower());
            Console.WriteLine("Substring      : " + sentence.Substring(6, 5));
            Console.WriteLine("Inserted Word  : " + sentence.Insert(6, "There "));
        }
    }
}
