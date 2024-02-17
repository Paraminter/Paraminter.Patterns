namespace SharpAttributeParser.Patterns.NullableArrayArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class ReadOnly
{
    private static INullableReadOnlyArrayArgumentPatternFactory Target(INullableArrayArgumentPatternFactoryProvider provider) => provider.ReadOnly;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.ReadOnly, actual);
    }
}
