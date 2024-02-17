namespace SharpAttributeParser.Patterns.ArrayArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var nonNullableArgumentPatternFactoryProvider = Mock.Of<INonNullableArrayArgumentPatternFactoryProvider>();
        var nullableArgumentPatternFactoryProvider = Mock.Of<INullableArrayArgumentPatternFactoryProvider>();

        ArrayArgumentPatternFactoryProvider provider = new(nonNullableArgumentPatternFactoryProvider, nullableArgumentPatternFactoryProvider);

        return new(provider, nonNullableArgumentPatternFactoryProvider, nullableArgumentPatternFactoryProvider);
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
