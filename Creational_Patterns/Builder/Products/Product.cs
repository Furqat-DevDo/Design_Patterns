namespace Builder
{
    public class Product : IProduct
    {
        public string PartA { get; set; } = "Part A";
        public string PartB { get; set; } = "Part B";
        public string PartC { get; set; } = "Part C";
        public void Showresult()
        {
            System.Console.WriteLine($"Product: {PartA}, {PartB}, {PartC}");
        }
    }
}