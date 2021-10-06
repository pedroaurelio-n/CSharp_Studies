using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Inheritance
{
    public class Client : Person
    {
        public float Balance { get; set; }

        public string GetBalance()
        {
            return "$" + Balance.ToString("0.00");
        }

        public override string GetStatus()
        {
            return Name + " is a Client";
        }
    }
}
