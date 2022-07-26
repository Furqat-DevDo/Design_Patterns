namespace Factory;
public static class Program
{
    public static void Main()
    {
        var company = new LogisticCompany();
        company.Delivery(new Truck());
        company.Delivery(new Plane());
        company.Delivery(new Train());
        company.Delivery(new Ship());
    }
}
