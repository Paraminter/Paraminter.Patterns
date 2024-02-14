namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NullableString
{
    private static INullableStringArgumentPatternFactory Target(IArgumentPatternFactoryProvider provider) => provider.NullableString;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NullableString, actual);
    }
}
