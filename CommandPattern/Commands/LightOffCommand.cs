using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Commands
{
    internal class LightOffCommand:ICommand
    {
        public Light Light { get; set; }

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Execute()
        {
            Light.Off();
        }
    }
}
