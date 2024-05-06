namespace Paraminter.Patterns.SuccessfulArgumentPatternMatchResultFactoryCases;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private static SuccessfulArgumentPatternMatchResultFactory Target() => new();
}
