using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    public interface IStockSubject
    {
        void Attach(IStockObserver observer);
        void Detach(IStockObserver observer);
        void Notify();
    }

    public interface IStockObserver
    {
        void Update (string stockName, decimal price);
    }
    public class Stock: IStockSubject
    {
        private readonly List<IStockObserver> _observers = new List<IStockObserver>();
        private string _name;
        private decimal _price;

        public Stock(string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public string Name => _name;

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public void Attach(IStockObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IStockObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_name, _price);
            }
        }


    }

    public class Investor : IStockObserver
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(string stockName, decimal price)
        {
            Console.WriteLine($"Investor {_name} notified: {stockName} new price is {price:C}");
        }
    }




}
