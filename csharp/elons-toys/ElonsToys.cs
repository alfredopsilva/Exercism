using System;

class RemoteControlCar
{
    private int distance;
    private int bateryPercentage;

    public RemoteControlCar()
    {
        distance = 0;
        bateryPercentage = 100; 

    } 
    
    public static RemoteControlCar Buy()
    {
        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        
        return bateryPercentage == 0 ? "Battery empty" : $"Battery at {bateryPercentage}%";
    }

    public void Drive()
    {
        if (distance == 2000)
        {
            distance += 0;
            bateryPercentage -= 0;
        }
        else
        {
            distance += 20;
            bateryPercentage -= 1;
        }
    }
}
