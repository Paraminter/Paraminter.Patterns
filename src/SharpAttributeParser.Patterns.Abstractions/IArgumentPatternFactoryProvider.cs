namespace SharpAttributeParser.Patterns;

using Microsoft.CodeAnalysis;

using System;

/// <summary>Provides <see cref="IArgumentPattern{T}"/> factories.</summary>
public interface IArgumentPatternFactoryProvider
{
    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="bool"/> arguments.</summary>
    public abstract IBoolArgumentPatternFactory Bool { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="byte"/> arguments.</summary>
    public abstract IByteArgumentPatternFactory Byte { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="sbyte"/> arguments.</summary>
    public abstract ISByteArgumentPatternFactory SByte { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="char"/> arguments.</summary>
    public abstract ICharArgumentPatternFactory Char { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="short"/> arguments.</summary>
    public abstract IShortArgumentPatternFactory Short { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="ushort"/> arguments.</summary>
    public abstract IUShortArgumentPatternFactory UShort { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="int"/> arguments.</summary>
    public abstract IIntArgumentPatternFactory Int { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="uint"/> arguments.</summary>
    public abstract IUIntArgumentPatternFactory UInt { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="long"/> arguments.</summary>
    public abstract ILongArgumentPatternFactory Long { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="ulong"/> arguments.</summary>
    public abstract IULongArgumentPatternFactory ULong { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="float"/> arguments.</summary>
    public abstract IFloatArgumentPatternFactory Float { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="double"/> arguments.</summary>
    public abstract IDoubleArgumentPatternFactory Double { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching enum arguments.</summary>
    public abstract IEnumArgumentPatternFactory Enum { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="string"/> arguments.</summary>
    public abstract INonNullableStringArgumentPatternFactory NonNullableString { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="string"/> arguments.</summary>
    public abstract INullableStringArgumentPatternFactory NullableString { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="object"/> arguments.</summary>
    public abstract INonNullableObjectArgumentPatternFactory NonNullableObject { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="object"/> arguments.</summary>
    public abstract INullableObjectArgumentPatternFactory NullableObject { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="ITypeSymbol"/> arguments.</summary>
    /// <remarks>Attribute arguments of type <see cref="Type"/> will match the patterns created by this factory, as Roslyn uses <see cref="ITypeSymbol"/> to represent <see cref="Type"/>.</remarks>
    public abstract INonNullableTypeArgumentPatternFactory NonNullableType { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="ITypeSymbol"/> arguments.</summary>
    /// <remarks>Attribute arguments of type <see cref="Type"/> will match the patterns created by this factory, as Roslyn uses <see cref="ITypeSymbol"/> to represent <see cref="Type"/>.</remarks>
    public abstract INullableTypeArgumentPatternFactory NullableType { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</summary>
    public abstract INonNullableArrayArgumentPatternFactory NonNullableArray { get; }

    /// <summary>The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</summary>
    public abstract INullableArrayArgumentPatternFactory NullableArray { get; }
}
