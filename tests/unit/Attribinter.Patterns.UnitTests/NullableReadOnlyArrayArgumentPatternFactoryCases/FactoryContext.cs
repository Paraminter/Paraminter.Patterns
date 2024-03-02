namespace Attribinter.Patterns.NullableReadOnlyArrayArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NullableReadOnlyArrayArgumentPatternFactory());

    public NullableReadOnlyArrayArgumentPatternFactory Factory { get; }

    private FactoryContext(NullableReadOnlyArrayArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
