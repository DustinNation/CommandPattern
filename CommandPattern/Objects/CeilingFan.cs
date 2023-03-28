using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Objects
{
    public class CeilingFan
    {
        public string Name { get; set; }

        public CeilingFan(string name)
        {
            Name = name;
        }

        public void High()
        {
            Console.WriteLine($"{Name} ceiling fan is on to high");
        }

        public void Medium()
        {
            Console.WriteLine($"{Name} ceiling fan is on to medium.");
        }
        public void Low()
        {
            Console.WriteLine($"{Name} ceiling fan is on to low.");
        }
        public void On()
        {
            Console.WriteLine($"{Name} ceiling fan is on.");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} ceiling fan is off.");
        }

        public void GetSpeed()
        {
            Console.WriteLine($"Whatever GetSpeed is?");
        }
    }
}
