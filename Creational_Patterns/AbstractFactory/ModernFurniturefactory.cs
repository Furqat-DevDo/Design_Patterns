namespace AbstractFactory;
public class ModernFurnitureFactory : AbstractFurnitureFactory
{
    public override IFurniture CreateFurniture()
    {
        return new ModernFurniture();
    }
}