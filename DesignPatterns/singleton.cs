// The Singleton pattern ensures a class has only one instance and provides a global point of access to it.

// Theory: It restricts the instantiation of a class to one "single" instance.

public class Singleton
{
    private static Singleton _instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is doing something.");
    }
}
