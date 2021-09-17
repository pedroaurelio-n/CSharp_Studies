using System;

namespace _7_Age18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("You're eighteen or older!");

            else
                Console.WriteLine("You're under eighteen!");

            Console.ReadKey();
        }
    }
}
