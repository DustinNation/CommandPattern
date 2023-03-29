namespace CommandPattern.Objects;

public class TV
{
    private readonly string _location;

    public TV(string location)
    {
        _location = location;
    }

    public void On()
    {
        Console.WriteLine("Turn TV on.");
    }

    public void Off()
    {
        Console.WriteLine("Turn TV off.");
    }

    public void SetInputChannel(int channel)
    {
        Console.WriteLine($"Set TV channel to {channel}");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Set TV volume to {level}");
    }
}