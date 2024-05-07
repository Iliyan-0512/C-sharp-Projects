//using System;
//using System.IO;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace MyApp // Note: actual namespace depends on the project name.
//{
//    internal class Casino
//    {
//        static void Main(string[] args)
//        {
//            double odds = .75;
//            Random random = new Random();
//            Guy player = new Guy() { Cash = 100, Name = "The player" };
//            Console.WriteLine("Welcome to the casino. The odds are " + odds);
//            while (player.Cash > 0)
//            {
//                player.WriteMyInfo();
//                Console.Write("How much do you want to bet: ");
//                string howMuch = Console.ReadLine();
//                if (int.TryParse(howMuch, out int amount))
//                {
//                    int pot = player.GiveCash(amount) * 2;
//                    if (pot > 0)
//                    {
//                        if (random.NextDouble() > odds)
//                        {
//                            int winnings = pot;
//                            Console.WriteLine("You win " + winnings);
//                            player.ReceiveCash(winnings);
//                        }
//                        else
//                        {
//                            Console.WriteLine("Bad luck, you lose.");
//                        }
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Please enter a valid number.");
//                }
//            }
//            Console.WriteLine("The house always wins.");
//        }
//    }
//    class Guy
//    {
//        public string Name;
//        public int Cash;
//        /// <summary>
//        /// Writes my name and the amount of cash I have to the console.
//        /// </summary>
//        public void WriteMyInfo()
//        {
//            Console.WriteLine(Name + " has " + Cash + " bucks.");
//        }
//        /// <summary>
//        /// Gives some of my cash, removing it from my wallet (or printing
//        /// a message to the console if I don't have enough cash).
//        /// </summary>
//        /// <param name="amount">Amount of cash to give.</param>
//        /// <returns>
//        /// The amount of cash removed from my wallet, or 0 if I don't
//        /// have enough cash (or if the amount is invalid).
//        /// </returns>
//        public int GiveCash(int amount)
//        {
//            if (amount <= 0)
//            {
//                Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
//                return 0;
//            }
//            if (amount > Cash)
//            {
//                Console.WriteLine(Name + " says: " +
//                "I don't have enough cash to give you " + amount);
//                return 0;
//            }
//            Cash -= amount;
//            return amount;
//        }
//        /// <summary>
//        /// Receive some cash, adding it to my wallet (or printing
//        /// a message to the console if the amount is invalid).
//        /// </summary>
//        /// <param name="amount">Amount of cash to give.</param>
//        public void ReceiveCash(int amount)
//        {
//            if (amount <= 0)
//            {
//                Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
//            }
//            else
//            {
//                Cash += amount;
//            }
//        }
//    }
//}using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpenYourPencil_2
{
    class Pizzazz
    {
        public int Zippo;

        public void Bamboo(int eek)
        {
            Zippo += eek;
        }
    }
    class Abracadabra
    {
        public int Vavavoom;
        public bool Lala(int floq)
        {
            if (floq < Vavavoom)
            {
                Vavavoom += floq;
                return true;
            }
            return false;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Pizzazz foxtrot = new Pizzazz() { Zippo = 2 };
            foxtrot.Bamboo(foxtrot.Zippo);
            Pizzazz november = new Pizzazz() { Zippo = 3 };
            Abracadabra tango = new Abracadabra() { Vavavoom = 4 };
            while (tango.Lala(november.Zippo))
            {
                november.Zippo *= -1;
                november.Bamboo(tango.Vavavoom);
                foxtrot.Bamboo(november.Zippo);
                tango.Vavavoom -= foxtrot.Zippo;
            }
            Console.WriteLine("november.Zippo = " + november.Zippo);
            Console.WriteLine("foxtrot.Zippo = " + foxtrot.Zippo);
            Console.WriteLine("tango.Vavavoom = " + tango.Vavavoom);
        }
    }






}

