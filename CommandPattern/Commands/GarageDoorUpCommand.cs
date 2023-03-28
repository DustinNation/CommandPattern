using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Commands;

internal class GarageDoorUpCommand : ICommand
{
    public GarageDoorUpCommand(GarageDoor garageDoor)
    {
        GarageDoor = garageDoor;
    }

    public GarageDoor GarageDoor { get; set; }

    public void Execute()
    {
        GarageDoor.Up();
    }
}