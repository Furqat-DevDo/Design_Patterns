namespace AbstractFactory;
public class VictorianFurnitureFactory : AbstractFurnitureFactory
{
    public override IFurniture CreateFurniture()
    {
        return new VictorianFurniture();
    }
}