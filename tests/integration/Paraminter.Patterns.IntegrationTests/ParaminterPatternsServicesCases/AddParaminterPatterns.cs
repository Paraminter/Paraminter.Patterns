namespace Paraminter.Semantic.ParaminterPatternsServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Paraminter.Patterns;

using Xunit;

public sealed class AddParaminterPatterns
{
    [Fact]
    public void IArgumentDataRecorderFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IArgumentDataRecorderFactory>();

    [Fact]
    public void ISuccessfulArgumentPatternMatchResultFactory_ServiceCanBeResolved() => ServiceCanBeResolved<ISuccessfulArgumentPatternMatchResultFactory>();

    [Fact]
    public void IUnsuccessfulArgumentPatternMatchResultFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IUnsuccessfulArgumentPatternMatchResultFactory>();

    [Fact]
    public void IArgumentPatternMatchResultFactoryProvider_ServiceCanBeResolved() => ServiceCanBeResolved<IArgumentPatternMatchResultFactoryProvider>();

    private static void Target(
        IServiceCollection services)
    {
        ParaminterPatternsServices.AddParaminterPatterns(services);
    }

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
