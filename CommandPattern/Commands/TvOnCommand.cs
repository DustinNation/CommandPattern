using CommandPattern.Objects;
using StrategyPattern.Interfaces;

namespace CommandPattern.Commands;

public class TvOnCommand : ICommand
{
    private TV _tv;

    public TvOnCommand(TV tv)
    {
        _tv = tv;
    }

    public void Execute()
    {
        _tv.On();
    }

    public void Undo()
    {
        _tv.Off();
    }
}