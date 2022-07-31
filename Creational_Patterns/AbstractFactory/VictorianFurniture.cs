namespace AbstractFactory;
public class VictorianFurniture :IFurniture
{
    public void LayDown()
    {
        Console.WriteLine("Laying down a Victorian chair");
    }
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair");
    }
}