using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var fruits=new Dictionary<string, double>();
            //fruits["banana"]= 2.20;
            //fruits["apple"] = 1.40;
            //fruits["kiwi"] = 3.20;
            //foreach(var fruit in fruits)
            //{
            //    Console.WriteLine($"{fruit}");

            //
            //var phonenumber = new Dictionary<string, string>();
            //phonenumber["Peter"] = "359 882";

            //Dictionary<string, int> frut = new()
            //{
            //{ "Kiwi", 3 },
            //{"Apple",5 }
            //   };
            //var airplanes = new Dictionary<string, int>();
            //airplanes.Add("Boeing 737",130);
            //airplanes.Add("Airbus A320", 150);
            //airplanes.Remove("Airbus A320");
            //var dictnary=new Dictionary<string, int>();
            //dictnary.Add("Airbus A320", 150);
            //if (dictnary.ContainsKey("Airbus A320"))
            //{
            //    Console.WriteLine($"Airbus A320 key exists");
            //}

            //var dictionary = new Dictionary<string, int>();
            //dictionary.Add("Airbus A320", 150);
            //Console.WriteLine(dictionary.ContainsValue(150)); // True
            //Console.WriteLine(dictionary.ContainsValue(100)); // False

            //var fruits = new Dictionary<string, double>();
            //fruits.Add("banana", 2.20);
            //fruits.Add("kiwi", 4.50);
            //foreach (var fruit in fruits)
            //{
            //    Console.WriteLine($"{fruit.Key} -> {fruit.Value}");
            //}
            //var fruits=new Dictionary<double, string>();
            //fruits.Add(2,"eggs");
            //fruits.Add(6, "apple");
            //foreach(var smt in fruits)
            //{
            //    Console.WriteLine($"{smt.Key}-> {smt.Value}");
            //}

            //new List<int>() { 1, 2, 3, 4, -1, -5, 0, 50 }.Min();
            //Console.WriteLine();
            string[] words = Console.ReadLine()
.Split()
.Where(w => w.Length % 2 == 0)
.ToArray();
            foreach (string word in words)
                Console.WriteLine(word);

        }
    }
}
