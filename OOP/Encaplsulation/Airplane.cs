namespace Encaplsulation
{
    public class Airplane : IFlyingTransport
    {
        public void Fly()
        {
            Console.WriteLine("Airplane is flying");
        }

        public void Land()
        {
            Console.WriteLine("Airplane is landing");
        }
    }
} 