// See https://aka.ms/new-console-template for more information

var obj = Singleton.GetInstance();
var obj1 = Singleton.GetInstance();
var obj2 = Singleton.GetInstance();

Console.WriteLine(Singleton.Count);

public class Singleton
{
    private static Singleton _instance;
    public static int Count; 

    private Singleton()
    {
        Count++;
    }

    public static Singleton GetInstance()
    {
        if(_instance is null) _instance = new Singleton();
        return _instance;
    }

}