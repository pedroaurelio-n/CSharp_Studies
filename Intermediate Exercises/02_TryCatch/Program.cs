using System;

namespace _02_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {     
            Console.Write("Enter a number: ");

            try
            {
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter a divisor: ");

                try
                {
                    int y = int.Parse(Console.ReadLine());

                    try
                    {
                        CheckNumber(x);
                        Console.WriteLine($"\n{x} / {y} = {x / y}");
                    }

                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("You can't divide by zero!");
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("You must type a number!");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("You must type a number!");
            }

            Console.ReadKey();
        }

        static void CheckNumber(float x)
        {
            if (x <= 10)
                throw new Exception("Number not bigger than 10!");
        }
    }
}
