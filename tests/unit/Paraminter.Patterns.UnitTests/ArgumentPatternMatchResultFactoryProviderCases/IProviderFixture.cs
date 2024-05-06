namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryProviderCases;

using Moq;

internal interface IProviderFixture
{
    public abstract IArgumentPatternMatchResultFactoryProvider Sut { get; }

    public abstract Mock<ISuccessfulArgumentPatternMatchResultFactory> SuccessfulMock { get; }
    public abstract Mock<IUnsuccessfulArgumentPatternMatchResultFactory> UnsuccessfulMock { get; }
}
