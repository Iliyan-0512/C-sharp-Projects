﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3tass
{
    class SafeOwner
    {
        private string valuables = "";
        public void ReceiveContents(string safeContents)
        {
            valuables = safeContents;
            Console.WriteLine($"Thank you for returning my {valuables}!");
        }
    }
}
