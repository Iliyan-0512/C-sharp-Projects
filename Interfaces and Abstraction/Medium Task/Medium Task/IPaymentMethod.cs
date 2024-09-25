using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_Task
{
    public interface IPaymentMethod
    {
        public void ProcessPayment(decimal amount);
        public string GetPaymentDetails();
    }
}
