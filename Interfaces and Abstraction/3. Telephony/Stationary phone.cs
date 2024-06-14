using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class StationaryPhone:ICallable
    {
        public void Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                if (number.Length == 7)
                {
                    Console.WriteLine($"Dialing... {number}");
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

