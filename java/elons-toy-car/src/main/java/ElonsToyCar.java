public class ElonsToyCar {

    private int battery = 100;
    private int distance = 0;

    public static ElonsToyCar buy()
    {
        ElonsToyCar toyota = new ElonsToyCar();
        return toyota;
    }

    public String distanceDisplay()
    {
        if(distance < 2000)
            return "Driven " + distance + " meters";
        return "Driven 2000 meters";
    }

    public String batteryDisplay()
    {
        if(battery > 0)
            return "Battery at " + battery + "%";

        return "Battery empty";
    }

    public void drive()
    {
        distance = distance + 20;
        battery--;
    }

}
