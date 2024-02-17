namespace SharpAttributeParser.Patterns.NullableArrayArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class ReadWrite
{
    private static INullableReadWriteArrayArgumentPatternFactory Target(INullableArrayArgumentPatternFactoryProvider provider) => provider.ReadWrite;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.ReadWrite, actual);
    }
}
