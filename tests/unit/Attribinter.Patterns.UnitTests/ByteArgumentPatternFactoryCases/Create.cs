namespace Attribinter.Patterns.ByteArgumentPatternFactoryCases;

using Xunit;

public sealed class Create
{
    private static IArgumentPattern<byte> Target(IByteArgumentPatternFactory factory) => factory.Create();

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void ReturnsNotNull()
    {
        var actual = Target(Context.Factory);

        Assert.NotNull(actual);
    }
}
