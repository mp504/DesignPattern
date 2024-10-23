using Observer;

class Program
{
    static void Main(string[] args)
    {
        // Create a stock
        Stock appleStock = new Stock("Apple", 150.00m);

        // Create investors
        Investor investor1 = new Investor("Alice");
        Investor investor2 = new Investor("Bob");

        // Attach investors to the stock
        appleStock.Attach(investor1);
        appleStock.Attach(investor2);

        // Change the stock price
        appleStock.Price = 155.00m; // Notifies all investors
        appleStock.Price = 160.00m; // Notifies all investors

        // Detach one investor
        appleStock.Detach(investor1);

        // Change the stock price again
        appleStock.Price = 165.00m; // Notifies only Bob
    }
}
