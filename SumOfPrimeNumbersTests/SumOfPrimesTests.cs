using FluentAssertions;
using static StaticCodeAnalysisSamples.SumOfPrimesFinder;

namespace SumOfPrimeNumbersTests;

public class SumOfPrimeNumbersTests
{
    [Theory]
    [InlineData(10, 18)]
    [InlineData(20, 78)]
    public void SumOfPrimes_Should_Return_Results(int input, int expected)
    {
        var result = SumOfPrimes(input);
        result.Should().Be(expected);
    }
}