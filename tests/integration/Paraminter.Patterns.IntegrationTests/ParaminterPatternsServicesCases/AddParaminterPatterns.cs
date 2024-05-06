namespace Paraminter.Semantic.ParaminterPatternsServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

using Paraminter.Patterns;

using System;

using Xunit;

public sealed class AddParaminterPatterns
{
    [Fact]
    public void NullServiceCollection_ArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidServiceCollection_ReturnsSameServiceCollection()
    {
        var services = Mock.Of<IServiceCollection>();

        var result = Target(services);

        Assert.Same(services, result);
    }

    [Fact]
    public void IArgumentDataRecorderFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IArgumentDataRecorderFactory>();

    [Fact]
    public void ISuccessfulArgumentPatternMatchResultFactory_ServiceCanBeResolved() => ServiceCanBeResolved<ISuccessfulArgumentPatternMatchResultFactory>();

    [Fact]
    public void IUnsuccessfulArgumentPatternMatchResultFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IUnsuccessfulArgumentPatternMatchResultFactory>();

    [Fact]
    public void IArgumentPatternMatchResultFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IArgumentPatternMatchResultFactory>();

    [Fact]
    public void IArgumentPatternMatchResultFactoryProvider_ServiceCanBeResolved() => ServiceCanBeResolved<IArgumentPatternMatchResultFactoryProvider>();

    private static IServiceCollection Target(IServiceCollection services) => ParaminterPatternsServices.AddParaminterPatterns(services);

    [AssertionMethod]
    private static void ServiceCanBeResolved<TService>()
        where TService : notnull
    {
        HostBuilder host = new();

        host.ConfigureServices(static (services) => Target(services));

        var serviceProvider = host.Build().Services;

        var result = serviceProvider.GetRequiredService<TService>();

        Assert.NotNull(result);
    }
}
