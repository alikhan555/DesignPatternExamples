
IComputer desktop = ComputerFactory.CreateComputer("Desktop", 32, 500, 4100);
IComputer laptop = ComputerFactory.CreateComputer("Laptop", 16, 250, 3700);
IComputer server = ComputerFactory.CreateComputer("Server", 64, 2000, 3000);
IComputer android = ComputerFactory.CreateComputer("Android", 8, 128, 1700);

Console.WriteLine(desktop.GetType());
Console.WriteLine(laptop.GetType());
Console.WriteLine(server.GetType());
Console.WriteLine(android.GetType());

public interface IComputer
{
    string GetType();
}

public class Desktop : IComputer
{
    private int _memory;
    private int _cpu;
    private int _storage;

    public Desktop(int memory, int storage, int cpu)
    {
        _memory = memory;
        _storage = storage;
        _cpu = cpu;
    }

    string IComputer.GetType()
    {
        return $"Desktop: MEMORY={_memory}, STORAGE={_storage}, CPU={_cpu}";
    }
}

public class Laptop : IComputer
{
    private int _memory;
    private int _cpu;
    private int _storage;

    public Laptop(int memory, int storage, int cpu)
    {
        _memory = memory;
        _storage = storage;
        _cpu = cpu;
    }

    string IComputer.GetType()
    {
        return $"Laptop: MEMORY={_memory}, STORAGE={_storage}, CPU={_cpu}";
    }
}

public class Server : IComputer
{
    private int _memory;
    private int _cpu;
    private int _storage;

    public Server(int memory, int storage, int cpu)
    {
        _memory = memory;
        _storage = storage;
        _cpu = cpu;
    }

    string IComputer.GetType()
    {
        return $"Server: MEMORY={_memory}, STORAGE={_storage}, CPU={_cpu}";
    }
}

public class Android : IComputer
{
    private int _memory;
    private int _cpu;
    private int _storage;

    public Android(int memory, int storage, int cpu)
    {
        _memory = memory;
        _storage = storage;
        _cpu = cpu;
    }

    string IComputer.GetType()
    {
        return $"Android: MEMORY={_memory}, STORAGE={_storage}, CPU={_cpu}";
    }
}

public class ComputerFactory
{
    public static IComputer CreateComputer(string type, int memory, int storage, int cpu)
    {
        if (type == "Desktop") return new Desktop(memory, storage, cpu);
        else if (type == "Laptop") return new Laptop(memory, storage, cpu);
        else if (type == "Server") return new Server(memory, storage, cpu);
        else if (type == "Android") return new Android(memory, storage, cpu);
        else return null;
    }
}