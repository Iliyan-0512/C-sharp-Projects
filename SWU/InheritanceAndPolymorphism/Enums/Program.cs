//namespace Enums
//{
//    class Program

//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine((int)Color.Yellow);
//            Console.ReadKey();
//        }
//using System;
//namespace Enums
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine((byte)Color.Yellow);
//            Console.WriteLine((byte)Color.Blue);
//            Console.ReadLine();
//        }
//    }
//    enum Color : byte
//    {
//        Yellow,
//        Blue,
//        Brown,
//        Green
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Color.Yellow.CompareTo(Color.Blue));
        Console.WriteLine(Color.Blue.CompareTo(Color.Green));
        Console.WriteLine(Color.Blue.CompareTo(Color.Yellow));
        Console.WriteLine(Color.Green.CompareTo(Color.Green));
        Console.ReadLine();
        int myColor = 2;
        if (myColor == (int)Color.Green)
        {
            Console.WriteLine("my color");
        }
        Console.ReadLine();

        Console.WriteLine(Color.Format(typeof(Color), Color.Green, "X"));
        Console.WriteLine(Color.Format(typeof(Color), Color.Green, "d"));
        Console.ReadLine();
    }
}
//enum Color : byte
//{
//    Yellow,
//    Blue,
//    Brown,
//    Green
//}
//enum Shades : Color
//{
//}


