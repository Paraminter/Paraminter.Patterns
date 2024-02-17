namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="IArgumentPatternFactoryProvider"/>
public sealed class ArgumentPatternFactoryProvider : IArgumentPatternFactoryProvider
{
    private readonly IBoolArgumentPatternFactory Bool;
    private readonly IByteArgumentPatternFactory Byte;
    private readonly ISByteArgumentPatternFactory SByte;
    private readonly ICharArgumentPatternFactory Char;
    private readonly IShortArgumentPatternFactory Short;
    private readonly IUShortArgumentPatternFactory UShort;
    private readonly IIntArgumentPatternFactory Int;
    private readonly IUIntArgumentPatternFactory UInt;
    private readonly ILongArgumentPatternFactory Long;
    private readonly IULongArgumentPatternFactory ULong;
    private readonly IFloatArgumentPatternFactory Float;
    private readonly IDoubleArgumentPatternFactory Double;
    private readonly IEnumArgumentPatternFactory Enum;

    private readonly IStringArgumentPatternFactoryProvider StringFactoryProvider;
    private readonly IObjectArgumentPatternFactoryProvider ObjectFactoryProvider;
    private readonly ITypeArgumentPatternFactoryProvider TypeFactoryProvider;
    private readonly IArrayArgumentPatternFactoryProvider ArrayFactoryProvider;

    /// <summary>Instantiates a <see cref="ArgumentPatternFactoryProvider"/>, providing factories of <see cref="IArgumentPattern{T}"/>.</summary>
    /// <param name="boolArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="bool"/> arguments.</param>
    /// <param name="byteArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="byte"/> arguments.</param>
    /// <param name="sbyteArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="sbyte"/> arguments.</param>
    /// <param name="charArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="char"/> arguments.</param>
    /// <param name="shortArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="short"/> arguments.</param>
    /// <param name="ushortArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="ushort"/> arguments.</param>
    /// <param name="intArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="int"/> arguments.</param>
    /// <param name="uintArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="uint"/> arguments.</param>
    /// <param name="longArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="long"/> arguments.</param>
    /// <param name="ulongArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="ulong"/> arguments.</param>
    /// <param name="floatArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="float"/> arguments.</param>
    /// <param name="doubleArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching <see cref="double"/> arguments.</param>
    /// <param name="enumArgumentPatternFactory">The factory of <see cref="IArgumentPattern{T}"/> matching enum arguments.</param>
    /// <param name="stringFactoryProvider">Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="string"/> arguments.</param>
    /// <param name="objectFactoryProvider">Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="object"/> arguments.</param>
    /// <param name="typeFactoryProvider">Provides factories of <see cref="IArgumentPattern{T}"/> matching <see cref="Type"/> arguments.</param>
    /// <param name="arrayFactoryProvider">Provides factories of <see cref="IArgumentPattern{T}"/> matching array-valued arguments.</param>
    public ArgumentPatternFactoryProvider(IBoolArgumentPatternFactory boolArgumentPatternFactory, IByteArgumentPatternFactory byteArgumentPatternFactory, ISByteArgumentPatternFactory sbyteArgumentPatternFactory,
        ICharArgumentPatternFactory charArgumentPatternFactory, IShortArgumentPatternFactory shortArgumentPatternFactory, IUShortArgumentPatternFactory ushortArgumentPatternFactory, IIntArgumentPatternFactory intArgumentPatternFactory,
        IUIntArgumentPatternFactory uintArgumentPatternFactory, ILongArgumentPatternFactory longArgumentPatternFactory, IULongArgumentPatternFactory ulongArgumentPatternFactory, IFloatArgumentPatternFactory floatArgumentPatternFactory,
        IDoubleArgumentPatternFactory doubleArgumentPatternFactory, IEnumArgumentPatternFactory enumArgumentPatternFactory, IStringArgumentPatternFactoryProvider stringFactoryProvider, IObjectArgumentPatternFactoryProvider objectFactoryProvider,
        ITypeArgumentPatternFactoryProvider typeFactoryProvider, IArrayArgumentPatternFactoryProvider arrayFactoryProvider)
    {
        Bool = boolArgumentPatternFactory ?? throw new ArgumentNullException(nameof(boolArgumentPatternFactory));
        Byte = byteArgumentPatternFactory ?? throw new ArgumentNullException(nameof(byteArgumentPatternFactory));
        SByte = sbyteArgumentPatternFactory ?? throw new ArgumentNullException(nameof(sbyteArgumentPatternFactory));
        Char = charArgumentPatternFactory ?? throw new ArgumentNullException(nameof(charArgumentPatternFactory));
        Short = shortArgumentPatternFactory ?? throw new ArgumentNullException(nameof(shortArgumentPatternFactory));
        UShort = ushortArgumentPatternFactory ?? throw new ArgumentNullException(nameof(ushortArgumentPatternFactory));
        Int = intArgumentPatternFactory ?? throw new ArgumentNullException(nameof(intArgumentPatternFactory));
        UInt = uintArgumentPatternFactory ?? throw new ArgumentNullException(nameof(uintArgumentPatternFactory));
        Long = longArgumentPatternFactory ?? throw new ArgumentNullException(nameof(longArgumentPatternFactory));
        ULong = ulongArgumentPatternFactory ?? throw new ArgumentNullException(nameof(ulongArgumentPatternFactory));
        Float = floatArgumentPatternFactory ?? throw new ArgumentNullException(nameof(floatArgumentPatternFactory));
        Double = doubleArgumentPatternFactory ?? throw new ArgumentNullException(nameof(doubleArgumentPatternFactory));
        Enum = enumArgumentPatternFactory ?? throw new ArgumentNullException(nameof(enumArgumentPatternFactory));
        StringFactoryProvider = stringFactoryProvider ?? throw new ArgumentNullException(nameof(stringFactoryProvider));
        ObjectFactoryProvider = objectFactoryProvider ?? throw new ArgumentNullException(nameof(objectFactoryProvider));
        TypeFactoryProvider = typeFactoryProvider ?? throw new ArgumentNullException(nameof(typeFactoryProvider));
        ArrayFactoryProvider = arrayFactoryProvider ?? throw new ArgumentNullException(nameof(arrayFactoryProvider));
    }

    IBoolArgumentPatternFactory IArgumentPatternFactoryProvider.Bool => Bool;
    IByteArgumentPatternFactory IArgumentPatternFactoryProvider.Byte => Byte;
    ISByteArgumentPatternFactory IArgumentPatternFactoryProvider.SByte => SByte;
    ICharArgumentPatternFactory IArgumentPatternFactoryProvider.Char => Char;
    IShortArgumentPatternFactory IArgumentPatternFactoryProvider.Short => Short;
    IUShortArgumentPatternFactory IArgumentPatternFactoryProvider.UShort => UShort;
    IIntArgumentPatternFactory IArgumentPatternFactoryProvider.Int => Int;
    IUIntArgumentPatternFactory IArgumentPatternFactoryProvider.UInt => UInt;
    ILongArgumentPatternFactory IArgumentPatternFactoryProvider.Long => Long;
    IULongArgumentPatternFactory IArgumentPatternFactoryProvider.ULong => ULong;
    IFloatArgumentPatternFactory IArgumentPatternFactoryProvider.Float => Float;
    IDoubleArgumentPatternFactory IArgumentPatternFactoryProvider.Double => Double;

    IEnumArgumentPatternFactory IArgumentPatternFactoryProvider.Enum => Enum;

    IStringArgumentPatternFactoryProvider IArgumentPatternFactoryProvider.String => StringFactoryProvider;
    IObjectArgumentPatternFactoryProvider IArgumentPatternFactoryProvider.Object => ObjectFactoryProvider;
    ITypeArgumentPatternFactoryProvider IArgumentPatternFactoryProvider.Type => TypeFactoryProvider;
    IArrayArgumentPatternFactoryProvider IArgumentPatternFactoryProvider.Array => ArrayFactoryProvider;
}
