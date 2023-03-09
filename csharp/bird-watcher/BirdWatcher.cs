using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeek;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        bool flag = false; 
        
        foreach (int day in birdsPerDay)
        {
            if (day == 0)
            {
                flag = true;
            }
        }

        return flag;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counter = 0;

        for (var i = 0; i < numberOfDays; i++)
        {
            counter += birdsPerDay[i];
        }
        return counter;
    }

    public int BusyDays()
    {
        int counter = 0;
        for (var i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
                counter++;
        }
        return counter;
    }
}
