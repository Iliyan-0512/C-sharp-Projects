using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExsEns
{
    internal class Laptop
    {
        public string Brand {  get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string DiskType { get; set; }
        public double Price { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("The laptop is on");
        }
        public void TurnOff()
        {
            Console.WriteLine("The laptop is off");
        }
        public void StartUsinProgram(string ProgramName)
        {
            Console.WriteLine($"The proggram is {ProgramName}");
        }
        public void Browse(string address)
        {
            Console.WriteLine($"The address is {address}");
        }
        public override string ToString()
        {
            return $"{Brand},{CPU},{GPU},{RAM},{DiskType},{Price}";
        }



    }
}
