namespace SharpAttributeParser.Patterns;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services provided by <i>SharpAttributeParser.Patterns</i> to be registered with a <see cref="IServiceCollection"/>.</summary>
public static class SharpAttributeParserPatternsServices
{
    /// <summary>Registers the services provided by <i>SharpAttributeParser.Patterns</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddSharpAttributeParserPatterns(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddSingleton<IArgumentPatternFactoryProvider, ArgumentPatternFactoryProvider>();
        services.AddSingleton<IStringArgumentPatternFactoryProvider, StringArgumentPatternFactoryProvider>();
        services.AddSingleton<IObjectArgumentPatternFactoryProvider, ObjectArgumentPatternFactoryProvider>();
        services.AddSingleton<ITypeArgumentPatternFactoryProvider, TypeArgumentPatternFactoryProvider>();
        services.AddSingleton<IArrayArgumentPatternFactoryProvider, ArrayArgumentPatternFactoryProvider>();

        services.AddSingleton<IBoolArgumentPatternFactory, BoolArgumentPatternFactory>();
        services.AddSingleton<IByteArgumentPatternFactory, ByteArgumentPatternFactory>();
        services.AddSingleton<ISByteArgumentPatternFactory, SByteArgumentPatternFactory>();
        services.AddSingleton<ICharArgumentPatternFactory, CharArgumentPatternFactory>();
        services.AddSingleton<IShortArgumentPatternFactory, ShortArgumentPatternFactory>();
        services.AddSingleton<IUShortArgumentPatternFactory, UShortArgumentPatternFactory>();
        services.AddSingleton<IIntArgumentPatternFactory, IntArgumentPatternFactory>();
        services.AddSingleton<IUIntArgumentPatternFactory, UIntArgumentPatternFactory>();
        services.AddSingleton<ILongArgumentPatternFactory, LongArgumentPatternFactory>();
        services.AddSingleton<IULongArgumentPatternFactory, ULongArgumentPatternFactory>();
        services.AddSingleton<IFloatArgumentPatternFactory, FloatArgumentPatternFactory>();
        services.AddSingleton<IDoubleArgumentPatternFactory, DoubleArgumentPatternFactory>();
        services.AddSingleton<IEnumArgumentPatternFactory, EnumArgumentPatternFactory>();

        services.AddSingleton<INonNullableStringArgumentPatternFactory, NonNullableStringArgumentPatternFactory>();
        services.AddSingleton<INullableStringArgumentPatternFactory, NullableStringArgumentPatternFactory>();
        services.AddSingleton<INonNullableObjectArgumentPatternFactory, NonNullableObjectArgumentPatternFactory>();
        services.AddSingleton<INullableObjectArgumentPatternFactory, NullableObjectArgumentPatternFactory>();
        services.AddSingleton<INonNullableTypeArgumentPatternFactory, NonNullableTypeArgumentPatternFactory>();
        services.AddSingleton<INullableTypeArgumentPatternFactory, NullableTypeArgumentPatternFactory>();
        services.AddSingleton<INonNullableArrayArgumentPatternFactory, NonNullableArrayArgumentPatternFactory>();
        services.AddSingleton<INullableArrayArgumentPatternFactory, NullableArrayArgumentPatternFactory>();

        return services;
    }
}
