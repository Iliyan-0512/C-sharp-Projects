using System;

namespace MyApp
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Humphrey", EarSize = 45 };
            Elephant biggestEars = elephants[0];
            for (int i = 1; i < elephants.Length; i++)
            {
                Console.WriteLine("Iteration #" + i);
                if (elephants[i].EarSize > biggestEars.EarSize)
                {
                    biggestEars = elephants[i];
                }
                Console.WriteLine(biggestEars.EarSize.ToString());
            }
        }
        //{
        //    if (0.1 + 0.2 == 0.3) Console.WriteLine("They're equal");
        //    else Console.WriteLine("They aren't equal");

        //    if (0.1M + 0.2M == 0.3M) Console.WriteLine("They're equal");
        //    else Console.WriteLine("They aren't equal");
        //float myFloatValue = 10;
        ////int myIntValue = myFloatValue;
        //int myIntValue = (int)myFloatValue;
        //Console.WriteLine("myIntValue is " + myIntValue);
        //int myInt = 36;
        //float myFloat = 16.4F;
        //myFloat = myInt + myFloat;
        //Console.WriteLine(myFloat);

        //   int myInt = 10;
        //   byte myByte = (byte)myInt;
        //   double myDouble = (double)myByte;

        //   string myString = "false";
        //   ;
        //   myString = myInt.ToString();

        //   short myShort = (short)myInt;
        //   char myChar = 'x';
        //;
        //   long myLong = (long)myInt;
        //   decimal myDecimal = (decimal)myLong;
        //   myString = myString + myInt +
        //   myByte + myDouble + myChar;
        Console.ReadKey();

        }
    //public int MyMethod(bool add3)
    //{
    //    int value = 12;
    //    if (add3)
    //        value += 3;
    //    else
    //        value -= 2;
    //    return value;
    //}



}

}