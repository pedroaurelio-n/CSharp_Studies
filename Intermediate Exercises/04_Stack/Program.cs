using System;
using System.Collections;

namespace _04_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("Monday");
            stack.Push("Tuesday");
            stack.Push("Wednesday");
            stack.Push("Thursday");
            stack.Push("Friday");
            stack.Push("Saturday");
            stack.Push("Sunday");

            foreach (var value in stack)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            var pop = stack.Pop();
            var peek = stack.Peek();

            foreach (var value in stack)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            Console.WriteLine($"Pop is {pop}");
            Console.WriteLine($"Peek is {peek}");

            Console.ReadKey();
        }
    }
}
