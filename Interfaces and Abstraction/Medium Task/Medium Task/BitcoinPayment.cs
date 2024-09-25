using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_Task
{
    public class BitcoinPayment:IPaymentMethod

    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bitcoin payment of {amount}");
        }
        public string GetPaymentDetails()
        {
            return "Bitcoin";
        }
    }
}
