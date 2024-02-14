namespace SharpAttributeParser.Patterns;

/// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching array-valued arguments.</summary>
public interface IArrayArgumentPatternFactoryProvider
{
    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</summary>
    public abstract INonNullableArrayArgumentPatternFactory NonNullable { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</summary>
    public abstract INullableArrayArgumentPatternFactory Nullable { get; }
}
