using System.Runtime.InteropServices;
using AbstractClass;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassA classA = new ClassC();
        ClassB classB = new ClassC();
        classA.XXX(); 
        classB.XXX();
    }
}
