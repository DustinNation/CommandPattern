using StrategyPattern.Interfaces;

namespace StrategyPattern.Commands;

public class NoCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("No command assigned");
    }
}