using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int result = DivisorUtils.CountMatchingDivisors(n);
            Console.WriteLine(result);
        }
    }
}
