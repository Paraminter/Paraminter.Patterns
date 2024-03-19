namespace Attribinter.Patterns.ArgumentRecorderFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        ArgumentRecorderFactory factory = new();

        return new(factory);
    }

    public IArgumentRecorderFactory Factory { get; }

    private FactoryContext(IArgumentRecorderFactory factory)
    {
        Factory = factory;
    }
}
