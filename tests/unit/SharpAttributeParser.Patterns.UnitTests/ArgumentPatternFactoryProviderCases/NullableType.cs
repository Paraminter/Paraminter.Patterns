namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NullableType
{
    private static INullableTypeArgumentPatternFactory Target(IArgumentPatternFactoryProvider provider) => provider.NullableType;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NullableType, actual);
    }
}
