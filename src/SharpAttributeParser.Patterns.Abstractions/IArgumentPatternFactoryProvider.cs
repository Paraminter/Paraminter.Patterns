namespace SharpAttributeParser.Patterns;

using Microsoft.CodeAnalysis;

/// <summary>Provides factories of <see cref="IArgumentPattern{T}"/>.</summary>
public interface IArgumentPatternFactoryProvider
{
    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="bool"/> arguments.</summary>
    public abstract IBoolArgumentPatternFactory Bool { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="byte"/> arguments.</summary>
    public abstract IByteArgumentPatternFactory Byte { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="sbyte"/> arguments.</summary>
    public abstract ISByteArgumentPatternFactory SByte { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="char"/> arguments.</summary>
    public abstract ICharArgumentPatternFactory Char { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="short"/> arguments.</summary>
    public abstract IShortArgumentPatternFactory Short { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="ushort"/> arguments.</summary>
    public abstract IUShortArgumentPatternFactory UShort { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="int"/> arguments.</summary>
    public abstract IIntArgumentPatternFactory Int { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="uint"/> arguments.</summary>
    public abstract IUIntArgumentPatternFactory UInt { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="long"/> arguments.</summary>
    public abstract ILongArgumentPatternFactory Long { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="ulong"/> arguments.</summary>
    public abstract IULongArgumentPatternFactory ULong { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="float"/> arguments.</summary>
    public abstract IFloatArgumentPatternFactory Float { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="double"/> arguments.</summary>
    public abstract IDoubleArgumentPatternFactory Double { get; }

    /// <summary>The factory of <see cref="IArgumentPattern{T}"/> matching enum arguments.</summary>
    public abstract IEnumArgumentPatternFactory Enum { get; }

    /// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="string"/> arguments.</summary>
    public abstract IStringArgumentPatternFactoryProvider String { get; }

    /// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="object"/> arguments.</summary>
    public abstract IObjectArgumentPatternFactoryProvider Object { get; }

    /// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="ITypeSymbol"/> arguments.</summary>
    /// <remarks>Attribute arguments of type <see cref="System.Type"/> will match the patterns created by these factories, as Roslyn uses <see cref="ITypeSymbol"/> to represent <see cref="System.Type"/>.</remarks>
    public abstract ITypeArgumentPatternFactoryProvider Type { get; }

    /// <summary>Provides factories of <see cref="IArgumentPattern{T}"/> matching array-valued arguments.</summary>
    public abstract IArrayArgumentPatternFactoryProvider Array { get; }
}
