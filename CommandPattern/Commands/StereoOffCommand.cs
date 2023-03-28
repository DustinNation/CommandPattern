using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Commands
{
    public class StereoOffCommand: ICommand
    {
        public Stereo Stereo { get; set; }

        public StereoOffCommand(Stereo stereo)
        {
            Stereo = stereo;
        }
        public void Execute()
        {
            Stereo.Off();
        }
    }
}
