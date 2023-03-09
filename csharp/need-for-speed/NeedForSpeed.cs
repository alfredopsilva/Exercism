using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

class RemoteControlCar
{
    public int Speed { get; }
    public int BateryDrain { get; }
    public int Batery { get; set; }
    
    private int _distanceDriven;
 
    public RemoteControlCar(int speed, int bateryDrain)
    {
        this.Speed = speed;
        this.BateryDrain = bateryDrain;
        Batery = 100;
    }

    public bool BateryDrained()
    {
        bool flag = false || (Batery <= 0 || Batery < BateryDrain);
        return flag;
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if (BateryDrained() || Batery < BateryDrain)
        {
            _distanceDriven += 0;
            Batery -= BateryDrain;
        }
        else
        {
            Batery -= BateryDrain;
            _distanceDriven += Speed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private readonly int _distance; 
    public RaceTrack(int distance)
    {
        this._distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        double distanceRatio = (double)_distance / car.Speed;
        double bateryRatio = (double)car.Batery / car.BateryDrain;

        return distanceRatio <= bateryRatio; 
    }
}
