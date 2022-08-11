using System.Reflection.Metadata;
namespace Prototype;
public static class Program
{
    public static void Main()
    {
        var kevin = new Man
        {
            FirstName = "Kevin",
            LastName = "Faygee",
            BirthDate = new DateTime (1974,04,23),
            Adress = "Washington DC USA",
            Phone = "+1202.357.2020",
            Gender = "Man",
            Email = "Faygee@Marvel.com"
        };

        var steeve = kevin.Clone();
        steeve.FirstName = "Steeve";
        System.Console.WriteLine($"{kevin} \n {steeve}");
    }
}