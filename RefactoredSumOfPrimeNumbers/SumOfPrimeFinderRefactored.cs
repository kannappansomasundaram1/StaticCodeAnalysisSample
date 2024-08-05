namespace RefactoredSumOfPrimeNumbers;

public static class SumOfPrimeFinderRefactored
{
    public static int SumOfPrimes(int max) =>
        Enumerable.Range(1, max)
            .Where(IsPrime)
            .Sum();

    private static bool  IsPrime(int number) =>
        Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
            .All(divisor => number % divisor != 0);
}