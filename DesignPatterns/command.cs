// The Command pattern encapsulates a request as an object, thereby allowing for parameterization of clients with queues, requests, and operations.

// Theory: It turns a request into a stand-alone object that contains all information about the request.


public interface ICommand
{
    void Execute();
}

public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is On");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is Off");
    }
}

public class TurnOnCommand : ICommand
{
    private Light _light;

    public TurnOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}

public class TurnOffCommand : ICommand
{
    private Light _light;

    public TurnOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}
