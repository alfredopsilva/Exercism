class DifferenceOfSquaresCalculator {
    int computeSquareOfSumTo(int input) {
        int score = 0;
        for (var i = input; i >= 0; i--) {
            score += i;
        }

        return (int) Math.pow(score, 2);
    }

    int computeSumOfSquaresTo(int input) {
        int score = 0;
        for (var i = input; i >= 0; i--) {
            score += Math.pow(i, 2);
        }

        return score;
    }

    int computeDifferenceOfSquares(int input) {

        return computeSquareOfSumTo(input) - computeSumOfSquaresTo(input);
    }
}