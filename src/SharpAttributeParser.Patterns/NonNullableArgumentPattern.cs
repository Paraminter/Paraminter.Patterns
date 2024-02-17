namespace SharpAttributeParser.Patterns;

internal sealed class NonNullableArgumentPattern<T> : IArgumentPattern<T>
{
    public static IArgumentPattern<T> Instance { get; } = new NonNullableArgumentPattern<T>();

    private NonNullableArgumentPattern() { }

    PatternMatchResult<T> IArgumentPattern<T>.TryMatch(object? argument)
    {
        if (argument is not T tArgument)
        {
            return new();
        }

        return new(tArgument);
    }
}
