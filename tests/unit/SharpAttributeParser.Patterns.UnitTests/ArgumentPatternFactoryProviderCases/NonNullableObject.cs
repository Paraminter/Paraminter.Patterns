namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Xunit;

public sealed class NonNullableObject
{
    private static INonNullableObjectArgumentPatternFactory Target(IArgumentPatternFactoryProvider provider) => provider.NonNullableObject;

    private static readonly ProviderContext Context = ProviderContext.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var actual = Target(Context.Provider);

        Assert.Same(Context.NonNullableObject, actual);
    }
}
