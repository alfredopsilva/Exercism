using System;

abstract class Character
{
    private string characterType;
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        throw new NotImplementedException("Please implement the Character.Vulnerable() method");
    }

    public override string ToString()
    {
        throw new NotImplementedException("Please implement the Character.ToString() method");
    }
}

class Warrior : Character
{
    public Warrior() : base("TODO")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable() == true)
            return 10;
        return 6;
    }

    public override bool Vulnerable()
    {
        return false;
    }
    public override string ToString()
    {
        return "Character is a Warrior";
    }
}

class Wizard : Character
{
    private bool spellIsPrepared = false;
    public Wizard() : base("TODO")
    {
    }

    public override bool Vulnerable()
    {
        return spellIsPrepared != true;

    }
  
    public override int DamagePoints(Character target)
    {
        if (spellIsPrepared == true)
            return 12;
        return 3; 
    }

    public void PrepareSpell()
    {
        spellIsPrepared = true;
    }

    public override string ToString()
    {
        return "Character is a Wizard";
    }
}
