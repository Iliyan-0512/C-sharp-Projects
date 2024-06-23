using System;
using System.Collections.Generic;

abstract class BaseHero
{
    public string Name { get; set; }
    public int Power { get; set; }

    protected BaseHero(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public abstract string CastAbility();
}