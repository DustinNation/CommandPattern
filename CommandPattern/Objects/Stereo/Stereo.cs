using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Objects.Stereo
{
    public  class Stereo
    {
        public string Name { get; set; }

        public Stereo(string name)
        {
            Name = name;
        }

        public void On()
        {
            Console.WriteLine($"{Name} stereo is on.");
        }

        public void Off()
        {
            Console.WriteLine($"{Name} stereo is off.");
        }

        public void SetCd()
        {
            Console.WriteLine($"{Name} stereo control set to CD.");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{Name} stereo control set to DVD.");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{Name} stereo control set to radio.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"{Name} stereo control for volume to {level}.");
        }
    }
}
