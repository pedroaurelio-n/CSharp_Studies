using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Polymorphism
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetInformation()
        {
            return Name + " - " + Age;
        }

        public virtual string GetStatus()
        {
            return Name + " is a Person";
        }
    }
}
