using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Alexandr";
            Console.WriteLine(MyName);
            Console.WriteLine("Привет, \n мир!");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x85");
            Console.ReadKey();
        }
    }
}
