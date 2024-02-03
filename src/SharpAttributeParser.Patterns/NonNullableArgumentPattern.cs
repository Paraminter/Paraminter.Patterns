namespace SharpAttributeParser.Patterns;

using OneOf;
using OneOf.Types;

internal sealed class NonNullableArgumentPattern<T> : IArgumentPattern<T>
{
    public static IArgumentPattern<T> Instance { get; } = new NonNullableArgumentPattern<T>();

    private NonNullableArgumentPattern() { }

    OneOf<Error, T> IArgumentPattern<T>.TryMatch(object? argument)
    {
        if (argument is not T tArgument)
        {
            return new Error();
        }

        return tArgument;
    }
}
