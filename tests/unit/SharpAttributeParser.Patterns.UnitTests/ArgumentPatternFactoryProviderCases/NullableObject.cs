namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NullableObject
{
    private static INullableObjectArgumentPatternFactory Target(IArgumentPatternFactoryProvider provider) => provider.NullableObject;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NullableObject, actual);
    }
}
