internal class Program
{
   

    private static void Main(string[] args)
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());

        Console.WriteLine("Which Number is");
        Console.WriteLine("Enter Nuber");
        int randomNumber = random.Next(1,21);

        Console.WriteLine (randomNumber.ToString());


        int myNumber = int.Parse(Console.ReadLine());
        int trySample = 5;
        for (int i = 1; i < trySample; i++)
        {
            if (myNumber == randomNumber)
            {
                Console.WriteLine("Nice");
                return;
            }
            else
            {
                if (myNumber > randomNumber)
                {
                    Console.WriteLine("NO,number is less");
                }
                else
                {
                    Console.WriteLine("NO,number is more bigger");
                }
                myNumber =int.Parse( Console.ReadLine());
            }
        }
        Console.WriteLine("You lose");
    }
}