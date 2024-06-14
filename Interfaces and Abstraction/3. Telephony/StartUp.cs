using System;

namespace Phone
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine().Split(" ");
            string[] website = Console.ReadLine().Split(" ");
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            foreach (string number in phoneNumber)
            {
                if(number.Length==10)
                {
                    smartphone.Call(number);
                }
                else if(number.Length==7)
                {
                    stationaryPhone.Call(number);

                }
                else
                {
                    Console.WriteLine("Invalid number");
                }
                foreach(string url in website)
                {
                    smartphone.Browse(url);
                }
            }

        }
    }
}
