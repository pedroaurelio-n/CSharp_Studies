using System;

namespace _31_RaiseBalanceMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Enter your balance: $", false);
            int currentBalance = EnterBalance();

            PrintMessage("Enter your category: ", false);
            string category = Console.ReadLine();

            PrintMessage("", true);

            int newBalance = ApplyRaise(currentBalance, category);

            PrintMessage("", true);

            PrintMessage($"Your new balance is ${newBalance}", true);

            Console.ReadKey();
        }

        static int EnterBalance()
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

        static int ApplyRaise(int balance, string category)
        {
            int raisedBalance = balance;

            switch (category)
            {
                case "A": PrintMessage("A category chosen. Applying $400 raise...", true); raisedBalance += 400; break;
                case "B": PrintMessage("B category chosen. Applying $200 raise...", true); raisedBalance += 200; break;
                case "C": PrintMessage("C category chosen. Applying $100 raise...", true); raisedBalance += 100; break;
                default: PrintMessage("Invalid category. Applying $50 raise...", true); raisedBalance += 50; break;
            }

            return raisedBalance;
        }
    }
}
