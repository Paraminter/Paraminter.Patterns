namespace Attribinter.Patterns;

using System;

/// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="Type"/> arguments.</summary>
public interface ITypeArgumentPatternFactoryProvider
{
    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="Type"/> arguments.</summary>
    public abstract INonNullableTypeArgumentPatternFactory NonNullable { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="Type"/> arguments.</summary>
    public abstract INullableTypeArgumentPatternFactory Nullable { get; }
}
