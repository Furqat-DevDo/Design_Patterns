namespace AbstractFactory;
public class ModernFurniture : IFurniture
{
    public void LayDown()
    {
        System.Console.WriteLine("Laying down on Moern Soffa");
    }

    public void SitOn()
    {
        System.Console.WriteLine("Sitting on modern armchair");
    }
}