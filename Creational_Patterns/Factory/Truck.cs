namespace Factory;
public class Truck : ITransport
{
    public void Start()
    {
        Console.WriteLine("Truck started");
    }

    public void Stop()
    {
        Console.WriteLine("Truck stopped");
    }

    public void Deliver()
    {
        Console.WriteLine("Truck delivered");
    }
}