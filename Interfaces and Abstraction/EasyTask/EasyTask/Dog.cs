using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTask
{
    public class Dog:IPet
    {
       public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
        public void Play()
        {
            Console.WriteLine("Dog is playing with a ball.");
        }
    }
}
