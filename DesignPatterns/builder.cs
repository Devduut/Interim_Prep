// The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

// Theory: It provides a way to construct a complex object step by step.

public class Product
{
    public string PartA { get; set; }
    public string PartB { get; set; }
}

public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    Product GetResult();
}

public class ConcreteBuilder : IBuilder
{
    private Product _product = new Product();

    public void BuildPartA()
    {
        _product.PartA = "PartA";
    }

    public void BuildPartB()
    {
        _product.PartB = "PartB";
    }

    public Product GetResult()
    {
        return _product;
    }
}

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public void Construct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
    }
}
