using System;
using System.Security.Cryptography.X509Certificates;

namespace GenericDemo
{
    public static  class ArrayCreator
    {
        static void Main(string[] args)
        {
          DataStore<string> store=new DataStore<string>();
            store.Data = "Hello World";
            DataStore<int> store2 = new DataStore<int>();
            store2.Data = 100;
            Console.WriteLine(store);
            Console.WriteLine(store2);

            DataStore<string> cities= new DataStore<string>();
            cities.AddOrUpdate(0,"Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");
           
            

            DataStore<int> empIds=new DataStore<int>();
            empIds.AddOrUpdate(0,50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);
           
            Console.WriteLine(cities);
            Console.WriteLine(empIds);
            Console.ReadKey();
        }
    }
}
