using StrategyPattern.Interfaces;
using StrategyPattern.Objects.Lights;

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
}