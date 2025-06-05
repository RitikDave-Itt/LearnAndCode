using System;
using UnitTestAssignment.CustomExceptions;

class Program
{
    static void Main()
    {
        int totalInputs = int.Parse(Console.ReadLine());

        for (int iterator = 0; iterator < totalInputs; iterator++)
        {
            try
            {
                int inputNumber = int.Parse(Console.ReadLine());
                int result = DivisorUtils.CountPairsWithEqualDivisors(inputNumber);
                Console.WriteLine(result);
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid number format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
