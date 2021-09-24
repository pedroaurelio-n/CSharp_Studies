using System;

namespace _28_SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 6, 4, 8, 25, 4, 2, 8, 12, 45, 12, 6, 7, 8 };

            int sum = 0;

            foreach (int number in numbers)
            {
                if (number > 15)
                    sum += number;
            }

            Console.WriteLine($"In the array, the sum of all numbers greater than 15 is {sum}");

            Console.ReadKey();
        }
    }
}
