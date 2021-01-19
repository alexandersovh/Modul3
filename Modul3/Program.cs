using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Alexandr";
            byte age = 35;
            bool pet = true;
            double size = 29.9;
            Console.WriteLine(MyName);
            Console.WriteLine("Привет, \n мир!");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0040");
            Console.WriteLine("\x85");

            Console.WriteLine("My name is {0}\nMy age is {1}\nDo yur have a pet?{2}\nMy shoe size is {3}",MyName,age,pet,size);

            Console.ReadKey();
        }
    }
}
