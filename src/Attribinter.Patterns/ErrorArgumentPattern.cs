namespace Attribinter.Patterns;

internal sealed class ErrorArgumentPattern<T> : IArgumentPattern<T>
{
    public static IArgumentPattern<T> Instance { get; } = new ErrorArgumentPattern<T>();

    private ErrorArgumentPattern() { }

    ArgumentPatternMatchResult<T> IArgumentPattern<T>.TryMatch(object? argument) => ArgumentPatternMatchResult.CreateUnsuccessful<T>();
}
