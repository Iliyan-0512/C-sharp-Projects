using Run_Time_Polymorphism_;

public class ClassC : ClassB
{
    public override void XXX()
    {
        Console.WriteLine("ClassC XXX");
    }
}

//public class ClassC : ClassA
//{
//    public override void AAA()
//    {
//        Console.WriteLine("ClassC AAA");
//    }
//    public override void CCC()
//    {
//        Console.WriteLine("ClassC CCC");
//    }
//}