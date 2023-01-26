import java.math.BigDecimal;
import java.math.BigInteger;

class Grains {

    BigInteger grainsOnSquare(final int square) {

        // Validating if the square is a valid number ( between 1 - 64 )
        validateSquare(square);

        BigInteger amountOfGrains ;
        amountOfGrains = BigInteger.valueOf(1L);

        for(int i = 1; i < square; i++)
        {
            amountOfGrains = amountOfGrains.multiply(BigInteger.valueOf(2));
        }

        return  amountOfGrains;
    }

    private void validateSquare(final int square)
    {
        if(square <= 0 || square > 64)
            throw new IllegalArgumentException("square must be between 1 and 64");
    }

    BigInteger grainsOnBoard() {

        BigInteger amountOfGrains ;
        amountOfGrains = BigInteger.valueOf(1L);

        for(var i = 1; i <= 64; i++)
        {
            amountOfGrains = amountOfGrains.multiply(BigInteger.valueOf(2));
        }


        return amountOfGrains.subtract(BigInteger.ONE);
    }

}
