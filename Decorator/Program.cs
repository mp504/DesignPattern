// Client Code
using Decorator;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a plain pizza
        Pizza pizza = new PlainPizza();
        Console.WriteLine($"{pizza.GetDescription()} - Cost: ${pizza.GetCost()}");

        // Add cheese
        pizza = new CheeseDecorator(pizza);
        Console.WriteLine($"{pizza.GetDescription()} - Cost: ${pizza.GetCost()}");

        // Add pepperoni
        pizza = new PepperoniDecorator(pizza);
        Console.WriteLine($"{pizza.GetDescription()} - Cost: ${pizza.GetCost()}");

        
    }
}