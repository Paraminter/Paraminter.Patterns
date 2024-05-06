namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryProviderCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullSuccessful_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!, Mock.Of<IUnsuccessfulArgumentPatternMatchResultFactory>()));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void NullUnsuccessful_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(Mock.Of<ISuccessfulArgumentPatternMatchResultFactory>(), null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidArguments_ReturnsFactory()
    {
        var result = Target(Mock.Of<ISuccessfulArgumentPatternMatchResultFactory>(), Mock.Of<IUnsuccessfulArgumentPatternMatchResultFactory>());

        Assert.NotNull(result);
    }

    private static ArgumentPatternMatchResultFactoryProvider Target(ISuccessfulArgumentPatternMatchResultFactory successful, IUnsuccessfulArgumentPatternMatchResultFactory unsuccessful) => new(successful, unsuccessful);
}
