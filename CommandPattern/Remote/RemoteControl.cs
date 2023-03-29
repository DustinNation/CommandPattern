using System.Text;
using StrategyPattern.Commands;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Remote;

public class RemoteControl
{
    private ICommand[] onCommands { get; set; }
    private ICommand[] offCommands { get; set; }
    private ICommand UndoCommand { get; set; }

    public RemoteControl()
    {
        onCommands = new ICommand[7];
        offCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();

        for (var i = 0; i < 7; i++)
        {
            onCommands[i] = noCommand;
            offCommands[i] = noCommand;
        }

        UndoCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand; 
        offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        onCommands[slot].Execute();
        UndoCommand = onCommands[slot];
    }

    public void OffButtonWasPushed(int slot)
    {
        offCommands[slot].Execute();
        UndoCommand = offCommands[slot];
    }

    public void UndoButtonWasPushed()
    {
        UndoCommand.Undo();
    }
    public void GenerateCommandString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("\n---------- Remote Control ----------\n");
        for (var i = 0; i < onCommands.Length; i++)
        {
            stringBuilder.Append("[Slot " + i + "] " + onCommands[i].GetType().Name +  "      " + offCommands[i].GetType().Name + " \n");
        }

        stringBuilder.Append("[Undo] " + UndoCommand.GetType().Name + "\n");

        Console.WriteLine(stringBuilder.ToString());
    }
}