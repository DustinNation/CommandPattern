using StrategyPattern.Interfaces;
using StrategyPattern.Objects;

namespace StrategyPattern.Commands;

internal class CeilingFanHighCommand : ICommand
{
    private CeilingFan _ceilingFan;
    private int _previousSpeed;

    public CeilingFanHighCommand(CeilingFan ceilingFan)
    {
        _ceilingFan = ceilingFan;
    }


    public void Execute()
    {
        _previousSpeed = _ceilingFan.GetSpeed();
        _ceilingFan.High();
    }

    public void Undo()
    {
        switch (_previousSpeed)
        {
            case 3: 
                _ceilingFan.High(); 
                break;
            case 2:
                _ceilingFan.Medium();
                break;
            case 1:
                _ceilingFan.Low();
                break;
            default:
                _ceilingFan.Off();
                break;
        }
    }
}