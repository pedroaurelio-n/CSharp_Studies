using System;

namespace _25_ArrayPositives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating numbers within -100 and 100...");

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();
                numbers[i] = random.Next(-100, 101);
            }

            int positives = 0;
            string arrayString = "";

            foreach (int number in numbers)
            {
                arrayString += number.ToString();
                arrayString += ", ";

                if (number > 0)
                    positives++;
            }

            arrayString.Substring(arrayString.Length - 2);


            Console.WriteLine($"\nIn the array: {arrayString}");
            Console.WriteLine($"There are {positives} positive numbers!");

            Console.ReadKey();
        }
    }
}
