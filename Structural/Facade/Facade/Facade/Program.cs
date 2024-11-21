
WaiterFacade waiter = new WaiterFacade();

waiter.OrderChickenBurger();
waiter.OrderBeefBurger();
waiter.OrderZingerBurger();

waiter.OrderCheezSandwich();
waiter.OrderClubSandwich();
waiter.OrderZingerSandwich();

waiter.OrderChickenPizza();
waiter.OrderPanPizza();
waiter.OrderSpicyPizza();


public interface IBurgerShop
{
    void PrepareChickenBurger();
    void PrepareBeefBurger();
    void PrepareZingerBurger();
}

public interface ISandwichShop
{
    void PrepareCheezSandwich();
    void PrepareClubSandwich();
    void PrepareZingerSandwich();
}

public interface IPizzaShop
{
    void PreparePanPizza();
    void PrepareChickenPizza();
    void PrepareSpicyPizza();
}

public class BurgerShop1 : IBurgerShop
{
    public void PrepareBeefBurger()
    {
        Console.WriteLine("Beef Burger");
    }

    public void PrepareChickenBurger()
    {
        Console.WriteLine("Chicken Burger");
    }

    public void PrepareZingerBurger()
    {
        Console.WriteLine("Zinger Burger");
    }
}

public class SandwichShop1 : ISandwichShop
{
    public void PrepareCheezSandwich()
    {
        Console.WriteLine("Cheez Sandwich");
    }

    public void PrepareClubSandwich()
    {
        Console.WriteLine("Club Sandwich");
    }

    public void PrepareZingerSandwich()
    {
        Console.WriteLine("Zinger Sandwich");
    }
}

public class PizzaShop1 : IPizzaShop
{
    public void PrepareChickenPizza()
    {
        Console.WriteLine("Chicken Pizza");
    }

    public void PreparePanPizza()
    {
        Console.WriteLine("Pan Pizza");
    }

    public void PrepareSpicyPizza()
    {
        Console.WriteLine("Spicy Pizza");
    }
}

public class WaiterFacade
{
    private readonly IBurgerShop _burgerShop;
    private readonly ISandwichShop _sandwichShop;
    private readonly IPizzaShop _pizzaShop;

    public WaiterFacade()
    {
        _burgerShop = new BurgerShop1();
        _sandwichShop = new SandwichShop1();
        _pizzaShop = new PizzaShop1();
    }

    public void OrderBeefBurger()
    {
        _burgerShop.PrepareBeefBurger();
    }

    public void OrderChickenBurger()
    {
        _burgerShop.PrepareChickenBurger();
    }

    public void OrderZingerBurger()
    {
        _burgerShop.PrepareZingerBurger();
    }

    public void OrderCheezSandwich()
    {
        _sandwichShop.PrepareCheezSandwich();
    }

    public void OrderClubSandwich()
    {
        _sandwichShop.PrepareClubSandwich();
    }

    public void OrderZingerSandwich()
    {
        _sandwichShop.PrepareZingerSandwich();
    }

    public void OrderChickenPizza()
    {
        _pizzaShop.PrepareChickenPizza();
    }

    public void OrderPanPizza()
    {
        _pizzaShop.PreparePanPizza();
    }

    public void OrderSpicyPizza()
    {
        _pizzaShop.PrepareSpicyPizza();
    }
}