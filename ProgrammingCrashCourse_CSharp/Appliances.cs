using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgrammingCrashCourse_CSharp
{
    internal class Appliances
    {
        //these methods are connected to Polymorphism found at case # 17
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

    //this class is Abstraction found at case # 18
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

    //this class is for Collection Topic found at case # 20
    class Place 
    { 
        public string name { get; set; }
        public string[] location { get; set; }

        public Place(string Name, string[] Location)
        {
            this.name = Name;
            this.location = Location;
        }
    }

    //these classes are for Event and Delegates found at case # 21
    public class Video
    {
        public string Title { get; set; }
    }
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        public event VideoEncodedEventHandler videoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video....");
            Thread.Sleep(3000);

            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if (videoEncoded != null)
                videoEncoded(this, EventArgs.Empty);
        }
    }
    public class MailService
    {
        public void onVideoEncoded(object souce, EventArgs e)
        {
            Console.WriteLine("MailService: Sending an email . . .");
        }
    }
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("MessageService : Sending a text message . . .");
        }
    }
}
