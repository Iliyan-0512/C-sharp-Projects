class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<BaseHero> raidGroup = new List<BaseHero>();

        while (raidGroup.Count < n)
        {
            string heroName = Console.ReadLine();
            string heroType = Console.ReadLine();

            BaseHero hero = HeroFactory.CreateHero(heroName, heroType);
            if (hero != null)
            {
                raidGroup.Add(hero);
            }
            else
            {
                Console.WriteLine("Invalid hero!");
            }
        }

        int bossPower = int.Parse(Console.ReadLine());
        int totalPower = 0;

        foreach (var hero in raidGroup)
        {
            Console.WriteLine(hero.CastAbility());
            totalPower += hero.Power;
        }

        if (totalPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}