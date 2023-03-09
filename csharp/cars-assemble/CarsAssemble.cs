using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double sucessRate = 0; 
    
        if (speed >= 1 && speed <= 4)
            sucessRate = 1;
        else if (speed >= 5 && speed <= 8)
            sucessRate = .9;
        else if (speed == 9)
            sucessRate = .8;
        else if(speed == 10)
            sucessRate = .77;

        return sucessRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return (speed * 221) * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
       return (int)ProductionRatePerHour(speed)/60;
    }
}