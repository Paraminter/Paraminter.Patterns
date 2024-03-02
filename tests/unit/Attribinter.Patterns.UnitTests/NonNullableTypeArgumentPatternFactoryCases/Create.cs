namespace Attribinter.Patterns.NonNullableTypeArgumentPatternFactoryCases;

using Microsoft.CodeAnalysis;

using Xunit;

public sealed class Create
{
    private static IArgumentPattern<ITypeSymbol> Target(INonNullableTypeArgumentPatternFactory factory) => factory.Create();

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void ReturnsNotNull()
    {
        var actual = Target(Context.Factory);

        Assert.NotNull(actual);
    }
}
