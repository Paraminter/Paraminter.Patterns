namespace SharpAttributeParser.Patterns.ArrayArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NonNullable
{
    private static INonNullableArrayArgumentPatternFactoryProvider Target(IArrayArgumentPatternFactoryProvider provider) => provider.NonNullable;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NonNullable, actual);
    }
}
