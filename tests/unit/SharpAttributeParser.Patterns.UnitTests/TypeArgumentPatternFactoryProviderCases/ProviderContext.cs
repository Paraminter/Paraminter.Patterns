namespace SharpAttributeParser.Patterns.TypeArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var nonNullableArgumentPatternFactory = Mock.Of<INonNullableTypeArgumentPatternFactory>();
        var nullableArgumentPatternFactory = Mock.Of<INullableTypeArgumentPatternFactory>();

        TypeArgumentPatternFactoryProvider provider = new(nonNullableArgumentPatternFactory, nullableArgumentPatternFactory);

        return new(provider, nonNullableArgumentPatternFactory, nullableArgumentPatternFactory);
    }

    public ITypeArgumentPatternFactoryProvider Provider { get; }

    public INonNullableTypeArgumentPatternFactory NonNullable { get; }
    public INullableTypeArgumentPatternFactory Nullable { get; }

    public ProviderContext(ITypeArgumentPatternFactoryProvider provider, INonNullableTypeArgumentPatternFactory nonNullable, INullableTypeArgumentPatternFactory nullable)
    {
        Provider = provider;

        NonNullable = nonNullable;
        Nullable = nullable;
    }
}
