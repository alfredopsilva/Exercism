import java.util.*;

class DnDCharacter {

    private ArrayList<Integer> totalScore;
    private int strength;
    private int dexterity;
    private int constitution;
    private int intelligence;
    private int wisdom;
    private int charisma;
    private int hitpoints = 10;
    private Random dice;

    public DnDCharacter(){
        this.wisdom = ability();
        this.charisma = ability();
        this.intelligence = ability();
        this.constitution = ability();
        this.dexterity = ability();
        this.strength = ability();
    }

    int ability() {

        Random dice = new Random();
        // Total Score
        totalScore = new ArrayList<>();

        // Declaring Number of Dices
        int numberOfDices = 4;

        // Adding 4 Random Numbers
        for(var i = 0; i <= numberOfDices; i++)
        {
            totalScore.add(1 + dice.nextInt(6));
        }

        // Sorting Values
        Collections.sort(totalScore, Collections.reverseOrder());

        return totalScore.get(0) + totalScore.get(1) + totalScore.get(2);
        //return dice.ints(numberOfDices,1,7).sorted().skip(1).sum();
    }

    int modifier(int input) {
        return Math.floorDiv(input - 10, 2);

    }

    int getStrength() {
        return strength;
    }

    int getDexterity() {
        return dexterity;
    }

    int getConstitution() {
        return constitution;
    }

    int getIntelligence() {
        return intelligence;
    }

    int getWisdom() {
        return wisdom;
    }

    int getCharisma() {
        return charisma;
    }

    int getHitpoints() {
       String message = "Just Changing code for submitting";
        return hitpoints + modifier(constitution);
    }

}
