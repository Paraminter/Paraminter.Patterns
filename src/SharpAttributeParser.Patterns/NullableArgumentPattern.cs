namespace SharpAttributeParser.Patterns;

using OneOf;
using OneOf.Types;

internal sealed class NullableArgumentPattern<T> : IArgumentPattern<T?>
{
    public static IArgumentPattern<T?> Instance { get; } = new NullableArgumentPattern<T>();

    private NullableArgumentPattern() { }

    OneOf<Error, T?> IArgumentPattern<T?>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return OneOf<Error, T?>.FromT1(default);
        }

        if (argument is not T tArgument)
        {
            return new Error();
        }

        return tArgument;
    }
}
