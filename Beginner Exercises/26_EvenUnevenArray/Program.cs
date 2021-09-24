using System;

namespace _26_EvenUnevenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 9, 23, 56, 23, 34, 66, 78, 79, 34, 12, 16, 15 };

            int evens = 0;
            int unevens = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    evens++;

                else
                    unevens++;
            }

            Console.WriteLine($"In the array, there are {evens} even numbers and {unevens} uneven numbers");

            Console.ReadKey();
        }
    }
}
