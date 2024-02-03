namespace SharpAttributeParser.Patterns.NonNullableTypeArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NonNullableTypeArgumentPatternFactory());

    public NonNullableTypeArgumentPatternFactory Factory { get; }

    private FactoryContext(NonNullableTypeArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
