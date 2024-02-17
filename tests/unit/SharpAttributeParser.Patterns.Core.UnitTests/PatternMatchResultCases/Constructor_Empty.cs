namespace SharpAttributeParser.Patterns.PatternMatchResultCases;

using Xunit;

public sealed class Constructor_Empty
{
    private static PatternMatchResult<T> Target<T>() => new();

    [Fact]
    public void WasUnsuccessful()
    {
        var result = Target<int>();

        Assert.False(result.WasSuccessful);
    }
}
