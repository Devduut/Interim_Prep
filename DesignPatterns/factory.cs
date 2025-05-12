// The Facade pattern provides a simplified interface to a complex subsystem.

// Theory: It hides the complexities of the system and provides an interface to the client to interact with the system.

public interface ISubject
{
    void Request();
}

public class RealSubject : ISubject
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling Request.");
    }
}

public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public void Request()
    {
        if (_realSubject == null)
        {
            _realSubject = new RealSubject();
        }
        Console.WriteLine("Proxy: Logging request.");
        _realSubject.Request();
    }
}
