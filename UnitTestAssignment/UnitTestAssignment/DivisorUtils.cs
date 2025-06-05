using System;

public static class DivisorUtils
{
    public static int CountPairsWithEqualDivisors(int number)
    {
        if (number <= 0) return 0;

        int matchingPairCount = 0;

        for (int firstNumber = 1; firstNumber <= number; firstNumber++)
        {
            int secondNumber = number - firstNumber + 1;

            if (FindDivisorCount(firstNumber) == FindDivisorCount(secondNumber))
            {
                matchingPairCount++;
            }
        }

        return matchingPairCount;
    }

    private static int FindDivisorCount(int value)
    {
        int divisorCount = 0;
        int squareRoot = (int)Math.Sqrt(value);

        for (int possibleDivisor = 1; possibleDivisor <= squareRoot; possibleDivisor++)
        {
            if (value % possibleDivisor == 0)
            {
                divisorCount += (possibleDivisor * possibleDivisor == value) ? 1 : 2;
            }
        }

        return divisorCount;
    }
}
