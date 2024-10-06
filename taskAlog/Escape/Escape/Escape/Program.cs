using System;

class Program
{
    static void Main()
    {
        // Четене на дължината на коридора
        int N = int.Parse(Console.ReadLine());
        // Четене на коридора
        string corridor = Console.ReadLine();

        // Намиране на позицията на Ели
        int ellPosition = corridor.IndexOf('E');

        // Изчисляване на минималния брой препятствия наляво и надясно
        int obstaclesToDestroyLeft = CountObstacles(corridor, ellPosition - 1, -1);
        int obstaclesToDestroyRight = CountObstacles(corridor, ellPosition + 1, 1);

        // Минимален брой препятствия
        int minObstacles = Math.Min(obstaclesToDestroyLeft, obstaclesToDestroyRight);

        // Отпечатване на резултата
        Console.WriteLine(minObstacles);
    }

    // Функция за броене на препятствия
    static int CountObstacles(string corridor, int startIndex, int direction)
    {
        int count = 0;
        // Итерираме в посоката на движение
        while (startIndex >= 0 && startIndex < corridor.Length)
        {
            if (corridor[startIndex] == '#')
            {
                count++;
            }
            // Спираме при открито пространство
            if (corridor[startIndex] == '.')
            {
                break; // Спираме, когато намерим свободно пространство
            }
            // Преместваме се в посоката
            startIndex += direction;
        }
        return count;
    }
}
