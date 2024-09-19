using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class MorningRoutine
    {
        //these async methods are connected to Asynchronous Programming found at case # 22.
        public static async Task PrayAsync()
        {
            Console.WriteLine("Praying . . .");
            await Task.Delay(2000);
            Console.WriteLine("Finished praying. \n");
        }
        public static async Task FixedBedAsync()
        {
            Console.WriteLine("Fixing the bed . . .");
            await Task.Delay(1000);
            Console.WriteLine("Bed is Fixed. \n");
        }
        public static async Task WashFaceAsync()
        {
            Console.WriteLine("Washing face . . .");
            await Task.Delay(1000);
            Console.WriteLine("Face is washed. \n");
        }
        public static async Task CookEggAsync()
        {
            Console.WriteLine("Cooking eggs . . .");
            await Task.Delay(3000);
            Console.WriteLine("Eggs are cooked. \n");
        }
        public static async Task PreparedHotChocoAsync()
        {
            Console.WriteLine("Preparing hot chocolate . . .");
            await Task.Delay(2000);
            Console.WriteLine("Hot chocolate is ready. \n");
        }
        public static async Task GetEggsAndPlateAsync()
        {
            Console.WriteLine("Getting cooked eggs and putting them on the plate...");
            await Task.Delay(1000);
            Console.WriteLine("Eggs are on the plate.\n");
        }
        public static async Task GetUtensilsAsync()
        {
            Console.WriteLine("Getting utensils...");
            await Task.Delay(500);
            Console.WriteLine("Utensils are ready.\n");
        }
        public static async Task EatBreakfastAsync()
        {
            Console.WriteLine("Eating breakfast...");
            await Task.Delay(2000);
            Console.WriteLine("Finished eating breakfast.\n");
        }
    }
}
