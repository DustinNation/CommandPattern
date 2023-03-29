using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Objects
{
    public class HotTub
    {
        public void Circulate()
        {
            Console.WriteLine("Turn on water circulation");
        }
        public void JetsOn()
        {
            Console.WriteLine("Turn on the jets.");
        }

        public void JetsOff()
        {
            Console.WriteLine("Turn off the jets.");
        }

        public void SetTemperature(int temp)
        {
            Console.WriteLine($"Adjust temperature to {temp}");
        }
    }
}
