using System;

namespace _4_InheritanceAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Waldo";
            employee.Age = 22;
            employee.HourRate = 6;
            employee.WorkHours = 8;

            Client client = new Client();
            client.Name = "Richard";
            client.Age = 99;
            client.Balance = 500;

            Console.WriteLine(employee.GetInformation());
            Console.WriteLine(employee.GetWage());
            Console.WriteLine(employee.GetStatus());
            Console.WriteLine();

            Console.WriteLine(client.GetInformation());
            Console.WriteLine(client.GetBalance());
            Console.WriteLine(client.GetStatus());
            Console.ReadKey();
        }
    }
}
