namespace SharpAttributeParser.Patterns;

internal sealed class ErrorArgumentPattern<T> : IArgumentPattern<T>
{
    public static IArgumentPattern<T> Instance { get; } = new ErrorArgumentPattern<T>();

    private ErrorArgumentPattern() { }

    PatternMatchResult<T> IArgumentPattern<T>.TryMatch(object? argument) => new();
}
