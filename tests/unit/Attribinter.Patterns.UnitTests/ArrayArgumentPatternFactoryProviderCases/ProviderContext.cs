namespace Attribinter.Patterns.ArrayArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var nonNullable = Mock.Of<INonNullableArrayArgumentPatternFactoryProvider>();
        var nullable = Mock.Of<INullableArrayArgumentPatternFactoryProvider>();

        ArrayArgumentPatternFactoryProvider provider = new(nonNullable, nullable);

        return new(provider, nonNullable, nullable);
    }

    public IArrayArgumentPatternFactoryProvider Provider { get; }

    public INonNullableArrayArgumentPatternFactoryProvider NonNullable { get; }
    public INullableArrayArgumentPatternFactoryProvider Nullable { get; }

    public ProviderContext(IArrayArgumentPatternFactoryProvider provider, INonNullableArrayArgumentPatternFactoryProvider nonNullable, INullableArrayArgumentPatternFactoryProvider nullable)
    {
        Provider = provider;

        NonNullable = nonNullable;
        Nullable = nullable;
    }
}
