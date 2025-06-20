using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using static Properties.Properties;
namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {

            Properties1 prop = new Properties1();
            prop.AbsProperty = 40;
            Console.WriteLine(prop.AbsProperty);
            Console.ReadLine();

        }
    }
}