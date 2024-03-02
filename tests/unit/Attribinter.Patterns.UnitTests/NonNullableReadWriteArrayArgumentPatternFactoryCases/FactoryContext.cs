namespace Attribinter.Patterns.NonNullableReadWriteArrayArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new NonNullableReadWriteArrayArgumentPatternFactory());

    public NonNullableReadWriteArrayArgumentPatternFactory Factory { get; }

    private FactoryContext(NonNullableReadWriteArrayArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
