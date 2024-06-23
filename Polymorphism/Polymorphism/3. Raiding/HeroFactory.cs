static class HeroFactory
{
    public static BaseHero CreateHero(string name, string type)
    {
        switch (type.ToLower())
        {
            case "druid":
                return new Druid(name);
            case "paladin":
                return new Paladin(name);
            case "rogue":
                return new Rogue(name);
            case "warrior":
                return new Warrior(name);
            default:
                return null;
        }
    }
}