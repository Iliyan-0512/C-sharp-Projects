//public class Overload
//{
//    public static void Display(params object[] objectParamArray)
//    {
//        foreach (object obj in objectParamArray)
//        {
//            Console.Write(obj.GetType().FullName + " ");
//        }
//        Console.WriteLine();
//    }
//}
//public class Overload
//{
//    public void Display()
//    {
//        DisplayOverload(200);
//        DisplayOverload(200, 300);
//        DisplayOverload(200, 300, 500, 600);
//    }
//    private void DisplayOverload(int x, int y)
//    {
//        Console.WriteLine("The two integers " + x + " " + y);
//    }
//    private void DisplayOverload(params int[] parameterArray)
//    {
//        Console.WriteLine("parameterArray");
//    }
//}

//public class Overload
//{
//    public void Display()
//    {
//        int number = 102;
//        DisplayOverload(200, 1000, number, 200);
//        Console.WriteLine(number);
//    }
//    private void DisplayOverload(int a, params int[] parameterArray)
//    {
//        parameterArray[1] = 3000;
//    }
//}

//public class Overload
//{
//    public void Display()
//    {
//        string[] names = { "Akhil", "Ekta", "Arsh","You"};



//    DisplayOverload(5, names);
//    }
//    private void DisplayOverload(int a, params string[] parameterArray)
//    {
//        foreach (var s in parameterArray)
//            Console.WriteLine(s + " " + a);
//    }
//}
//public class Overload
//{
//    public void Display()
//    {
//        DisplayOverload(100, 200, 300);
//        DisplayOverload(200, 100,123,124,1242,1412,12421,412);
//        DisplayOverload(200);
//    }
//    private void DisplayOverload(int a, params int[] parameterArray)
//    {
//        foreach (var i in parameterArray)
//            Console.WriteLine(i + " " + a);
//    }
//}

//public class Overload
//{
//    public void Display()
//    {
//        string[] names = { "Akhil", "Ekta", "Arsh" };


//    DisplayOverload(3, names);
//    }
//    private void DisplayOverload(int a, params string[] parameterArray)
//    {
//        foreach (var s in parameterArray)
//            Console.WriteLine(s + " " + a);
//    }
//}
public class Overload
{
    public static void Display(params object[] objectParamArray)
    {
        Console.WriteLine(objectParamArray.GetType().FullName);
        Console.WriteLine(objectParamArray.Length);
        Console.WriteLine(objectParamArray[0]);
    }
}

