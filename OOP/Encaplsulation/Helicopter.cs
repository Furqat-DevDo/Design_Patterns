namespace Encaplsulation
{
    public class Helicopter : IFlyingTransport
    {
        public void Fly()
        {
            Console.WriteLine("Helicopter is flying");
        }
        public void Land()
        {
            Console.WriteLine("Helicopter is landing");
        }
    }
}