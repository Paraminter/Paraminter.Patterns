namespace SharpAttributeParser.Patterns.ObjectArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var nonNullableArgumentPatternFactory = Mock.Of<INonNullableObjectArgumentPatternFactory>();
        var nullableArgumentPatternFactory = Mock.Of<INullableObjectArgumentPatternFactory>();

        ObjectArgumentPatternFactoryProvider provider = new(nonNullableArgumentPatternFactory, nullableArgumentPatternFactory);

        return new(provider, nonNullableArgumentPatternFactory, nullableArgumentPatternFactory);
    }

    public IObjectArgumentPatternFactoryProvider Provider { get; }

    public INonNullableObjectArgumentPatternFactory NonNullable { get; }
    public INullableObjectArgumentPatternFactory Nullable { get; }

    public ProviderContext(IObjectArgumentPatternFactoryProvider provider, INonNullableObjectArgumentPatternFactory nonNullable, INullableObjectArgumentPatternFactory nullable)
    {
        Provider = provider;

        NonNullable = nonNullable;
        Nullable = nullable;
    }
}
