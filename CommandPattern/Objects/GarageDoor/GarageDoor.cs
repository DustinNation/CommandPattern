using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Objects.Lights;

namespace StrategyPattern.Objects.GarageDoor
{
    public class GarageDoor
    {
        public string Name { get; set; }
     
        public GarageDoor(string name)
        {
            Name = name;
        }

        public void Up()
        {
            Console.WriteLine("Garage door going up.");
        }

        public void Down()
        {
            Console.WriteLine("Garage door going down.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping garage door in it's place.");
        }
    }
}
