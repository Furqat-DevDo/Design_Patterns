namespace Factory;
public class Ship : ITransport
{
    public void Start()
    {
        Console.WriteLine("Ship started");
    }

    public void Stop()
    {
        Console.WriteLine("Ship stopped");
    }

    public void Deliver()
    {
        Console.WriteLine("Ship delivered");
    }
}