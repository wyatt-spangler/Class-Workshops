using System;

namespace Class_Workshops
{
    class Program
    {
        static void Main(string[] args)
        {
            myHoomans();
        }
        static void myHoomans()
        {
            HoomanClass MrSekol = new HoomanClass();
            MrSekol.age = 99; //haha old
            MrSekol.dogName = "Mozzy";
            MrSekol.hasDog = true;
            MrSekol.name = "Michael";

            MrSekol.Greeting();
        }
    }
}
