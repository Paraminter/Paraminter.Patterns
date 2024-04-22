namespace Attribinter.Patterns.ArgumentRecorderFactoryCases;

using Xunit;

public sealed class Constructor
{
    private static ArgumentRecorderFactory Target() => new();

    [Fact]
    public void ReturnsFactory()
    {
        var result = Target();

        Assert.NotNull(result);
    }
}
