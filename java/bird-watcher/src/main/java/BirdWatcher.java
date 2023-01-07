
class BirdWatcher {
    private int[] birdsPerDay;

    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
    }

    public int[] getLastWeek() {
       birdsPerDay = new int[]{0, 2, 5, 3, 7, 8, 4};
       return birdsPerDay;
    }

    public int getToday() {
        if(birdsPerDay.length == 0)
            return 0;
        return birdsPerDay[birdsPerDay.length - 1];

    }

    public void incrementTodaysCount() {
        birdsPerDay[birdsPerDay.length - 1] = getToday() + 1;

    }

    public boolean hasDayWithoutBirds() {
        for(var i = 0; i < birdsPerDay.length; i++)
        {
            if(birdsPerDay[i] == 0)
                return true;
        }
        return false;
    }

    public int getCountForFirstDays(int numberOfDays) {
        int countOfBirds = 0;
        if(numberOfDays <= birdsPerDay.length ) {
            for (var i = 0; i < numberOfDays; i++) {
                countOfBirds += birdsPerDay[i];
            }
        }
        else if(numberOfDays > birdsPerDay.length)
        {
            for (var i = 0; i < birdsPerDay.length; i++) {
                countOfBirds += birdsPerDay[i];
            }
        }
        return countOfBirds;
    }

    public int getBusyDays() {
        int countOfDays = 0;
        for(var i = 0; i < birdsPerDay.length ; i++)
        {
            if(birdsPerDay[i] >= 5)
            {
                countOfDays++;
            }
        }
        return countOfDays;
    }
}
