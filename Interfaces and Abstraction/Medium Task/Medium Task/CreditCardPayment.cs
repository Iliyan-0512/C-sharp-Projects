using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_Task
{
    public class CreditCardPayment:IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}.");
        }
         public string  GetPaymentDetails()
        {
            return ("Credit Card");
        }
    }
}
