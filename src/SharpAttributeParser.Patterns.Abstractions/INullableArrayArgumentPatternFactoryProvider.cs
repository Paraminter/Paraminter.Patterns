namespace SharpAttributeParser.Patterns;

/// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</summary>
public interface INullableArrayArgumentPatternFactoryProvider
{
    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</summary>
    public abstract INullableReadWriteArrayArgumentPatternFactory ReadWrite { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching nullable read-only array-valued arguments.</summary>
    public abstract INullableReadOnlyArrayArgumentPatternFactory ReadOnly { get; }
}
