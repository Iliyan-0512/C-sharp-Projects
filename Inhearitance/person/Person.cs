using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private int Age;
        private string Name;
        public Person(int age,string name) 
        {
            this.Age = age;
            this.Name = name;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}",this.Name,this.Age));
            return sb.ToString() ;
               

        }


    }
}
