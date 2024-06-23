class Druid : BaseHero
{
    public Druid(string name) : base(name, 80) { }

    public override string CastAbility()
    {
        return $"Druid - {Name} healed for {Power}";
    }
}

class Paladin : BaseHero
{
    public Paladin(string name) : base(name, 100) { }

    public override string CastAbility()
    {
        return $"Paladin - {Name} healed for {Power}";
    }
}

class Rogue : BaseHero
{
    public Rogue(string name) : base(name, 80) { }

    public override string CastAbility()
    {
        return $"Rogue - {Name} hit for {Power} damage";
    }
}

class Warrior : BaseHero
{
    public Warrior(string name) : base(name, 100) { }

    public override string CastAbility()
    {
        return $"Warrior - {Name} hit for {Power} damage";
    }
}