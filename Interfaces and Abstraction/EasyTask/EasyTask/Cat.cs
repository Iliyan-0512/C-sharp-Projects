using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTask
{
    public class Cat:IPet
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
        public void Play()
        {
            Console.WriteLine("Cat is playing with a toy mouse.");
        }
    }
}
