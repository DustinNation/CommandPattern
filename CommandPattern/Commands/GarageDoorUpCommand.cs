using StrategyPattern.Interfaces;
using StrategyPattern.Objects.GarageDoor;

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