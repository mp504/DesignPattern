using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    public interface IpaymentProcessor
    {
        public void ProcessPayment(decimal charge);
    }
    public class Paypal
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C} ");
        }

    }
    public class Mada
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C} ");
        }

    }


    public class PaypalAdapter: IpaymentProcessor
    {
        private readonly Paypal _paypal;

        public PaypalAdapter(Paypal paypal)
        {
            _paypal = paypal;
        }
        public void ProcessPayment(decimal amount)
        {
            _paypal.MakePayment(amount);
        }


    }

    public class MadaAdapter : IpaymentProcessor
    {
        private readonly Mada _mada;

        public MadaAdapter(Mada mada)
        {
            _mada = mada;
        }
        public void ProcessPayment(decimal amount)
        {
            _mada.MakePayment(amount);
        }
    }

}
