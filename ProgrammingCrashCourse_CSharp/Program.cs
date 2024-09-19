using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class Program
    {
        static async Task Main(string[] args)
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
                Console.WriteLine("14. Object Methods");
                Console.WriteLine("15. Inheritance");
                Console.WriteLine("16. Encapsulation");
                Console.WriteLine("17. Polymorphism");
                Console.WriteLine("18. Abstraction");
                Console.WriteLine("19. Exception Handling");
                Console.WriteLine("20. Collections");
                Console.WriteLine("21. Delegates and Events");
                Console.WriteLine("22. Asynchronous Programming");
                Console.WriteLine("23. Working with Strings");

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
                case 14:                   
                    Student s = new Student("Julie", "Orcine", "BSIT", "4th", "TEC 302", 95.15f, 96.19f);
                    s.introduceSelf();
                    s.evaluateGrade();
                    break;
                case 15:
                    Person p = new Person("Julie", "Female", 21);
                    p.introduceSelf();
                    Toddler t = new Toddler("Daniel", "Male", 2, "Robot");
                    t.introduceSelf();
                    Child c = new Child("Jeneth", "Female", 10, "Doll", "Math");
                    c.introduceSelf();
                    break;
                case 16:
                    UserEncapsulation user = new UserEncapsulation(99, "julie123", "Julie", "Orcine" );
                    break;
                case 17:
                    Appliances tv = new Television();
                    Appliances r = new Refrigerator();
                    tv.kuryente();
                    r.kuryente();
                    break;
                case 18:
                    Thing np = new Notepad("Notepad");
                    Thing tble = new Table("Table");
                    np.willUse();
                    tble.willUse();
                    break;
                case 19: ProgrammingTutorials.ExceptionHandling(); break;
                case 20:
                    List<Place> placeList = new List<Place>
                    {
                        new Place("Davao del Sur", new string[] {"Davao City", "Mati", "Digos"}),
                        new Place("Surigao del Sur", new string[] {"Tandag City", "Tago", "Cagwait"})
                    };
                    foreach(var place in placeList)
                    {
                        Console.WriteLine($"Place   : {place.name}");
                        Console.WriteLine("Location");
                        foreach(var location in place.location)
                        {
                            Console.WriteLine($"- {location}");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 21:
                    var video = new Video() { Title = "Video 1" };
                    var videoEncoder = new VideoEncoder();
                    var mailService = new MailService();
                    var messageService = new MessageService();

                    videoEncoder.videoEncoded += mailService.onVideoEncoded;
                    videoEncoder.videoEncoded += messageService.OnVideoEncoded;

                    videoEncoder.Encode(video);
                    break;
                case 22:
                    await MorningRoutine.PrayAsync();
                    await MorningRoutine.FixedBedAsync();
                    await MorningRoutine.WashFaceAsync();

                    Task cookEggsTask = MorningRoutine.CookEggAsync();
                    Task prepareHotChocolateTask = MorningRoutine.PreparedHotChocoAsync();

                    await Task.WhenAll(cookEggsTask, prepareHotChocolateTask);

                    await MorningRoutine.GetEggsAndPlateAsync();
                    await MorningRoutine.GetUtensilsAsync();
                    await MorningRoutine.EatBreakfastAsync();

                    Console.WriteLine("Morning routine completed.");
                    break;
                case 23: ProgrammingTutorials.WorkingWithString();break;

                default: Console.WriteLine("Invalid Choice"); break;
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}