using System;

namespace _1_FirstContact
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person();

            personOne.FirstName = "Pedro";
            personOne.LastName = "Aurelio";
            personOne.Age = 20;
            personOne.Balance = 0;

            Person personTwo = new Person();

            personTwo.FirstName = "Lalo";
            personTwo.LastName = "Salamanca";
            personTwo.Age = 34;
            personTwo.Balance = 5000;

            personOne.ShowInformation();
            Console.WriteLine();
            personTwo.ShowInformation();

            Console.ReadKey();
        }
    }
}
