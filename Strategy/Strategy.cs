using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount) 
        {
            Console.WriteLine($"Paying{amount} Using credit card.");
        }
    }


    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} Using Paypal");
        }
    }

    public class STCPayPayment: IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} Using STCPay");
        }
    } 


    public class ShoppingCart
    {
        private readonly List<Item> _items = new List<Item> ();
        private  IPaymentStrategy _strategy;



        public void Add(Item item)
        {
            _items.Add (item);
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;

        }

        public void Checkout()
        {
            decimal totalAmount = _items.Sum(item => item.Price);
            _strategy.Pay(totalAmount);
        }
      
    }



    public class Item
    {
        public string Name { get; }
        public decimal Price { get; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }



}
