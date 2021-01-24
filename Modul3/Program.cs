using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter yuor name: ");
            var name = Console.ReadLine();
            Console.Write("Enter yuor age: ");
            byte age = checked ((byte) int.Parse(Console.ReadLine()));
            Console.WriteLine("Yuor name is {0} and yuor age is {1}", name, age);
            Console.Write("Enter yuor birthdata: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine($"Yuor birthdate is {birthdate}");
            Console.ReadKey();
        }
    }
}
