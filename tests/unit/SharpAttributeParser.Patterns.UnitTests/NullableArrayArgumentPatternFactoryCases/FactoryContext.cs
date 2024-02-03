namespace SharpAttributeParser.Patterns.NullableArrayArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NullableArrayArgumentPatternFactory());

    public NullableArrayArgumentPatternFactory Factory { get; }

    private FactoryContext(NullableArrayArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
