namespace Attribinter.Patterns.ArgumentPatternMatchResultCases;

using Xunit;

public sealed class Constructor
{
    private static ArgumentPatternMatchResult<T> Target<T>() => new();

    [Fact]
    public void Successful_Is_False()
    {
        var result = Target<int>();

        Assert.False(result.Successful);
    }
}
