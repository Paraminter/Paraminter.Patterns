namespace Attribinter.Patterns.UIntArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new UIntArgumentPatternFactory());

    public UIntArgumentPatternFactory Factory { get; }

    private FactoryContext(UIntArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
