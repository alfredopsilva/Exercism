class ArmstrongNumbers {

    boolean isArmstrongNumber(int numberToCheck) {
       return true;
    }

    public static void main(String[] args) {
        String numberName = Integer.toString(91);
        int numberSize = numberName.length();
        int result = 0;


        for(var i = 0; i < numberSize; i++)
        {
            result += Math.pow(Character.getNumericValue(numberName.charAt(i)),numberSize);

        }

        System.out.println(result);
    }

}
