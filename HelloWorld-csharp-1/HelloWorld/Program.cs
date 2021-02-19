using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            Console.WriteLine($"Hello {name} {lastName}!");
        }
    }
}
