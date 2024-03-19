namespace Attribinter.Patterns;

/// <summary>Handles creation of pattern-independent <see cref="IArgumentRecorder{TParameter, TData}"/> using pattern-dependent ones.</summary>
public interface IArgumentRecorderFactory
{
    /// <summary>Creates a pattern-independent <see cref="IArgumentRecorder{TParameter, TData}"/> using a pattern-dependent one.</summary>
    /// <typeparam name="TParameter">The type representing the parameter.</typeparam>
    /// <typeparam name="TIn">The pattern-independent type of the recorded data.</typeparam>
    /// <typeparam name="TOut">The pattern-dependent type of the recorded data.</typeparam>
    /// <param name="patternedRecorder">The pattern-dependent <see cref="IArgumentRecorder{TParameter, TData}"/>.</param>
    /// <param name="pattern">The pattern of the arguments handled by the patterned <see cref="IArgumentRecorder{TParameter, TData}"/>.</param>
    /// <returns>The created, pattern-independent, <see cref="IArgumentRecorder{TParameter, TData}"/>.</returns>
    public abstract IArgumentRecorder<TParameter, TIn> Create<TParameter, TIn, TOut>(IArgumentRecorder<TParameter, TOut> patternedRecorder, IArgumentPattern<TIn, TOut> pattern);
}
