using _8._Threeuple;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameTowmAddress = Console.ReadLine().Split();
            string fullName = nameTowmAddress[0] + " "+ nameTowmAddress[1];
            
            string town = nameTowmAddress[2];
            string address = nameTowmAddress[3];
            Threeuple<string, string, string> tuple1 = new Threeuple<string, string, string>(fullName, town, address);

            string[] nameLitBeerDrunkOrNot = Console.ReadLine().Split();
            string name = nameLitBeerDrunkOrNot[0];
            int littrtBeer = int.Parse(nameLitBeerDrunkOrNot[1]);
            bool drunk;
            if ("drunk" == nameLitBeerDrunkOrNot[2])
            {
                drunk= true;
            }
            else
            {
                drunk= false;
            }
            Threeuple<string, int, bool> tuple2 = new Threeuple<string, int, bool>(name,littrtBeer,drunk);

            string[] nameAccBalanceBankName = Console.ReadLine().Split();
            string nameMan = nameAccBalanceBankName[0];
            float accBalanca = float.Parse(nameAccBalanceBankName[1]);
            string bankaName = nameAccBalanceBankName[2];
            Threeuple<string, float, string> threeTuple = new Threeuple<string, float, string>(nameMan,accBalanca,bankaName);
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(threeTuple);

        }
    }
}