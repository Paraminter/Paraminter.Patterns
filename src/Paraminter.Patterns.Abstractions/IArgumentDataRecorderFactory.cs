namespace Paraminter.Patterns;

/// <summary>Handles creation of pattern-independent <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/> using pattern-dependent <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/>.</summary>
public interface IArgumentDataRecorderFactory
{
    /// <summary>Creates a pattern-independent <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/> using a pattern-dependent <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/>.</summary>
    /// <typeparam name="TParameter">The type representing the parameter.</typeparam>
    /// <typeparam name="TUnpatternedArgumentData">The type representing data about the arguments, before being matched to the pattern.</typeparam>
    /// <typeparam name="TPatternedArgumentData">The type representing data about the arguments, after being matched to the pattern.</typeparam>
    /// <param name="patternedRecorder">The pattern-dependent <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/>.</param>
    /// <param name="pattern">The pattern of the arguments handled by the pattern-dependent <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/>.</param>
    /// <returns>The created, pattern-independent, <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/>.</returns>
    public abstract IArgumentDataRecorder<TParameter, TUnpatternedArgumentData> Create<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>(IArgumentDataRecorder<TParameter, TPatternedArgumentData> patternedRecorder, IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData> pattern);
}
