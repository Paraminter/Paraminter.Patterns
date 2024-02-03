namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NullableArray
{
    private static INullableArrayArgumentPatternFactory Target(IArgumentPatternFactoryProvider provider) => provider.NullableArray;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NullableArray, actual);
    }
}
