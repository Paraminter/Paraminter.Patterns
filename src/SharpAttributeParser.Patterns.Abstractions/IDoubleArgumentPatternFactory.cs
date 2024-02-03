namespace SharpAttributeParser.Patterns;

/// <summary>Handles creation of <see cref="IArgumentPattern{T}"/> matching <see cref="double"/> arguments.</summary>
public interface IDoubleArgumentPatternFactory
{
    /// <summary>Creates a pattern which ensures that arguments are of type <see cref="double"/>.</summary>
    /// <returns>The created pattern.</returns>
    public abstract IArgumentPattern<double> Create();
}
