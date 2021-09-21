using System;

namespace _16_SumWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many numbers you want to add: ");
            int counterInt = int.Parse(Console.ReadLine());
            int counter = counterInt;
            int sum = 0;

            Console.WriteLine("Enter the numbers:");

            while (counter > 0)
            {
                sum += int.Parse(Console.ReadLine());
                counter--;
            }

            Console.WriteLine($"\nThe sum of all the {counterInt} numbers is {sum}");

            Console.ReadKey();
        }
    }
}
