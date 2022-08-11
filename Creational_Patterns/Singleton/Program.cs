namespace Singleton;
public static class Program
{
    public static void Main()
    {
        var instance = SingletonClass.Instance;
        var secondInstance = SingletonClass.Instance;
        Console.WriteLine(instance == secondInstance);
    }
}
