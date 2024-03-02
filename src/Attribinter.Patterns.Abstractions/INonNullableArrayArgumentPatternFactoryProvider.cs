namespace Attribinter.Patterns;

/// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</summary>
public interface INonNullableArrayArgumentPatternFactoryProvider
{
    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</summary>
    public abstract INonNullableReadWriteArrayArgumentPatternFactory ReadWrite { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable read-only array-valued arguments.</summary>
    public abstract INonNullableReadOnlyArrayArgumentPatternFactory ReadOnly { get; }
}
