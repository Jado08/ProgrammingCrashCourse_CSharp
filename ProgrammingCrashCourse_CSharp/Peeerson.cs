using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    //Classes and Objects : connected to case # 12
    internal class Peeerson
    {
       public string firstName;
       public string lastName;
       public int age;
       public char sex;
    }

    //Constructors : connected to case # 13
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

    //Topic : Object Methods : connected to case 14
    class Student
    {
        public string firstName, lastName, course, year, section;
        public float midtermGrade, finalGrade;

        public Student(string firstName, string lastName, string course, string year, string section, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.year = year;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }
        public void introduceSelf()
        {
            Console.WriteLine("I am " + firstName + " " + lastName + ". My course is " + course +
                ". A " + year + " year student and the section is " + section + ".");
        }
        public void evaluateGrade()
        {
            float average;

            average = (midtermGrade + finalGrade) / 2;

            if (average >= 90)
            {
                Console.WriteLine("Average : " + average + ". Congratulations! You are an Honor!");
            } else if (average >=75){
                Console.WriteLine("Average : " + average + ". Congratulations! You are Passed!");
            } else
            {
                Console.WriteLine("Average : " + average + ". You are Failed!");
            }
        }   
    }

    //INHERITANCE : connected to case # 15
    class Person
    {
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public Person(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        public void introduceSelf()
        {
            Console.WriteLine("\nName : " + name + "\nSex : " + sex + "\nAge : " + age);
        }
    }
    class Toddler : Person
    {
        public string toy { get; set; }
        public Toddler(string name, string sex, int age, string toy) : base(name, sex, age)
        {
            this.toy = toy;
        }
        public void introduceSelf()
        {
            base.introduceSelf();
            Console.WriteLine("Toy : " + toy);
        }
    }
    class Child : Toddler
    {
        public string faveSubject { get; set; }

        public Child(string name, string sex, int age, string toy, string faveSubject) : base(name, sex, age, toy)
        {
            this.faveSubject = faveSubject;
        }

        public void introduceSelf()
        {
            base.introduceSelf();
            Console.WriteLine("Fave Subject : " + faveSubject);
        }
    }

    //ENCAPSULATION : connected to case # 16 
    class UserEncapsulation
    {
        private int userID;
        private string userName, firstName, lastName;
        public int UserID
        {
            get { return userID; }
            set { if (value >= 100) userID = value;
                else Console.WriteLine("Error! The UserId must not below to 100");
            }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public UserEncapsulation(int userID, string userName, string firstName, string lastName)
        {
            UserID = userID;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
