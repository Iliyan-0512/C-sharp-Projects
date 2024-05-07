
using System;

namespace _7._Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameAndAddress = Console.ReadLine().Split();
            string fullName = nameAndAddress[0] + " "+ nameAndAddress[1];
            string address = nameAndAddress[2];
            MyTuple<string, string> firstTuple = new MyTuple<string, string>(fullName, address);

            string[] personalAndBeer = Console.ReadLine().Split();
            string personal = personalAndBeer[0];
            int beer = int.Parse(personalAndBeer[1]);
            MyTuple<string, int> secoundTuple = new MyTuple<string, int>(personal, beer);
            



            string[] IntAndDouble = Console.ReadLine().Split();
            int intNumber= int.Parse(IntAndDouble[0]);
            double doubleNumber = double.Parse(IntAndDouble[1]);
            MyTuple<int, double> thirdTuple = new MyTuple<int, double>(intNumber, doubleNumber);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secoundTuple);
            Console.WriteLine(thirdTuple);

            
        }
    }
}