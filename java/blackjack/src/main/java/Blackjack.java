public class Blackjack {

    public int parseCard(String card) {

        int cardNumber;

        switch (card)
        {
            case "ace":
                cardNumber = 11;
                break;
            case "two":
                cardNumber = 2;
                break;
            case "three":
                cardNumber = 3;
                break;
            case "four":
                cardNumber = 4;
                break;
            case "five":
                cardNumber = 5;
                break;
            case "six":
                cardNumber = 6;
                break;
            case "seven":
                cardNumber = 7;
                break;
            case "eight":
                cardNumber = 8;
                break;
            case "nine":
                cardNumber = 9;
                break;
            case "ten":
            case "jack":
            case "queen":
            case "king":
                cardNumber = 10;
                break;
            default:
                cardNumber = 0;
                break;
        }

        return cardNumber;
    }

    public boolean isBlackjack(String card1, String card2) {

        return parseCard(card1) + parseCard(card2) == 21;
    }

    public String largeHand(boolean isBlackjack, int dealerScore) {

        String move = "";

        if(isBlackjack)
        {
            move = "W";
            if(dealerScore == 10 || dealerScore == 11){
                move = "S";
            }

       }

        return move;
    }

    public String smallHand(int handScore, int dealerScore) {
        String move = "";

        if(handScore >= 17)
            move = "S";

        if(handScore <= 11)
            move = "H";

        if(handScore >= 12 && handScore <= 16)
        {
            move = "S";

            if(dealerScore >= 7)
            {
                move = "H";
            }


        }

        return move;
    }


    // FirstTurn returns the semi-optimal decision for the first turn, given the cards of the player and the dealer.
    // This function is already implemented and does not need to be edited. It pulls the other functions together in a
    // complete decision tree for the first turn.
    public String firstTurn(String card1, String card2, String dealerCard) {
        int handScore = parseCard(card1) + parseCard(card2);
        int dealerScore = parseCard(dealerCard);

        if(card1 == "ace" && card2 == "ace"){
            return "P";
        }
        else if (20 < handScore) {
            return largeHand(isBlackjack(card1, card2), dealerScore);
        } else {
            return smallHand(handScore, dealerScore);
        }
    }
}
