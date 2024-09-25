using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_Task
{
    public class PaypalPayment:IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of { amount}.");
        }
        public string GetPaymentDetails()
        {
            return "PayPal";
        }
    }
}
