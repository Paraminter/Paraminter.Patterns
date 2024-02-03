namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NonNullableString
{
    private static INonNullableStringArgumentPatternFactory Target(IArgumentPatternFactoryProvider provider) => provider.NonNullableString;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NonNullableString, actual);
    }
}
