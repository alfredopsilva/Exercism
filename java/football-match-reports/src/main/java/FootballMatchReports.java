public class FootballMatchReports {    
    public static String onField(int shirtNum) {
        // Creating Variable to return shirt name after switch.
        String positionName = "Default";

        validateShirtNumber(shirtNum);

        switch (shirtNum)
        {
            case 1:
            positionName = "Goalie";
            break;
            case 2:
            positionName = "Left Back";
            break;
            case 3, 4:
            positionName = "Center Back";
            break;
            case 5 :
            positionName = "right back";
            break;
            case 6, 7, 8:
            positionName = "midfielder";
            break;
            case 9:
            positionName = "left wing";
            break;
            case 10:
            positionName = "striker";
            break;
            case 11:
            positionName = "right wing";
            break;
        }

        return positionName.toLowerCase();
    }

    private static void  validateShirtNumber(int shirtNum) {
        if (shirtNum < 1 || shirtNum > 11)
            throw new IllegalArgumentException("The number must be between 1 and 11");

    }
}
