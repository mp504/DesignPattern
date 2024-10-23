using Strategy;

class Program
{
    static void Main(string[] args)
    {
        var cart = new ShoppingCart();
        cart.Add(new Item("Book", 39.99m));
        cart.Add(new Item("Pen", 1.5m));

        // Choose payment method
        cart.SetPaymentStrategy(new CreditCardPayment());
        cart.Checkout();  // Output: Paying 41.49 using Credit Card.

        // Change payment method
        cart.SetPaymentStrategy(new PayPalPayment());
        cart.Checkout();  // Output: Paying 41.49 using PayPal.
    }
}