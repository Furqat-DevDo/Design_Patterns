namespace Builder
{
    public class ConcreteBuilder: IBuilder
    {

        public void BuildPartA()
        {
            System.Console.WriteLine("Building Part A");
        }

        public void BuildPartB()
        {
            System.Console.WriteLine("Building Part B");
        }

        public void BuildPartC()
        {
            System.Console.WriteLine("Building Part C");
        }
        public IProduct GetResult()
        {
          return new Product();
        }
    }
}