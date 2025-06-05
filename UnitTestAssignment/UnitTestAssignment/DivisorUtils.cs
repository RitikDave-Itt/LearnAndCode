using System;
using UnitTestAssignment.CustomExceptions;

public static class DivisorUtils
{
    public static int CountPairsWithEqualDivisors(int number)
    {
        if (number < 0)
        {
            throw new InvalidInputException("Input must be a non-negative integer.");
        }

        if (number == 0) return 0;

        int equalDivisorPairCount = 0;

        for (int firstValue = 1; firstValue <= number; firstValue++)
        {
            int secondValue = number - firstValue + 1;

            if (FindDivisorCount(firstValue) == FindDivisorCount(secondValue))
            {
                equalDivisorPairCount++;
            }
        }

        return equalDivisorPairCount;
    }

    private static int FindDivisorCount(int value)
    {
        int divisorCount = 0;
        int sqrt = (int)Math.Sqrt(value);

        for (int divisor = 1; divisor <= sqrt; divisor++)
        {
            if (value % divisor == 0)
            {
                divisorCount += (divisor * divisor == value) ? 1 : 2;
            }
        }

        return divisorCount;
    }
}
