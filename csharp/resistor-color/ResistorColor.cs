using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int? colorNumber = null; 
        
        switch (color.ToLower())
        {
            case "black":
                colorNumber = 0;
                break;
            case "brown":
                colorNumber = 1;
                break;
            case "red":
                colorNumber = 2;
                break;
            case "orange":
                colorNumber = 3;
                break;
            case "yellow":
                colorNumber = 4;
                break;
            case "green":
                colorNumber = 5;
                break;
            case "blue":
                colorNumber = 6;
                break;
            case "violet":
                colorNumber = 7;
                break;
            case "grey":
                colorNumber = 8;
                break;
            case "white":
                colorNumber = 9;
                break;
        }

        return (int)colorNumber;
    }

    public static string[] Colors()
    {
        String[] colorNames = new string[] { "Black", "Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet", "Grey", "White" };
        return colorNames;
    }
}