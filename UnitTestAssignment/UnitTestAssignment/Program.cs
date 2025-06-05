using System;

class Program
{
    static void Main()
    {
        int totalInputs = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalInputs; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int result = DivisorUtils.CountPairsWithEqualDivisors(inputNumber);
            Console.WriteLine(result);
        }
    }
}
