﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animals
    {
       
        public string Name
        {
            get;
            protected set;
        }
        public string FavorString
        {
            get; protected set;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my  favourite food is {this.FavorString}";
        }
        public Animals(string name, string favourString)
        {
            this.Name= name ;
            this.FavorString = favourString ;
        }

    }
}
