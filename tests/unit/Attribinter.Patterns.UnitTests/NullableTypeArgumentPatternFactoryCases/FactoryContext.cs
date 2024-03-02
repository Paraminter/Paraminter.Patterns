namespace Attribinter.Patterns.NullableTypeArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NullableTypeArgumentPatternFactory());

    public NullableTypeArgumentPatternFactory Factory { get; }

    private FactoryContext(NullableTypeArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
