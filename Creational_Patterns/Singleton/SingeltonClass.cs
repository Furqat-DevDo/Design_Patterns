namespace Singleton;
public sealed class SingletonClass
{
    private static SingletonClass instance = null;
    private SingletonClass()
    {
    }
    public static SingletonClass Instance
    {
        get
        {
            return instance ??= new SingletonClass();
        }
    }
}