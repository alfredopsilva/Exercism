import java.math.BigDecimal;
import java.math.BigInteger;

class Grains {

    BigInteger grainsOnSquare(final int square) {
        long firstSquare = 1;

        for(int i = 1; i < square; i++)
        {
            firstSquare =+ firstSquare * 2;
        }

        return BigInteger.valueOf(firstSquare).abs();
    }

    BigInteger grainsOnBoard() {

        double amountOfGrains = 1;

        for(var i = 1; i <= 64; i++)
        {
            amountOfGrains =+ amountOfGrains * 2;
        }


        BigInteger k = BigDecimal.valueOf(amountOfGrains).toBigInteger();
        return k;
    }

    public static void main(String[] args) {
        var test = new Grains();
        System.out.println(test.grainsOnBoard());
    }

}

