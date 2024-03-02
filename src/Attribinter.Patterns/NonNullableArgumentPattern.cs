namespace Attribinter.Patterns;

internal sealed class NonNullableArgumentPattern<T> : IArgumentPattern<T>
{
    public static IArgumentPattern<T> Instance { get; } = new NonNullableArgumentPattern<T>();

    private NonNullableArgumentPattern() { }

    ArgumentPatternMatchResult<T> IArgumentPattern<T>.TryMatch(object? argument)
    {
        if (argument is not T tArgument)
        {
            return ArgumentPatternMatchResult.CreateUnsuccessful<T>();
        }

        return ArgumentPatternMatchResult.CreateSuccessful(tArgument);
    }
}
