namespace Factory
{
    public class LogisticCompany
    {
        public void Delivery(ITransport transport)
        {
            transport.Start();
            transport.Deliver();
            transport.Stop();
        }
    }
}