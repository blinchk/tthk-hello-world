using System;

namespace tthk_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
