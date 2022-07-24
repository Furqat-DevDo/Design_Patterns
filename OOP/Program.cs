using Abstraction;

public class Program
{
    public static void Main(string[] args)
    {
        var coffee = new Coffee(1.5, "Espresso", CoffeeType.Espresso);
        CoffeeMachine.MakeCoffeeAsync(coffee).Wait();
    }
}