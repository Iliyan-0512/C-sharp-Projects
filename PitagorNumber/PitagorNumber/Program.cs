internal class Program
{
    private static void Main(string[] args)
    {
        //a*a+b*b=c*c
        for (int i = 1; i < 100; i++)
        {
            for (int j = 1; j < 100; j++)
            {

                for (int k = 1; k < 100; k++)
                {
                    if (i * i + j * j == k * k)
                    {
                        Console.WriteLine($"Pytogore number:{i} {j} {k}");
                    }
                }
            }
        }
        var pitagorean = from a in Enumerable.Range(0, 100)
                         from b in Enumerable.Range(0, 100)
                         from c in Enumerable.Range(0, 100)
                         where a * a + b * b == c * c
                         select (a, b, c);
        pitagorean.ToList().ForEach(x => Console.WriteLine($"{x.a},{x.b}, {x.c}"));
                         

    }
}
