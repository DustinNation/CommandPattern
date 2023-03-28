using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;
using StrategyPattern.Objects;

namespace StrategyPattern.Commands
{
    internal class CeilingFanOffCommand: ICommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public CeilingFan CeilingFan { get; set; }
        public void Execute()
        {
            CeilingFan.Off();
        }
    }
}
