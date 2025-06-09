using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class ClassB : ClassA
    {
        public new abstract void XXX();
    }
    //public class ClassC : ClassB
    //{
    //    public override void XXX()
    //    {
    //        System.Console.WriteLine("ClassC XXX");
    //    }
    //}
    public class ClassC : ClassB
    {
        public new void XXX()
        {
            System.Console.WriteLine("ClassC XXX");
        }
    }



}
