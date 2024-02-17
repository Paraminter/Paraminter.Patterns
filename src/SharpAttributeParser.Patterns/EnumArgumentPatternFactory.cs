namespace SharpAttributeParser.Patterns;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="IEnumArgumentPatternFactory"/>
public sealed class EnumArgumentPatternFactory : IEnumArgumentPatternFactory
{
    private static readonly IReadOnlyDictionary<Type, Func<Type, object?, PatternMatchResult<object>>> PatternDelegates = new Dictionary<Type, Func<Type, object?, PatternMatchResult<object>>>()
    {
        { typeof(byte), CreateNonGenericPatternDelegate<byte>(static (enumType, value) => Enum.ToObject(enumType, value)) },
        { typeof(sbyte), CreateNonGenericPatternDelegate<sbyte>(static (enumType, value) => Enum.ToObject(enumType, value)) },
        { typeof(short), CreateNonGenericPatternDelegate<short>(static (enumType, value) => Enum.ToObject(enumType, value)) },
        { typeof(ushort), CreateNonGenericPatternDelegate<ushort>(static (enumType, value) => Enum.ToObject(enumType, value)) },
        { typeof(int), CreateNonGenericPatternDelegate<int>(static (enumType, value) => Enum.ToObject(enumType, value)) },
        { typeof(uint), CreateNonGenericPatternDelegate<uint>(static (enumType, value) => Enum.ToObject(enumType, value)) },
        { typeof(long), CreateNonGenericPatternDelegate<long>(static (enumType, value) => Enum.ToObject(enumType, value)) },
        { typeof(ulong), CreateNonGenericPatternDelegate<ulong>(static (enumType, value) => Enum.ToObject(enumType, value)) }
    };

    /// <summary>Instantiates a <see cref="EnumArgumentPatternFactory"/>, handling creation of <see cref="IArgumentPattern{T}"/> matching enum arguments.</summary>
    public EnumArgumentPatternFactory() { }

    IArgumentPattern<TEnum> IEnumArgumentPatternFactory.Create<TEnum>()
    {
        if (PatternDelegates.TryGetValue(typeof(TEnum).GetEnumUnderlyingType(), out var patternDelegate) is false)
        {
            return ErrorArgumentPattern<TEnum>.Instance;
        }

        return new DelegatedArgumentPattern<TEnum>(CreateGenericPatternDelegate<TEnum>(patternDelegate));
    }

    private static Func<Type, object?, PatternMatchResult<object>> CreateNonGenericPatternDelegate<TUnderlying>(Func<Type, TUnderlying, object> factoryDelegate)
    {
        return pattern;

        PatternMatchResult<object> pattern(Type enumType, object? argument)
        {
            if (argument is not TUnderlying matchingArgument)
            {
                return new();
            }

            return new(factoryDelegate(enumType, matchingArgument));
        }
    }

    private static Func<object?, PatternMatchResult<TEnum>> CreateGenericPatternDelegate<TEnum>(Func<Type, object?, PatternMatchResult<object>> nonGenericPatternDelegate)
    {
        return pattern;

        PatternMatchResult<TEnum> pattern(object? argument)
        {
            if (argument is TEnum enumArgument)
            {
                return new(enumArgument);
            }

            var nonGenericResult = nonGenericPatternDelegate(typeof(TEnum), argument);

            if (nonGenericResult.WasSuccessful is false)
            {
                return new();
            }

            return new((TEnum)nonGenericResult.GetMatchedArgument());
        }
    }
}
