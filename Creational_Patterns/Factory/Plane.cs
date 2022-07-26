namespace Factory;
public class Plane : ITransport
{
    public void Start()
    {
        Console.WriteLine("Plane started");
    }

    public void Stop()
    {
        Console.WriteLine("Plane stopped");
    }

    public void Deliver()
    {
        Console.WriteLine("Plane delivered");
    }
}
