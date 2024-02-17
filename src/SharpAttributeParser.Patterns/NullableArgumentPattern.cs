namespace SharpAttributeParser.Patterns;

internal sealed class NullableArgumentPattern<T> : IArgumentPattern<T?>
{
    public static IArgumentPattern<T?> Instance { get; } = new NullableArgumentPattern<T>();

    private NullableArgumentPattern() { }

    PatternMatchResult<T?> IArgumentPattern<T?>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return new(default);
        }

        if (argument is not T tArgument)
        {
            return new();
        }

        return new(tArgument);
    }
}
