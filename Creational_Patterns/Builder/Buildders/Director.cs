namespace Builder
{
    public class Director
    {
        public void Construct(ConcreteBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
            System.Console.WriteLine("Director: I'm building the product");
        }
    }
}