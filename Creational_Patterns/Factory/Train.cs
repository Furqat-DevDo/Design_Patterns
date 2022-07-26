namespace Factory;
public class Train : ITransport
{
    public void Start()
    {
        Console.WriteLine("Train started");
    }

    public void Stop()
    {
        Console.WriteLine("Train stopped");
    }

    public void Deliver()
    {
        Console.WriteLine("Train delivered");
    }
}