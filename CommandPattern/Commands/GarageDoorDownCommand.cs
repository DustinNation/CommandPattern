using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;
using StrategyPattern.Objects.GarageDoor;

namespace StrategyPattern.Commands
{
    public class GarageDoorDownCommand: ICommand
    {
        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }

        public GarageDoor GarageDoor { get; set; }
        public void Execute()
        {
            GarageDoor.Down();
        }
    }
}
