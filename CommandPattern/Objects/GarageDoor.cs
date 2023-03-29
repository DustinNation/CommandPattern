namespace CommandPattern.Objects;

public class GarageDoor
{
    public GarageDoor(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void Up()
    {
        Console.WriteLine("Garage door going up.");
    }

    public void Down()
    {
        Console.WriteLine("Garage door going down.");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping garage door in it's place.");
    }
}