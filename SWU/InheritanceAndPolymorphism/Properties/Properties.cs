using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Properties
    {
        //public string Name { }
        //public string Name
        //{
        //    get
        //    {
        //        return "I am a Name property";
        //    }
        //}
        //public int Age
        //{
        //    get
        //    {
        //        DateTime dateOfBirth = new DateTime(1984, 01, 20);
        //        DateTime currentDate = DateTime.Now;
        //        int age = currentDate.Year - dateOfBirth.Year;
        //        return age;
        //    }
        //    set
        //    {
        //        Console.WriteLine("Set Age called " + value);
        //    }
        //}
        //private string name;
        //private int age;
        //public string Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        Console.WriteLine("Set Name called ");
        //        name = value;
        //    }
        //}
        //public int Age
        //{
        //    get { return age; }
        //    set
        //    {
        //        Console.WriteLine("Set Age called ");
        //        age = value;
        //    }
        //}
        //automatic prop
        //private string name;
        //private int age;
        //public string Name { get; set; }
        //public int Age { get; set; }
        //readOnly
        //private string name = "Akhil";
        //private int age = 32;
        //public string Name
        //{
        //    get { return name; }
        //}
        //public int Age { get { return age; } }
        //write-only


        //private string name;
        //private int age;
        //public string Name
        //{
        //    set { name = value; }
        //}
        //public int Age { set { age = value; } }


        //private string name;
        //public string name;
        //{
        //    set { name = value; }
        //    get { return name; }
        //}
        //public static int Age
        //{
        //    set
        //    {
        //        Console.WriteLine("In set static property; value is " + value);
        //    }
        //    get
        //    {
        //        Console.WriteLine("In get static property");
        //        return 10;
        //    }
        //}
        public abstract class BaseClass
        {
            public abstract int AbsProperty { get; set; }
        }
        public class Properties1 : BaseClass
        {
            public override int AbsProperty
            {
                get
                {
                    Console.WriteLine("Get called");
                    return 10;
                }
                set { Console.WriteLine("set called,value is " + value); }
            }






        }


    }
}
    
