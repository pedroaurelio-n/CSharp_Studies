using System;

namespace _15_SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopProgram = true;

            do
            {
                Console.WriteLine("2 Number Calculator\n");

                Console.Write("Enter the first number: ");
                float firstNumber = float.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                float secondNumber = float.Parse(Console.ReadLine());

                bool loopOperation = true;
                char operation;
                float result;
                Console.WriteLine("\n+ = Addition\n- = Subtraction\n* = Multiplication\n/ = Division\n");

                do
                {
                    Console.Write("Enter the desired operation: ");
                    operation = char.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case '+':
                            result = firstNumber + secondNumber;
                            loopOperation = false;
                            break;

                        case '-':
                            result = firstNumber - secondNumber;
                            loopOperation = false;
                            break;

                        case '*':
                            result = firstNumber * secondNumber;
                            loopOperation = false;
                            break;

                        case '/':
                            result = firstNumber / secondNumber;
                            loopOperation = false;
                            break;

                        default: Console.WriteLine("Invalid operation!\n"); result = 0; break;
                    }

                } while (loopOperation);

                Console.WriteLine($"\nResult = {firstNumber} {operation} {secondNumber} = {result}\n");

                bool loopContinue = true;

                do
                {
                    Console.Write("Do you wish to exit? (Y/N): ");
                    char continueChar = char.Parse(Console.ReadLine());

                    switch (continueChar)
                    {
                        case 'Y': loopContinue = false; loopProgram = false; break;
                        case 'N': loopContinue = false; Console.WriteLine("\nRestarting calculator... Press any key to continue\n\n"); Console.ReadKey(); break;
                        default: Console.WriteLine("Invalid option!\n"); break;
                    }

                } while (loopContinue);


            } while (loopProgram);

            Console.WriteLine("\nExiting program... Press any key to exit");
            Console.ReadKey();
        }
    }
}
