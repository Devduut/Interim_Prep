// The Proxy pattern provides a surrogate or placeholder for another object to control access to it.

// Theory: A proxy can be used to control access to the real object, add additional functionality, or manage resources.

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
