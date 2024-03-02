namespace Attribinter.Patterns.NullableReadWriteArrayArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NullableReadWriteArrayArgumentPatternFactory());

    public NullableReadWriteArrayArgumentPatternFactory Factory { get; }

    private FactoryContext(NullableReadWriteArrayArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
