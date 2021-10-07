using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Polymorphism
{
    public class Employee : Person
    {
        public float HourRate { get; set; }
        public int WorkHours { get; set; }

        public string GetWage()
        {
            float wage = HourRate * WorkHours;
            return "$" + wage.ToString("0.00");
        }

        public override string GetStatus()
        {
            return Name + " is an Employee";
        }
    }
}
