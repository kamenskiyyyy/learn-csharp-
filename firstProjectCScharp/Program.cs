using System;

namespace firstProjectCScharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Your name is {name}");
        }
    }
}
