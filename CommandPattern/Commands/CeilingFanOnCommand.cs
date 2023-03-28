using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;
using StrategyPattern.Objects;

namespace StrategyPattern.Commands
{
    internal class CeilingFanOnCommand: ICommand
    {
        public CeilingFan CeilingFan { get; set; }
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            CeilingFan.On();
        }
    }
}
