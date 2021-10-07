using System;
using System.Collections.Generic;

namespace _03_EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Register\n");

            Console.Write("Enter the employee's full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter the employee's age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter the employee's salary: ");
            float salary = float.Parse(Console.ReadLine());

            List<Employee> employeeList = new List<Employee>();

            bool loopFunction = true;

            do
            {
                Console.Write("Enter the employee's function (Shopkeeper/Deliveryman): ");
                string function = Console.ReadLine();

                switch (function.ToUpper())
                {
                    case "SHOPKEEPER":
                        Console.Write("Enter the shopkeeper's comission: ");
                        float comission = float.Parse(Console.ReadLine());

                        Shopkeeper shopkeeper = new Shopkeeper(fullName, age, salary, comission);
                        employeeList.Add(shopkeeper);
                        loopFunction = false;
                        break;

                    case "DELIVERYMAN":
                        Console.Write("Enter the deliveryman's city: ");
                        string city = Console.ReadLine();

                        Deliveryman deliveryman = new Deliveryman(fullName, age, salary, city);
                        employeeList.Add(deliveryman);
                        loopFunction = false;
                        break;

                    default: Console.WriteLine("Invalid function! Try again.\n"); break;
                }
            } while (loopFunction);

            Console.WriteLine("\n" + employeeList[0].ToString() + "\n");

            employeeList[0].Raise();

            Console.ReadKey();
        }
    }
}
