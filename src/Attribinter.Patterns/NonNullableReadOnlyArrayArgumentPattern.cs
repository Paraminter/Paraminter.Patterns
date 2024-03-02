namespace Attribinter.Patterns;

using System.Collections.Generic;

internal sealed class NonNullableReadOnlyArrayArgumentPattern<TElement> : IArgumentPattern<IReadOnlyList<TElement>>
{
    private readonly IArgumentPattern<TElement> ElementPattern;

    public NonNullableReadOnlyArrayArgumentPattern(IArgumentPattern<TElement> elementPattern)
    {
        ElementPattern = elementPattern;
    }

    ArgumentPatternMatchResult<IReadOnlyList<TElement>> IArgumentPattern<IReadOnlyList<TElement>>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return ArgumentPatternMatchResult.CreateUnsuccessful<IReadOnlyList<TElement>>();
        }

        if (argument is TElement[] elementArrayArgument)
        {
            return MatchElementArray(elementArrayArgument);
        }

        if (argument is object[] objectArrayArgument)
        {
            return MatchObjectArray(objectArrayArgument);
        }

        return ArgumentPatternMatchResult.CreateUnsuccessful<IReadOnlyList<TElement>>();
    }

    private ArgumentPatternMatchResult<IReadOnlyList<TElement>> MatchElementArray(IReadOnlyList<TElement> elementArrayArgument)
    {
        var convertedArguments = new TElement[elementArrayArgument.Count];

        for (var i = 0; i < convertedArguments.Length; i++)
        {
            var elementResult = ElementPattern.TryMatch(elementArrayArgument[i]);

            if (elementResult.Successful is false)
            {
                return ArgumentPatternMatchResult.CreateUnsuccessful<IReadOnlyList<TElement>>();
            }

            convertedArguments[i] = elementResult.GetMatchedArgument();
        }

        return ArgumentPatternMatchResult.CreateSuccessful<IReadOnlyList<TElement>>(convertedArguments);
    }

    private ArgumentPatternMatchResult<IReadOnlyList<TElement>> MatchObjectArray(IReadOnlyList<object> objectArrayArgument)
    {
        var convertedArguments = new TElement[objectArrayArgument.Count];

        for (var i = 0; i < convertedArguments.Length; i++)
        {
            var elementResult = ElementPattern.TryMatch(objectArrayArgument[i]);

            if (elementResult.Successful is false)
            {
                return ArgumentPatternMatchResult.CreateUnsuccessful<IReadOnlyList<TElement>>();
            }

            convertedArguments[i] = elementResult.GetMatchedArgument();
        }

        return ArgumentPatternMatchResult.CreateSuccessful<IReadOnlyList<TElement>>(convertedArguments);
    }
}
