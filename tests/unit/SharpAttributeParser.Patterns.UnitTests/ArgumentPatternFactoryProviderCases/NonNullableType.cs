namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NonNullableType
{
    private static INonNullableTypeArgumentPatternFactory Target(IArgumentPatternFactoryProvider provider) => provider.NonNullableType;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NonNullableType, actual);
    }
}
