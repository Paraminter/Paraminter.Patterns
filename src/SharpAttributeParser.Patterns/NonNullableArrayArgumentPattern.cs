namespace SharpAttributeParser.Patterns;

using OneOf;
using OneOf.Types;

using System.Collections.Generic;

internal sealed class NonNullableArrayArgumentPattern<TElement> : IArgumentPattern<TElement[]>
{
    private readonly IArgumentPattern<TElement> ElementPattern;

    public NonNullableArrayArgumentPattern(IArgumentPattern<TElement> elementPattern)
    {
        ElementPattern = elementPattern;
    }

    OneOf<Error, TElement[]> IArgumentPattern<TElement[]>.TryMatch(object? argument)
    {
        if (argument is null)
        {
            return new Error();
        }

        if (argument is TElement[] elementArrayArgument)
        {
            return MatchElementArray(elementArrayArgument);
        }

        if (argument is object[] objectArrayArgument)
        {
            return MatchObjectArray(objectArrayArgument);
        }

        return new Error();
    }

    private OneOf<Error, TElement[]> MatchElementArray(IReadOnlyList<TElement> elementArrayArgument)
    {
        var convertedArguments = new TElement[elementArrayArgument.Count];

        for (var i = 0; i < convertedArguments.Length; i++)
        {
            var convertedArgument = ElementPattern.TryMatch(elementArrayArgument[i]);

            if (convertedArgument.IsT0)
            {
                return new Error();
            }

            convertedArguments[i] = convertedArgument.AsT1;
        }

        return convertedArguments;
    }

    private OneOf<Error, TElement[]> MatchObjectArray(IReadOnlyList<object> objectArrayArgument)
    {
        var convertedArguments = new TElement[objectArrayArgument.Count];

        for (var i = 0; i < convertedArguments.Length; i++)
        {
            var convertedArgument = ElementPattern.TryMatch(objectArrayArgument[i]);

            if (convertedArgument.IsT0)
            {
                return new Error();
            }

            convertedArguments[i] = convertedArgument.AsT1;
        }

        return convertedArguments;
    }
}
