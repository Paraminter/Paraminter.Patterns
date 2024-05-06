namespace Paraminter.Patterns.ArgumentPatternMatchResultFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Constructor
{
    [Fact]
    public void NullFactoryProvider_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidFactoryProvider_ReturnsFactory()
    {
        var result = Target(Mock.Of<IArgumentPatternMatchResultFactoryProvider>());

        Assert.NotNull(result);
    }

    private static ArgumentPatternMatchResultFactory Target(IArgumentPatternMatchResultFactoryProvider factoryProvider) => new(factoryProvider);
}
