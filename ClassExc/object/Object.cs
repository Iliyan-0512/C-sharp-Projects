using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy Joe = new Guy();
            Joe.Name = "Joe";
            Joe.Cash = 50;

            Guy Bob=new Guy();
            Bob.Name = "Bob";
            Bob.Cash = 100;

            while (true)
            {
                Joe.WriteMyInfo();
                Bob.WriteMyInfo();
                Console.Write("Enter an amount: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                
                {
                    Console.Write("Who should give the cash: ");
                    string whichGuy = Console.ReadLine();

                    if (whichGuy == "Joe")
                    {
                        int cashGiven = Joe.GiveCash(amount);
                        Bob.ReceiveCash(cashGiven);
                    }
                    else if (whichGuy == "Bob")
                    {
                        int cashGiven=Bob.GiveCash(amount);
                        Joe.ReceiveCash(cashGiven);
                        
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }


                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
                Console.ReadKey();
            }
            

        }
        class Guy
        {
            public string Name;
            public int Cash;
            /// <summary>
            /// Writes my name and the amount of cash I have to the console.
            /// </summary>
            public void WriteMyInfo()
            {
                Console.WriteLine(Name + " has " + Cash + " bucks.");
            }
            
            public int GiveCash(int amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
                    return 0;
                }
                if (amount > Cash)
                {
                    Console.WriteLine(Name + " says: " +
                    "I don't have enough cash to give you " + amount);
                    return 0;
                }
                Cash -= amount;
                return amount;
            }
      
            public void ReceiveCash(int amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
                }
                else
                {
                    Cash += amount;
                }
            }
        }
    }
}
