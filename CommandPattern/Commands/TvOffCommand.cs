using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace CommandPattern.Commands;

public class TvOffCommand : ICommand
{
    private readonly TV _tv;

    public TvOffCommand(TV tv)
    {
        _tv = tv;
    }

    public void Execute()
    {
        _tv.Off();
    }

    public void Undo()
    {
        _tv.On();
    }
}