namespace SharpAttributeParser.Patterns.NonNullableReadOnlyArrayArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NonNullableReadOnlyArrayArgumentPatternFactory());

    public NonNullableReadOnlyArrayArgumentPatternFactory Factory { get; }

    private FactoryContext(NonNullableReadOnlyArrayArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
