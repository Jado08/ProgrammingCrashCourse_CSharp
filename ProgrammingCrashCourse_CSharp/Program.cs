﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0; 
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Choose a Topic: ");
                Console.WriteLine("1. Hello World");
                Console.WriteLine("2. Variables and Data Types");
                Console.WriteLine("3. Basic Input and Output");
                Console.WriteLine("4. Operators and Expressions");
                Console.WriteLine("5. Conditional Statements");
                Console.WriteLine("6. Switch Statements");
                Console.WriteLine("7. While Loop");
                Console.WriteLine("8. Do While Loop");
                Console.WriteLine("9. For Loop");
                Console.WriteLine("10. For Each Loop");
                Console.WriteLine("11. Arrays");
                Console.WriteLine("12. Classes & Objects");
                Console.WriteLine("13. Constructors");

                Console.Write("\nYour Option No. ");

                isValid = int.TryParse(Console.ReadLine(), out choice);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.\n");
                }
            }
            switch (choice)
            {
                case 1: ProgrammingCrashCourse.Helloworld(); break;
                case 2: ProgrammingCrashCourse.DataTypes(); break;
                case 3: ProgrammingCrashCourse.BasicIO(); break;
                case 4: ProgrammingCrashCourse.Arithmetic(); break;
                case 5: ProgrammingCrashCourse.ConditionalStatements(); break;
                case 6: ProgrammingCrashCourse.Switch(); break;
                case 7: ProgrammingCrashCourse.WhileLoop(); break;
                case 8: ProgrammingCrashCourse.DoWhileLoop(); break;
                case 9: ProgrammingCrashCourse.ForLoop(); break;
                case 10: ProgrammingTutorials.ForEachLoop(); break;
                case 11: ProgrammingTutorials.Arrays(); break;
                case 12:
                    Peeerson p1 = new Peeerson();
                    p1.firstName = "Julie";
                    p1.lastName = "Orcine";
                    p1.age = 20;
                    p1.sex = 'F';

                    Peeerson p2 = new Peeerson();
                    p2.firstName = "Daniel";
                    p2.lastName = "Orcine";
                    p2.age = 19;
                    p2.sex = 'M';

                    Peeerson p3 = new Peeerson();
                    p3.firstName = "Jeneth";
                    p3.lastName = "Orcine";
                    p3.age = 19;
                    p3.sex = 'F';

                    Console.WriteLine("\n" + p1.firstName + " " + p1.lastName + " " +
                        p1.age + " " + p1.sex);
                    Console.WriteLine(p2.firstName + " " + p2.lastName + " " +
                        p2.age + " " + p2.sex);
                    Console.WriteLine(p3.firstName + " " + p3.lastName + " " +
                        p3.age + " " + p3.sex);
                    break;
                case 13:
                    Console.Write("\nYour Firstname     : ");
                    string fn = Console.ReadLine();

                    Console.Write("Your Lastname      : ");
                    string ln = Console.ReadLine();

                    Console.Write("Your Motto in Life : ");
                    string m = Console.ReadLine();

                    User u = new User(fn, ln, m);



                    break;

                default: Console.WriteLine("Invalid Choice"); break;
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}