﻿internal class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        //Console.Write("Enter a number: ");
        //if (int.TryParse(Console.ReadLine(), out int input))
        //{
        //    var output1 = ReturnThreeValues(input, out double output2, out int output3);

        //    Console.WriteLine("Outputs: plus one = {0}, half = {1:F}, twice = {2}",
        //    output1, output2, output3);
        //}
        Console.WriteLine(SampleRef(ref a)); 
        
    }
    public static int ReturnThreeValues(int value, out double half, out int twice)
    {
        half = value / 2f;
        twice = value * 2;
        return value + 1;
    }
    public static int SampleRef(ref int value)
    {
        return value+3;
    }

}
