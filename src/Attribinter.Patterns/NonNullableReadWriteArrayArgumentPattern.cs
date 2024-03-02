namespace Attribinter.Patterns;

using System.Collections.Generic;

internal sealed class NonNullableReadWriteArrayArgumentPattern<TElement> : IArgumentPattern<IList<TElement>>
{
    private readonly IArgumentPattern<TElement> ElementPattern;

    public NonNullableReadWriteArrayArgumentPattern(IArgumentPattern<TElement> elementPattern)
    {
        ElementPattern = elementPattern;
    }

    ArgumentPatternMatchResult<IList<TElement>> IArgumentPattern<IList<TElement>>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return ArgumentPatternMatchResult.CreateUnsuccessful<IList<TElement>>();
        }

        if (argument is TElement[] elementArrayArgument)
        {
            return MatchElementArray(elementArrayArgument);
        }

        if (argument is object[] objectArrayArgument)
        {
            return MatchObjectArray(objectArrayArgument);
        }

        return ArgumentPatternMatchResult.CreateUnsuccessful<IList<TElement>>();
    }

    private ArgumentPatternMatchResult<IList<TElement>> MatchElementArray(IReadOnlyList<TElement> elementArrayArgument)
    {
        var convertedArguments = new TElement[elementArrayArgument.Count];

        for (var i = 0; i < convertedArguments.Length; i++)
        {
            var elementResult = ElementPattern.TryMatch(elementArrayArgument[i]);

            if (elementResult.Successful is false)
            {
                return ArgumentPatternMatchResult.CreateUnsuccessful<IList<TElement>>();
            }

            convertedArguments[i] = elementResult.GetMatchedArgument();
        }

        return ArgumentPatternMatchResult.CreateSuccessful<IList<TElement>>(convertedArguments);
    }

    private ArgumentPatternMatchResult<IList<TElement>> MatchObjectArray(IReadOnlyList<object> objectArrayArgument)
    {
        var convertedArguments = new TElement[objectArrayArgument.Count];

        for (var i = 0; i < convertedArguments.Length; i++)
        {
            var elementResult = ElementPattern.TryMatch(objectArrayArgument[i]);

            if (elementResult.Successful is false)
            {
                return ArgumentPatternMatchResult.CreateUnsuccessful<IList<TElement>>();
            }

            convertedArguments[i] = elementResult.GetMatchedArgument();
        }

        return ArgumentPatternMatchResult.CreateSuccessful<IList<TElement>>(convertedArguments);
    }
}
