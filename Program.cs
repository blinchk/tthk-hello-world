using System;

namespace tthk_hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Enter your name: ");
            person.name = Console.ReadLine();
            Console.Write("How old are you? ");
            person.age = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Hello, {0}! You are {1} y.o. ", person.name, person.age);
            if (person.age >= 18)
                Console.WriteLine("and your non-minor.");
            else
                Console.WriteLine("and your minor.");
        }
    }
    class Person
    {
        public string name;
        public int age;
    }
}
