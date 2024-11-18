
WeatherStation weatherStation = new WeatherStation();

IObserver mobile = new MobileDisplay();
IObserver tv = new TVDisplay();

weatherStation.AddObserver(mobile);
weatherStation.AddObserver(tv);

weatherStation.SetTemperature(27);

Console.WriteLine("END");


public interface IObserver
{
    void Update(string message);
}

public interface ISubject
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void Notify();
}

public class WeatherStation : ISubject
{
    private readonly List<IObserver> observers = new List<IObserver>();
    int temperature = 0;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(temperature.ToString());
        }
    }

    public void SetTemperature(int temperature)
    {
        this.temperature = temperature;
        Notify();
    }
}

public class MobileDisplay : IObserver
{
    string temperature = string.Empty;

    public void Update(string message)
    {
        temperature = message;
        DisplayTemperature();
    }

    public void DisplayTemperature()
    {
        Console.WriteLine($"Temperature on Android: {temperature}");
    }
}

public class TVDisplay : IObserver
{
    string temperature = string.Empty;

    public void Update(string message)
    {
        temperature = message;
        DisplayTemperature();
    }

    public void DisplayTemperature()
    {
        Console.WriteLine($"Temperature on TV: {temperature}");
    }
}