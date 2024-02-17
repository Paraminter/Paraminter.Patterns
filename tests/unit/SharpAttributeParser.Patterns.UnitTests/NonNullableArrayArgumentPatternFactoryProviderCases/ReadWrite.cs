namespace SharpAttributeParser.Patterns.NonNullableArrayArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class ReadWrite
{
    private static INonNullableReadWriteArrayArgumentPatternFactory Target(INonNullableArrayArgumentPatternFactoryProvider provider) => provider.ReadWrite;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.ReadWrite, actual);
    }
}
