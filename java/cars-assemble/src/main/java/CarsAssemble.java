public class CarsAssemble {

    public double productionRatePerHour(int speed) {
        double sucessRate = 0;
        if(speed >= 1 && speed <= 4)
            sucessRate = 1;
        else if(speed >= 5 && speed <= 8)
            sucessRate = .9;
        else if(speed == 9)
            sucessRate = .8;
        else
            sucessRate = .77;

        return (221 * speed ) * sucessRate;
    }

    public int workingItemsPerMinute(int speed) {
        return (int)productionRatePerHour(speed) / 60;
    }
}
