namespace Paraminter.Patterns;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services provided by <i>Paraminter.Patterns</i> to be registered with <see cref="IServiceCollection"/>.</summary>
public static class ParaminterPatternsServices
{
    /// <summary>Registers the services provided by <i>Paraminter.Patterns</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddParaminterPatterns(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<IArgumentDataRecorderFactory, ArgumentDataRecorderFactory>();

        services.AddTransient<ISuccessfulArgumentPatternMatchResultFactory, SuccessfulArgumentPatternMatchResultFactory>();
        services.AddTransient<IUnsuccessfulArgumentPatternMatchResultFactory, UnsuccessfulArgumentPatternMatchResultFactory>();
        services.AddTransient<IArgumentPatternMatchResultFactoryProvider, ArgumentPatternMatchResultFactoryProvider>();

        return services;
    }
}
