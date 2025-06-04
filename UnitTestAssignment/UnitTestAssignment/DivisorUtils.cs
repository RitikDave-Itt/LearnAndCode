using System;

public static class DivisorUtils
{
    public static int CountMatchingDivisors(int n)
    {
        if (n <= 0) return 0;

        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            int a = i;
            int b = n - i + 1;

            if (CountDivisors(a) == CountDivisors(b))
            {
                count++;
            }
        }

        return count;
    }

    private static int CountDivisors(int number)
    {
        int count = 0;
        int sqrt = (int)Math.Sqrt(number);

        for (int i = 1; i <= sqrt; i++)
        {
            if (number % i == 0)
            {
                count += (i * i == number) ? 1 : 2;
            }
        }

        return count;
    }
}