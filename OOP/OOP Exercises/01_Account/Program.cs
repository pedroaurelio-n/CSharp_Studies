using System;

namespace _01_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create your bank account!\n");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your balance: $");
            float balance = float.Parse(Console.ReadLine());

            Account account1 = new Account(name, balance);

            Console.WriteLine("\nAccount created!\n");
            Console.WriteLine(account1);

            Console.WriteLine();

            Console.Write("Enter a value to deposit: $");
            account1.DepositMoney(float.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine(account1);

            Console.WriteLine();

            Console.Write("Enter a value to withdraw: $");
            account1.WithdrawMoney(float.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine(account1);

            Console.ReadKey();
        }
    }
}
