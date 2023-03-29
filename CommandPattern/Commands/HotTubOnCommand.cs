using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace CommandPattern.Commands;

public class HotTubOnCommand : ICommand
{
    private HotTub _hotTub;

    public HotTubOnCommand(HotTub hotTub)
    {
        _hotTub = hotTub;
    }

    public void Execute()
    {
        _hotTub.JetsOn();
    }

    public void Undo()
    {
        _hotTub.JetsOff();
    }
}