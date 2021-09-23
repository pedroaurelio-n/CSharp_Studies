using System;

namespace _23_5NumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine($"The total sum is {sum}");

            Console.ReadKey();
        }
    }
}
