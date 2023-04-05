using System;

static class GameMaster
{
    public static string Describe(Character character)
    {
        return $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
    }

    public static string Describe(Destination destination)
    {
        return $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    }

    public static string Describe(TravelMethod travelMethod)
    {
        string? message = null;

        if (travelMethod is TravelMethod.Horseback)
        {
            message = "You're traveling to your destination on horseback.";
        }
        else if (travelMethod is TravelMethod.Walking)
        {
            message = "You're traveling to your destination by walking.";
        }
        else
        {
            throw new ArgumentException("You need to choose a valid Travel Method");
        }

        return message;
    }

    public static string Describe(Character character, Destination destination, TravelMethod travelMethod)
    {
        string travel = travelMethod.ToString().ToLower();
        return $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points. You're traveling to your destination on {travel}. You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    }

    public static string Describe(Character character, Destination destination)
    {
        return $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points. You're traveling to your destination by walking. You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
    }
}


class Character
{
    public string Class { get; set; }
    public int Level { get; set; }
    public int HitPoints { get; set; }
}

class Destination
{
    public string Name { get; set; }
    public int Inhabitants { get; set; }
}

enum TravelMethod
{
    Walking,
    Horseback
}
