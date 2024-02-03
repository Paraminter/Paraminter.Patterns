namespace SharpAttributeParser.Patterns.FloatArgumentPatternFactoryCases;

using Xunit;

public sealed class Create
{
    private static IArgumentPattern<float> Target(IFloatArgumentPatternFactory factory) => factory.Create();

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NotNull()
    {
        var actual = Target(Context.Factory);

        Assert.NotNull(actual);
    }
}
