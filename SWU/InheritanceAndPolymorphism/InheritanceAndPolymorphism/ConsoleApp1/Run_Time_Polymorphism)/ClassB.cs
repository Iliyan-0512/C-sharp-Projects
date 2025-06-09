using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Time_Polymorphism_
{
    public class ClassB : ClassA
    {
        public override void XXX()
        {
            ((ClassA)this).XXX();
            Console.WriteLine("ClassB XXX");
        }
    }

    //public class ClassB
    //{
    //    public virtual void AAA()
    //    {
    //        Console.WriteLine("ClassB AAA");
    //    }
    //    public virtual void BBB()
    //    {
    //        Console.WriteLine("ClassB BBB");
    //    }
    //    public virtual void CCC()
    //    {
    //        Console.WriteLine("ClassB CCC");
    //    }
    //}
}
