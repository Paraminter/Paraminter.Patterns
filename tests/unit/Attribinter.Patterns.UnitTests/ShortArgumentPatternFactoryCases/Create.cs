namespace Attribinter.Patterns.ShortArgumentPatternFactoryCases;

using Xunit;

public sealed class Create
{
    private static IArgumentPattern<short> Target(IShortArgumentPatternFactory factory) => factory.Create();

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void ReturnsNotNull()
    {
        var actual = Target(Context.Factory);

        Assert.NotNull(actual);
    }
}
