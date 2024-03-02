namespace Attribinter.Patterns.NonNullableObjectArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NonNullableObjectArgumentPatternFactory());

    public NonNullableObjectArgumentPatternFactory Factory { get; }

    private FactoryContext(NonNullableObjectArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
