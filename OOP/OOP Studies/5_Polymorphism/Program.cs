using System;

namespace _5_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Employee();
            person1.Name = "Waldo";
            person1.Age = 22;

            Person person2 = new Client();
            person2.Name = "Richard";
            person2.Age = 99;

            Console.WriteLine(person1.GetInformation());
            Console.WriteLine(person1.GetStatus());
            Console.WriteLine();

            Console.WriteLine(person2.GetInformation());
            Console.WriteLine(person2.GetStatus());
            Console.ReadKey();
        }
    }
}
