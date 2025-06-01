//class Program
//{
//    static void Main(string[] args)
//    {
//        Overload overload = new Overload();
//        overload.Display();
//        Console.ReadKey();
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        object[] objArray = { 100, "Akhil", 200.300 };

//    object obj = objArray;
//        Overload.Display(objArray);
//        Overload.Display((object)objArray);
//        Overload.Display(obj);
//        Overload.Display((object[])obj);
//        Console.ReadKey();
//    }
//}
class Program
{
    static void Main(string[] args)
    {
        object[] objArray = { 100, "Akhil", 200.300 };
        Overload.Display((object)objArray);
        Console.ReadKey();
    }
}
