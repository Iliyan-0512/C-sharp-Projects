﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Dog:Animals
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }
}