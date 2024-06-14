
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Smartphone : ICallable,IBrowsable
    {
        public void Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                if (number.Length == 10)
                {
                    Console.WriteLine($"Calling...{number}");
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
        public void Browse(string url)
        {
            if(url.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {url}!");
            }
        }

    }
}
