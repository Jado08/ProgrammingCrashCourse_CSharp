using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class Appliances
    {
        virtual public void kuryente()
        {
            Console.WriteLine("Fundamental source of Power! Chozzz.");
        }
    }

    class Television : Appliances 
    {
        override public void kuryente()
        {
            Console.WriteLine("Televisions consume electricity. Sanaol.");
        }
    }

    class Refrigerator : Appliances
    {
        override public void kuryente()
        {
            Console.WriteLine("Refrigerators also consume electricity. Charot.");
        }
    }

    abstract class Thing
    {
        string name { get; set; }

        public Thing(string name)
        {
            this.name = name;
        }

        public abstract void willUse();
    }

    class Notepad : Thing
    {
        public Notepad(string name) : base(name) { }
        public override void willUse()
        {
            Console.WriteLine("Notepad : Blank page, a canvas, thoughts take flight, " +
                "a digital quill in hand, I write.");
        }
    }
    class Table : Thing
    {
        public Table(string name) : base(name) { }
        public override void willUse()
        {
            Console.WriteLine("Table   : A sturdy frame, a surface bare, holding stories, meals, and care.");
        }
    }
}
