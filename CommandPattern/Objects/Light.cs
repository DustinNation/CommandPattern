using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Objects
{
    public class Light
    {
        public string Name { get; set; }

        public Light(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine($"{Name} light is on.");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} light is off.");
        }
    }
}
