using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char[] ASCLL = Console.ReadLine().ToArray();

        // Намиране на позицията на Ели
        int ellPosition = -1;
        for (int i = 0; i < N; i++)
        {
            if (ASCLL[i] == 'E')
            {
                ellPosition = i; // Запомни позицията на Ели
                break;
            }
        }

        // Изчисляване на минималния брой препятствия
        int obstaclesToDestroyLeft = 0;
        int obstaclesToDestroyRight = 0;

        // Проверка наляво от Ели
        for (int i = ellPosition - 1; i >= 0; i--)
        {
            if (ASCLL[i] == '#')
            {
                obstaclesToDestroyLeft++;
            }
            // Стоп при среща на отворено пространство
            if (ASCLL[i] == '.')
            {
                continue; // Продължавай да проверяваш
            }
            // Стоп при достигане на края на коридора
            break;
        }

        // Проверка надясно от Ели
        for (int i = ellPosition + 1; i < N; i++)
        {
            if (ASCLL[i] == '#')
            {
                obstaclesToDestroyRight++;
            }
            // Стоп при среща на отворено пространство
            if (ASCLL[i] == '.')
            {
                continue; // Продължавай да проверяваш
            }
            // Стоп при достигане на края на коридора
            break;
        }

        // Минимален брой препятствия
        int obstaclesToDestroy = Math.Min(obstaclesToDestroyLeft, obstaclesToDestroyRight);

        Console.WriteLine(obstaclesToDestroy);
    }
}
