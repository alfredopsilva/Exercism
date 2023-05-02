using System;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

// The scores are pow of 2;
 
public class Allergies
{
    public Allergies(int mask)
    {
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public Allergen[] List()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}