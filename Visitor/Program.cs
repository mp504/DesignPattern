using Visitor;

class Program
{
    static void Main()
    {
        var items = new List<IShoppingCartItem>
        {
            new Book(20.00m),
            new Electronics(100.00m),
            new Clothing(50.00m)
        };

        var visitor = new ShoppingCartVisitor();

        foreach (var item in items)
        {
            item.Accept(visitor);
        }

        Console.WriteLine($"Total Price: {visitor.TotalPrice}");
    }
}
