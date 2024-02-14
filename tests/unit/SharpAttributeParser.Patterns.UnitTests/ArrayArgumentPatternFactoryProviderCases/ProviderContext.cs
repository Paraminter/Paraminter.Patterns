namespace SharpAttributeParser.Patterns.ArrayArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var nonNullableArgumentPatternFactory = Mock.Of<INonNullableArrayArgumentPatternFactory>();
        var nullableArgumentPatternFactory = Mock.Of<INullableArrayArgumentPatternFactory>();

        ArrayArgumentPatternFactoryProvider provider = new(nonNullableArgumentPatternFactory, nullableArgumentPatternFactory);

        return new(provider, nonNullableArgumentPatternFactory, nullableArgumentPatternFactory);
    }

    public IArrayArgumentPatternFactoryProvider Provider { get; }

    public INonNullableArrayArgumentPatternFactory NonNullable { get; }
    public INullableArrayArgumentPatternFactory Nullable { get; }

    public ProviderContext(IArrayArgumentPatternFactoryProvider provider, INonNullableArrayArgumentPatternFactory nonNullable, INullableArrayArgumentPatternFactory nullable)
    {
        Provider = provider;

        NonNullable = nonNullable;
        Nullable = nullable;
    }
}
