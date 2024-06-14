using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla:ICar,IElectricCar

    {
       public string Model { get; private set; }
        public string Color { get; private set; }
        public int Battery { get; private set; }
        public Tesla (string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breeaak!";
        }
        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} Batteries\n{Start()}\n{Stop()}";
        }

    }
}
