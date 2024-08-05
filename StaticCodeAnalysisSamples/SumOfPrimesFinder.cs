namespace StaticCodeAnalysisSamples;

public static class SumOfPrimesFinder
{
    public static int SumOfPrimes(int max) { 
        var total = 0;
        for (var i = 1; i <= max; ++i)
        {
            bool isPrime = true;
            for (var j = 2; j < i; ++j) { 
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(i);
                total += i;
            }
            
        }
        return total;
    }
}