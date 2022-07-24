namespace Abstraction
{
    public class Coffee
    {
        public double Price { get; set; }
        public string? Name { get; set; }
        public CoffeeType Type { get; set; }

        public Coffee(double price, string? name, CoffeeType type)
        {
            Price = price;
            Name = name;
            Type = type;
        }
    }
}