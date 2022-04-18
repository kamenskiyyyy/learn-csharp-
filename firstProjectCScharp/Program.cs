using System;

namespace firstProjectCScharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var hello = "Hello";
            var c = 234;

            Console.WriteLine(hello.GetType().ToString()); 
            Console.WriteLine(c.GetType().ToString());
        }
    }
}
