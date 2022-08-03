namespace Builder
{
    public interface IProduct
    {
        string PartA { get; set; }
        string PartB { get; set; }
        string PartC { get; set; }
        void Showresult();
    }
}