namespace AbstractFactory;
public static class Program
{
    public static void Main()
    {
        AbstractFurnitureFactory _factory = new VictorianFurnitureFactory();
        _factory.CreateFurniture().LayDown();
        _factory.CreateFurniture().SitOn();
        _factory = new ModernFurnitureFactory();
        _factory.CreateFurniture().LayDown();
        _factory.CreateFurniture().SitOn();
    }
}
