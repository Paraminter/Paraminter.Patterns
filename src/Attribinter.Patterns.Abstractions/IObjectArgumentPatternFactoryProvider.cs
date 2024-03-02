namespace Attribinter.Patterns;

/// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="object"/> arguments.</summary>
public interface IObjectArgumentPatternFactoryProvider
{
    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="object"/> arguments.</summary>
    public abstract INonNullableObjectArgumentPatternFactory NonNullable { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="object"/> arguments.</summary>
    public abstract INullableObjectArgumentPatternFactory Nullable { get; }
}
