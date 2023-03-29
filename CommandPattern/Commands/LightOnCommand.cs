using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Commands;

internal class LightOnCommand : ICommand
{
    public LightOnCommand(Light light)
    {
        Light = light;
    }

    public Light Light { get; set; }

    public void Execute()
    {
        Light.On();
    }

    public void Undo()
    {
        Light.Off();
    }
}