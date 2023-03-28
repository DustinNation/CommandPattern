using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Remote
{
    internal class SimpleRemoteControl
    {
        public ICommand Slot1 { get; set; }

        public void SetCommand(ICommand command)
        {
            Slot1 = command;
        }

        public void ButtonWasPressed()
        {
            Slot1.Execute();
        }
    }
}
