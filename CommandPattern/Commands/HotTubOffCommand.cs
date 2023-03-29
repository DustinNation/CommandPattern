using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace CommandPattern.Commands
{
    public class HotTubOffCommand : ICommand
    {
        private HotTub _hotTub;

        public HotTubOffCommand(HotTub hotTub)
        {
            _hotTub = hotTub;
        }

        public void Execute()
        {
            _hotTub.JetsOff();
        }

        public void Undo()
        {
            _hotTub.JetsOn();
        }
    }
}
