class NeedForSpeed {

    // TODO: define the constructor for the 'NeedForSpeed' class

    private int speed;
    private int battery = 100;
    private int batteryDrain;
    private int meters;
    public NeedForSpeed(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    //Getters

    public int getBatteryDrain() {
        return batteryDrain;
    }
    public int getSpeed() {
        return speed;
    }


    //Action Methods
    public boolean batteryDrained() {
        if(battery == 0)
            return true;
        return false;
    }
    public int distanceDriven() {
       return meters;
    }
    public void drive() {
        if(batteryDrained()){
            meters += 0;
        }
        else if(!batteryDrained()) {
            meters += speed;
            battery -= batteryDrain;
        }
    }

    public static NeedForSpeed nitro() {
        NeedForSpeed car = new NeedForSpeed(50,4);
        return car; 
    }
}

class RaceTrack {

    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public boolean tryFinishTrack(NeedForSpeed car) {

        if((double)((double)distance / car.getSpeed()) * car.getBatteryDrain() <= 100)
            return true;
        return false;

    }

    public static void main(String[] args) {
        int speed = 3;
        int batteryDrain = 20;
        var car = new NeedForSpeed(speed, batteryDrain);

        int distance = 16;
        var race = new RaceTrack(distance);
    }
}
