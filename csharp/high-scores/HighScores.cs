using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> list;
    public HighScores(List<int> list)
    {
        this.list = list;
    }

    public List<int> Scores()
    {
        return list;
    }

    public int Latest()
    {
        return list[list.Count - 1];
    }

    public int PersonalBest()
    {
        return list.Max();
    }

    public List<int> PersonalTopThree()
    {
        List<int> biggestNumbers = list.OrderByDescending(x => x).Take(3).ToList();
        return biggestNumbers;
   
    }
}