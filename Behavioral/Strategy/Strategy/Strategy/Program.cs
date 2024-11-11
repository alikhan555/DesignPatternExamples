SortContext sortContext = new(new SelectionSortStrategy());
sortContext.Sort();
Console.WriteLine("");

sortContext.SetStrategy(new InsertionSortStrategy());
sortContext.Sort();
Console.WriteLine("");

sortContext.SetStrategy(new BubbleSortStrategy());
sortContext.Sort();
Console.WriteLine("");


public class SortContext
{
    private ISortStrategy _strategy;

    public SortContext(ISortStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(ISortStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Sort()
    {
        Console.WriteLine("Pre Process");
        _strategy.Sort();
        Console.WriteLine("Post Process");
    }
}

public interface ISortStrategy
{
    void Sort();
}

public class SelectionSortStrategy : ISortStrategy
{
    void ISortStrategy.Sort()
    {
        Console.WriteLine("Selection Sort");
    }
}

public class InsertionSortStrategy : ISortStrategy
{
    void ISortStrategy.Sort()
    {
        Console.WriteLine("Insertion Sort");
    }
}

public class BubbleSortStrategy : ISortStrategy
{
    void ISortStrategy.Sort()
    {
        Console.WriteLine("Bubble Sort");
    }
}