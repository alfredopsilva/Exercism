
class BirdWatcher {
    private final int[] birdsPerDay;
    private int arrayLength ;

    public BirdWatcher(int[] birdsPerDay) {
        this.birdsPerDay = birdsPerDay.clone();
        arrayLength = birdsPerDay.length;
    }

    public int[] getLastWeek() {
        int[] count = {0,2,5,3,7,8,4};
        return count;
    }

    public int getToday() {
        return birdsPerDay[arrayLength -1];
    }

    public void incrementTodaysCount() {
        birdsPerDay[arrayLength - 1] += 1;
    }

    public boolean hasDayWithoutBirds() {

        boolean flag = false;

        for(var i = 0; i < arrayLength; i++){
            if(birdsPerDay[i] == 0)
                flag = true;
        }
        return flag;
    }

    public int getCountForFirstDays(int numberOfDays) {
        int counter = 0;

        //Check if the value passesd is greater than a week, if it is assigned a value corresponding to one week.
        if(numberOfDays > 7){
            numberOfDays = 7;
        }

        for(var i = 0; i < numberOfDays; i++){
            counter += birdsPerDay[i];
        }

        return counter;
    }

    public int getBusyDays() {
        int counter = 0;

        for(var i = 0; i < arrayLength; i++){
            if(birdsPerDay[i] >= 5)
                counter++;
        }

        return counter;
    }
}
