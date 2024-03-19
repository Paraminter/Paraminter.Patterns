namespace Attribinter.Patterns.ArgumentRecorderFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private static IArgumentRecorder<TParameter, TIn> Target<TParameter, TIn, TOut>(IArgumentRecorder<TParameter, TOut> patternedRecorder, IArgumentPattern<TIn, TOut> pattern) => Target(Context.Factory, patternedRecorder, pattern);
    private static IArgumentRecorder<TParameter, TIn> Target<TParameter, TIn, TOut>(IArgumentRecorderFactory factory, IArgumentRecorder<TParameter, TOut> patternedRecorder, IArgumentPattern<TIn, TOut> pattern) => factory.Create(patternedRecorder, pattern);

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullPatternedRecorder_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target<object, object, object>(null!, Mock.Of<IArgumentPattern<object, object>>()));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void NullPattern_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target<object, object, object>(Mock.Of<IArgumentRecorder<object, object>>(), null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidPatternedRecorderAndPattern_ReturnsNotNull()
    {
        var actual = Target(Mock.Of<IArgumentRecorder<object, object>>(), Mock.Of<IArgumentPattern<object, object>>());

        Assert.NotNull(actual);
    }
}
