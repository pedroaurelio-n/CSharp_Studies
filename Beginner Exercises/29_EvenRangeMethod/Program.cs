using System;

namespace _29_EvenRangeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Enter the first number: ", false);
            int a = EnterNumber();

            PrintMessage("Enter the second number: ", false);
            int b = EnterNumber();

            PrintMessage("", true);

            ShowRange(a, b);

            Console.ReadKey();
        }

        static int EnterNumber()
        {
            return int.Parse(Console.ReadLine());
        }

        static void PrintMessage(string message, bool skipLine)
        {
            if (skipLine)
                Console.WriteLine(message);

            else
                Console.Write(message);
        }

        static void ShowRange(int a, int b)
        {
            int[] numberArray = { a, b };

            for (int i = Math.Min(a, b) + 1; i < Math.Max(a, b); i++)
            {
                if (i % 2 == 0)
                    PrintMessage(i.ToString(), true);
            }
        }
    }
}
