class Scrabble {
    private String word;
    private short score;

    Scrabble(String word) {
        this.word = word;
    }

    public int getScore() {

        String UpperCaseWord = word.toUpperCase();


        for (var i = 0; i < word.length(); i++) {
            switch (UpperCaseWord.charAt(i)) {
                case 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T':
                    score++;
                    break;
                case 'D', 'G':
                    score += 2;
                    break;
                case 'B', 'C', 'M', 'P':
                    score += 3;
                    break;
                case 'F', 'H', 'V', 'W', 'Y':
                    score += 4;
                    break;
                case 'K':
                    score += 5;
                    break;
                case 'J', 'X':
                    score += 8;
                    break;
                case 'Q', 'Z':
                    score += 10;
                    break;
            }

        }

        return score;
    }
}
