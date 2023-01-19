class ArmstrongNumbers {

    boolean isArmstrongNumber(int numberToCheck) {

        String numberName = Integer.toString(numberToCheck);
        int numberSize = numberName.length();
        int result = 0;

        for(var i = 0; i < numberSize; i++)
        {
            result += Math.pow(Character.getNumericValue(numberName.charAt(i)),numberSize);
        }

        return result == numberToCheck;

    }
}
