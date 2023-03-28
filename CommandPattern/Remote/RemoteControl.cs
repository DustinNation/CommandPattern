using System.Text;
using StrategyPattern.Commands;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Remote;

public class RemoteControl
{
    public ICommand[] onCommands { get; set; }
    public ICommand[] offCommands { get; set; }

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
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        onCommands[slot] = onCommand; 
        offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot)
    {
        onCommands[slot].Execute();
    }

    public void OffButtonWasPushed(int slot)
    {
        offCommands[slot].Execute();
    }

    public string GenerateCommandString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("\n---------- Remote Control ----------\n");
        for (var i = 0; i < onCommands.Length; i++)
        {
            stringBuilder.AppendFormat("[Slot " + i + "] " + onCommands[i].GetType().Name +  "                    " + offCommands[i].GetType().Name + "\n");
        }

        return stringBuilder.ToString();
    }
}