namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryCases;

using Moq;

internal interface IFactoryFixture
{
    public abstract IArgumentPatternMatchResultFactory Sut { get; }

    public abstract Mock<IArgumentPatternMatchResultFactoryProvider> FactoryProviderMock { get; }
}
