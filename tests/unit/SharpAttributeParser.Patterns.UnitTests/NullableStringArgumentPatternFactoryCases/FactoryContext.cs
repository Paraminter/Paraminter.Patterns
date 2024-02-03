namespace SharpAttributeParser.Patterns.NullableStringArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NullableStringArgumentPatternFactory());

    public NullableStringArgumentPatternFactory Factory { get; }

    private FactoryContext(NullableStringArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
