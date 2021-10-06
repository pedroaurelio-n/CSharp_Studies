using System;
using System.Collections.Generic;
using System.Text;

namespace _4_InheritanceAbstraction
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetInformation()
        {
            return Name + " - " + Age;
        }

        public abstract string GetStatus();
    }
}
