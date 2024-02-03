namespace SharpAttributeParser.Patterns.LongArgumentPatternFactoryCases;

using Xunit;

public sealed class Create
{
    private static IArgumentPattern<long> Target(ILongArgumentPatternFactory factory) => factory.Create();

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NotNull()
    {
        var actual = Target(Context.Factory);

        Assert.NotNull(actual);
    }
}
