namespace Encaplsulation
{
    public class Airport
    {
        public void Flying(IFlyingTransport transport)
        {
            transport.Fly();
        }
        public void Landing(IFlyingTransport transport)
        {
            transport.Land();
        }
    }
}