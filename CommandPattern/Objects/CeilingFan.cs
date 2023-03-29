namespace StrategyPattern.Objects;

public class CeilingFan
{
    private static readonly int HighSpeed = 3;
    private static readonly int MediumSpeed = 2;
    private static readonly int LowSpeed = 1;
    private static readonly int FanOff = 0;
    private readonly string _location;
    private int _speed;

    public CeilingFan(string location)
    {
        _location = location;
        _speed = FanOff;
    }

    public void High()
    {
        _speed = HighSpeed;
        Console.WriteLine($"{_location} ceiling fan is on to high");
    }

    public void Medium()
    {
        _speed = MediumSpeed;
        Console.WriteLine($"{_location} ceiling fan is on to medium.");
    }

    public void Low()
    {
        _speed = LowSpeed;
        Console.WriteLine($"{_location} ceiling fan is on to low.");
    }

    public void Off()
    {
        _speed = FanOff;
        Console.WriteLine($"{_location} ceiling fan is off.");
    }

    public int GetSpeed()
    {
        return _speed;
    }
}