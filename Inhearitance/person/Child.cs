using Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child:Person
    {
        public Child(int age,string name)
            : base(age,name)
        {
           if(age == 0)
            {
                return;
            }
           else if(age >15)
            {
                return ;
            }
        }
        

    }
}
