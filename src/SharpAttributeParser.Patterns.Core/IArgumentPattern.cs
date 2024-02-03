namespace SharpAttributeParser.Patterns;

using OneOf;
using OneOf.Types;

/// <summary>Represents a pattern used to match attribute arguments.</summary>
/// <typeparam name="T">The type of the attribute arguments matched by the pattern.</typeparam>
public interface IArgumentPattern<T>
{
    /// <summary>Attempts to match the provided <see cref="object"/> to the pattern.</summary>
    /// <param name="argument">The <see cref="object"/> that is matched to the pattern.</param>
    /// <returns>The provided argument, matched to the pattern - or <see cref="Error"/> if the attempt was unsuccessful.</returns>
    public abstract OneOf<Error, T> TryMatch(object? argument);
}
