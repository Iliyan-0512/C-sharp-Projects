using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run_Time_Polymorphism_
{
    public class ClassA
    {
        public virtual void XXX()
        {
            Console.WriteLine("ClassA XXX");
        }
    }

    //public class ClassA : ClassB
    //{
    //    public override void AAA()
    //    {
    //        Console.WriteLine("ClassA AAA");
    //    }
    //    public new void BBB()
    //    {
    //        Console.WriteLine("ClassA BBB");
    //    }
    //    public void CCC()
    //    {
    //        Console.WriteLine("ClassA CCC");
    //    }
    //}

}
