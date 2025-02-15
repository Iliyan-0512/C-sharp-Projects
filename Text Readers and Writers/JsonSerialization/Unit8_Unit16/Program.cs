using System;
using System.Text;
using System.Text.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("eureka.txt", "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            foreach (byte b in eurekaBytes)
                Console.Write("{0} ", b);
            Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));
            Console.WriteLine(Path.GetFullPath("eureka.txt"));
            Console.WriteLine(JsonSerializer.Serialize("ש"));

        }
    }
}