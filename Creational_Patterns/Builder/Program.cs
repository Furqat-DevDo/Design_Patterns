namespace Builder;
public static class Program
{
    public static void Main()
    {
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Construct(builder);
        var product = builder.GetResult();
        product.Showresult();
    }
}
