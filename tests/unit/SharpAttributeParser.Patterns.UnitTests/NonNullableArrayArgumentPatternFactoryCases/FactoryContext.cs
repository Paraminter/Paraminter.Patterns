namespace SharpAttributeParser.Patterns.NonNullableArrayArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NonNullableArrayArgumentPatternFactory());

    public NonNullableArrayArgumentPatternFactory Factory { get; }

    private FactoryContext(NonNullableArrayArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
