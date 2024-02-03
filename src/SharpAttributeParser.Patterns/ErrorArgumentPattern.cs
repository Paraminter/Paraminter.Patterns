namespace SharpAttributeParser.Patterns;

using OneOf;
using OneOf.Types;

internal sealed class ErrorArgumentPattern<T> : IArgumentPattern<T>
{
    public static IArgumentPattern<T> Instance { get; } = new ErrorArgumentPattern<T>();

    private ErrorArgumentPattern() { }

    OneOf<Error, T> IArgumentPattern<T>.TryMatch(object? argument) => new Error();
}
