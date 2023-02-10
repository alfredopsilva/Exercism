using System;

public class Player
{
    private Random numberGenerator;
    public int RollDie()
    {
        numberGenerator = new Random();
        return numberGenerator.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        numberGenerator = new Random();
        return numberGenerator.NextDouble() * 100;
    }
}
