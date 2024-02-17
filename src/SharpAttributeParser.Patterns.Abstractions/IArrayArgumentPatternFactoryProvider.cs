namespace SharpAttributeParser.Patterns;

/// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching array-valued arguments.</summary>
public interface IArrayArgumentPatternFactoryProvider
{
    /// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</summary>
    public abstract INonNullableArrayArgumentPatternFactoryProvider NonNullable { get; }

    /// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</summary>
    public abstract INullableArrayArgumentPatternFactoryProvider Nullable { get; }
}
