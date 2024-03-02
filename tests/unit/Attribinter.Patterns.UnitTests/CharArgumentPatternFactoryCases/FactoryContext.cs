namespace Attribinter.Patterns.CharArgumentPatternFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create() => new(new CharArgumentPatternFactory());

    public CharArgumentPatternFactory Factory { get; }

    private FactoryContext(CharArgumentPatternFactory factory)
    {
        Factory = factory;
    }
}
