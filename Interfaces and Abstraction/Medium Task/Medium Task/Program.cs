using Medium_Task;
using System;

namespace Medium_Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            PaypalPayment paypalPayment = new PaypalPayment();
            CreditCardPayment creditCardPayment = new CreditCardPayment();
            BitcoinPayment bitcoinPayment = new BitcoinPayment();
            List <IPaymentMethod> payment=new List<IPaymentMethod>
            {paypalPayment, creditCardPayment,bitcoinPayment};
            foreach (IPaymentMethod paymentMethod in payment)
            {
                paymentMethod.ProcessPayment(100);
            }
               
               

        }
    }
}