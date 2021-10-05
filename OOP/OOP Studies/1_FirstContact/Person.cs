using System;
using System.Collections.Generic;
using System.Text;

namespace _1_FirstContact
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public float Balance { get; set; }

        public void ShowInformation()
        {
            Console.WriteLine($"Name:       {FirstName} {LastName}\n" +
                              $"Age:        {Age}\n" +
                              $"Balance:    ${Balance.ToString("0.00")}");
        }
    }
}
