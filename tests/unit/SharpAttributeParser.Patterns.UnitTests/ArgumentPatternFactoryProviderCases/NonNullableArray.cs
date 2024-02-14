namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NonNullableArray
{
    private static INonNullableArrayArgumentPatternFactory Target(IArgumentPatternFactoryProvider provider) => provider.NonNullableArray;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NonNullableArray, actual);
    }
}
