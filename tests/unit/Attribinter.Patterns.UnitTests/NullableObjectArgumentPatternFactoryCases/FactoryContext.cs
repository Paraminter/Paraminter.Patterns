namespace Attribinter.Patterns.NullableObjectArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NullableObjectArgumentPatternFactory());

    public NullableObjectArgumentPatternFactory Factory { get; }

    private FactoryContext(NullableObjectArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
