internal class Program
{
    private static void Main(string[] args)
    {
        double computerRezult = 0;
        double playerRezult = 0;
        int player = 0;
        double temp1 = 0;
        double temp2 = 0;
        int count = 0;

        Random random = new Random();
        int computer = random.Next(1, 4);
        Console.WriteLine(computer);

        Console.WriteLine("Enter 1,2,3-rock,schere,paper");

        while (count < 10)
        {
            while (!int.TryParse(Console.ReadLine(), out player) || player < 1 || player > 3)
            {
                Console.WriteLine(" Enter a number between 1 and 3:");
            }
            Console.WriteLine(computer);

            if (player == 1 && computer == 1)
            {
                computerRezult += 0;
                playerRezult += 0;
                Console.WriteLine("Draw");
            }
            else if (player == 1 && computer == 2)
            {
                playerRezult += 3;
                Console.WriteLine("PlayerWin");
            }
            else if (player == 1 && computer == 3)
            {
                computerRezult += 7;
                Console.WriteLine("ComputerWin");
            }
            else if (player == 2 && computer == 1)
            {
                computerRezult += 3;
                Console.WriteLine("ComputerWin");
            }
            else if (player == 2 && computer == 2)
            {
                computerRezult += 0;
                playerRezult += 0;
                Console.WriteLine("Draw");
            }
            else if (player == 2 && computer == 3)
            {
                playerRezult += 5;
                Console.WriteLine("PlayerWin");
            }
            else if (player == 3 && computer == 1)
            {
                playerRezult += 7;
                Console.WriteLine("PlayerWin");
            }
            else if (player == 3 && computer == 2)
            {
                computerRezult += 5;
                Console.WriteLine("ComputerWin");
            }
            else if (player == 3 && computer == 3)
            {
                computerRezult += 0;
                playerRezult += 0;
                Console.WriteLine("Draw");
            }
            count++;
            double totalPont = playerRezult + computerRezult;
            double procentRezultPlayer = (playerRezult / totalPont) * 100;
            double procentRezultComputer = (computerRezult / totalPont) * 100;
            int bonus = 10;
            if (count == 10)
            {
                if (playerRezult > 65)
                {
                    Console.WriteLine("You have 5% bonus");
                    playerRezult = playerRezult *  1.05;
                }
                else if (computerRezult > 65)
                {
                    Console.WriteLine("You have 5% bonus");
                    computerRezult = computerRezult * 1.05;
                }

            }
            Console.WriteLine($"Rezult in the moment Player:{procentRezultPlayer:F2}% " +
                 $" Computer:{procentRezultComputer:F2}%");

            Console.WriteLine($"Point player:{playerRezult} ");
            Console.WriteLine($"Point computer:{computerRezult} ");
            Console.WriteLine("Enter 1,2,3-rock,schere,paper");

            computer = random.Next(1, 4);
            Console.WriteLine(computer);
            temp1 = procentRezultComputer;
            temp2 = procentRezultPlayer;
        }

        if (playerRezult > computerRezult)
        {
            Console.WriteLine($"Player winner: {temp2:F2}");
        }
        else if (playerRezult < computerRezult)
        {
            Console.WriteLine($"Computer winner: {temp1:F2}");
        }
        else
        {
            Console.WriteLine($"Draw: {temp2:F2}:{temp1:F2}");
        }
    }
}