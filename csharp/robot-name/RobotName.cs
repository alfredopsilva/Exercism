using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    //Public Property
    public string Name { get; set; }

    //Data Fields
    private static Random _random = new Random();
    private static HashSet<string> _checkName = new HashSet<string>();

    public Robot() => Reset();


    //Class Methods
    public void Reset() => Name = GenerateName();

    public string GenerateName()
    {

        string robotName = "";
        
        for (var i = 0; i < 2; i++)
        {
            char letter = (char)_random.Next('A', 'Z' + 1);
           robotName += letter;
        }
        for (var j = 0; j < 3; j++)
        {
            int numbers = _random.Next(0, 10);
           robotName += numbers;
        }
        

        robotName = _checkName.Add(robotName) ? robotName : GenerateName();
        return robotName;
    }


}

