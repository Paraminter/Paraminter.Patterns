namespace Attribinter.Patterns;

internal sealed class NullableArgumentPattern<T> : IArgumentPattern<T?>
{
    public static IArgumentPattern<T?> Instance { get; } = new NullableArgumentPattern<T>();

    private NullableArgumentPattern() { }

    ArgumentPatternMatchResult<T?> IArgumentPattern<T?>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return ArgumentPatternMatchResult.CreateSuccessful<T?>(default);
        }

        if (argument is not T tArgument)
        {
            return ArgumentPatternMatchResult.CreateUnsuccessful<T?>();
        }

        return ArgumentPatternMatchResult.CreateSuccessful<T?>(tArgument);
    }
}
