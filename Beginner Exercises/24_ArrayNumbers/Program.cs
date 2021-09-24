using System;

namespace _24_ArrayNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 31, 37, 34, 46, 20, 42, 16, 10, 30, 26, 38};

            foreach(int number in numbers)
            {
                if (number > 18 && number < 35)
                    Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
