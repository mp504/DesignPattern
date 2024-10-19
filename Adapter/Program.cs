
namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Paypal paypal = new Paypal();
            Mada mada = new Mada();

            PaypalAdapter paypalProcess = new PaypalAdapter(paypal);
            MadaAdapter madaProcess = new MadaAdapter(mada);

            paypalProcess.ProcessPayment(99);
            madaProcess.ProcessPayment(150);
        }

    }
}