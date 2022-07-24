namespace Abstraction;

public class CoffeeMachine
{
    public static async Task BoilWaterAsync()
    {
        Console.WriteLine("Boiling water");
        await Task.Delay(1000);
    }

    public static async Task BrewCoffeeAsync(Coffee coffee)
    {
        Console.WriteLine($"Brewing {coffee.Name}");
        await Task.Delay(1000);
    }

    public static async Task PourCoffeeAsync(Coffee coffee)
    {
        Console.WriteLine($"Pouring {coffee.Name}");
        await Task.Delay(1000);
    }

    public static async Task<Coffee> MakeCoffeeAsync(Coffee coffee)
    {
        await Task.WhenAll(BoilWaterAsync(), BrewCoffeeAsync(coffee), PourCoffeeAsync(coffee));
        System.Console.WriteLine("Coffee is ready!");
        return coffee;
    }
}
