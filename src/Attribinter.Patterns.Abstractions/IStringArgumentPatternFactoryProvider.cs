namespace Attribinter.Patterns;

/// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="string"/> arguments.</summary>
public interface IStringArgumentPatternFactoryProvider
{
    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="string"/> arguments.</summary>
    public abstract INonNullableStringArgumentPatternFactory NonNullable { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="string"/> arguments.</summary>
    public abstract INullableStringArgumentPatternFactory Nullable { get; }
}
