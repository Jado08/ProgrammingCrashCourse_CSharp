using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class ProgrammingCrashCourse
    {
        public static void Helloworld()
        {
            Console.WriteLine("Hello World");
        }

        public static void DataTypes()
        {
            string name = "Julie-Ann Orcine";
            int age = 24;
            string address = "Catalunan Pequeno";

            Console.WriteLine("I am " + name +
                ". I lived at " + address +
                ". My age is " + age + ".");
        }

        public static void BasicIO()
        {
            string name;
            string location;
            string education;

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Location: ");
            location = Console.ReadLine();

            Console.Write("Education: ");
            education = Console.ReadLine();

            Console.WriteLine("\nMy name is " + name + ".");
            Console.WriteLine("I am from " + location + ".");
            Console.WriteLine("I study in " + education + ".");
        }

        public static void Arithmetic()
        {
            int english, math, science, computer;
            float average;

            Console.Write("English  : ");
            english = Convert.ToInt32(Console.ReadLine());

            Console.Write("Math     : ");
            math = Convert.ToInt32(Console.ReadLine());

            Console.Write("Science  : ");
            science = Convert.ToInt32(Console.ReadLine());

            Console.Write("Computer : ");
            computer = Convert.ToInt32(Console.ReadLine());

            average = ((english + math + science + computer) / 4f);

            Console.WriteLine("\nAverage   : " + average);
        }

        public static void ConditionalStatements()
        {
            float grade1, grade2, grade3, grade4, average;

            Console.Write("English Grade  : ");
            grade1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Math Grade     : ");
            grade2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Science Grade  : ");
            grade3 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Computer Grade : ");
            grade4 = Convert.ToSingle(Console.ReadLine());

            average = (grade1 + grade2 + grade3 + grade4) / 4;

            if (average > 100)
            {
                Console.WriteLine("You're average is " + average + ". That's Invalid Grade.");
            }
            else if (average >= 98)
            {
                Console.WriteLine("Congratulations, you're average is " + average + ", You are WITH HIGHEST HONORS!");
            }
            else if (average >= 95)
            {
                Console.WriteLine("Congratulations,you're average is " + average + ", You are WITH HIGH HONORS!");
            }
            else if (average >= 90)
            {
                Console.WriteLine("Congratulations, you're average is " + average + ", You are WITH HONORS!");
            }
            else if (average >= 75)
            {
                Console.WriteLine("Congratulations, you're average is " + average + ", You are PASSED!");
            }
            else
            {
                Console.WriteLine("You're average is " + average + ". It FAILED!");
            }
        }

        public static void Switch()
        {
            Console.Write("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Date : ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            string monthWord;

            switch (month)
            {
                case 1:
                    monthWord = ("January");
                    break;
                case 2:
                    monthWord = ("February");
                    break;
                case 3:
                    monthWord = ("March");
                    break;
                case 4:
                    monthWord = ("April");
                    break;
                case 5:
                    monthWord = ("May");
                    break;
                case 6:
                    monthWord = ("June");
                    break;
                case 7:
                    monthWord = ("July");
                    break;
                case 8:
                    monthWord = ("August");
                    break;
                case 9:
                    monthWord = ("September");
                    break;
                case 10:
                    monthWord = ("October");
                    break;
                case 11:
                    monthWord = ("November");
                    break;
                case 12:
                    monthWord = ("December");
                    break;
                default:
                    monthWord = "";
                    Console.WriteLine("There is no Month like that!");
                    break;
            }
            if (date <= 31)
            {
                if (monthWord != "") Console.WriteLine("\nYour inputted Date is: " + monthWord + " " + date + ", " + year);
            }
            else
            {
                Console.WriteLine("\nInvalid day! There's no such above day 31. ");
            }
        }

        public static void WhileLoop()
        {
            string[] names = { "Prince", "Garleth", "Julie", "Daniella", "Abegail", "Juliana" };
            int j = 0;
            while (j < names.Length)
            {
                if (names[j].Contains("l"))
                {
                    Console.WriteLine(names[j]);
                }
                j++;
            }
        }

        public static void DoWhileLoop()
        {
            string[] fruitName = { "apple", "banana", "mango", "orange", "strawberry", "watermelon" };
            int index = 0;
            do
            {
                index++;
            } while ((index <= fruitName.Length) && (fruitName[index] != "strawberry"));
            Console.WriteLine("Strawberry is in No. {0} of the fruit's list.", ++index);
        }

        public static void ForLoop()
        {
            string[] userName = { "david", "julie", "daniel", };
            string[] password = { "david123", "julie123", "daniel123" };

            Console.Write("Enter username : ");
            string un = Console.ReadLine();

            Console.Write("Enter password : ");
            string pw = Console.ReadLine();

            bool isAccountFound = false;

            for (int i = 0; i < userName.Length; i++)
            {
                if (un.Equals(userName[i]) && (pw.Equals(password[i])))
                {
                    isAccountFound = true;
                    Console.WriteLine("\nWelcome " + userName[i]);
                    break;
                }
            }
            if (!isAccountFound) { Console.WriteLine("\nThe Account is Not Found!"); }
        }
    }
}
