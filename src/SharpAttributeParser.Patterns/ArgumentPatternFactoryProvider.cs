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

    private readonly INonNullableStringArgumentPatternFactory NonNullableString;
    private readonly INullableStringArgumentPatternFactory NullableString;
    private readonly INonNullableObjectArgumentPatternFactory NonNullableObject;
    private readonly INullableObjectArgumentPatternFactory NullableObject;
    private readonly INonNullableTypeArgumentPatternFactory NonNullableType;
    private readonly INullableTypeArgumentPatternFactory NullableType;
    private readonly INonNullableArrayArgumentPatternFactory NonNullableArray;
    private readonly INullableArrayArgumentPatternFactory NullableArray;

    /// <summary>Instantiates a <see cref="ArgumentPatternFactoryProvider"/>, handling creation of <see cref="IArgumentPattern{T}"/>.</summary>
    /// <param name="boolArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="bool"/> arguments.</param>
    /// <param name="byteArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="byte"/> arguments.</param>
    /// <param name="sbyteArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="sbyte"/> arguments.</param>
    /// <param name="charArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="char"/> arguments.</param>
    /// <param name="shortArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="short"/> arguments.</param>
    /// <param name="ushortArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="ushort"/> arguments.</param>
    /// <param name="intArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="int"/> arguments.</param>
    /// <param name="uintArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="uint"/> arguments.</param>
    /// <param name="longArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="long"/> arguments.</param>
    /// <param name="ulongArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="ulong"/> arguments.</param>
    /// <param name="floatArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="float"/> arguments.</param>
    /// <param name="doubleArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching <see cref="double"/> arguments.</param>
    /// <param name="enumArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching enum arguments.</param>
    /// <param name="nonNullableStringArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="string"/> arguments.</param>
    /// <param name="nullableStringArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="string"/> arguments.</param>
    /// <param name="nonNullableObjectArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="object"/> arguments.</param>
    /// <param name="nullableObjectArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="object"/> arguments.</param>
    /// <param name="nonNullableTypeArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable <see cref="Type"/> arguments.</param>
    /// <param name="nullableTypeArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable <see cref="Type"/> arguments.</param>
    /// <param name="nonNullableArrayArgumentPatternFactory">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</param>
    /// <param name="nullableArrayArgumentPattern">The factory handling creation of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</param>
    public ArgumentPatternFactoryProvider(IBoolArgumentPatternFactory boolArgumentPatternFactory, IByteArgumentPatternFactory byteArgumentPatternFactory, ISByteArgumentPatternFactory sbyteArgumentPatternFactory,
        ICharArgumentPatternFactory charArgumentPatternFactory, IShortArgumentPatternFactory shortArgumentPatternFactory, IUShortArgumentPatternFactory ushortArgumentPatternFactory, IIntArgumentPatternFactory intArgumentPatternFactory,
        IUIntArgumentPatternFactory uintArgumentPatternFactory, ILongArgumentPatternFactory longArgumentPatternFactory, IULongArgumentPatternFactory ulongArgumentPatternFactory, IFloatArgumentPatternFactory floatArgumentPatternFactory,
        IDoubleArgumentPatternFactory doubleArgumentPatternFactory, IEnumArgumentPatternFactory enumArgumentPatternFactory, INonNullableStringArgumentPatternFactory nonNullableStringArgumentPatternFactory,
        INullableStringArgumentPatternFactory nullableStringArgumentPatternFactory, INonNullableObjectArgumentPatternFactory nonNullableObjectArgumentPatternFactory, INullableObjectArgumentPatternFactory nullableObjectArgumentPatternFactory,
        INonNullableTypeArgumentPatternFactory nonNullableTypeArgumentPatternFactory, INullableTypeArgumentPatternFactory nullableTypeArgumentPatternFactory, INonNullableArrayArgumentPatternFactory nonNullableArrayArgumentPatternFactory,
        INullableArrayArgumentPatternFactory nullableArrayArgumentPattern)
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

        NonNullableString = nonNullableStringArgumentPatternFactory ?? throw new ArgumentNullException(nameof(nonNullableStringArgumentPatternFactory));
        NullableString = nullableStringArgumentPatternFactory ?? throw new ArgumentNullException(nameof(nullableStringArgumentPatternFactory));
        NonNullableObject = nonNullableObjectArgumentPatternFactory ?? throw new ArgumentNullException(nameof(nonNullableObjectArgumentPatternFactory));
        NullableObject = nullableObjectArgumentPatternFactory ?? throw new ArgumentNullException(nameof(nullableObjectArgumentPatternFactory));
        NonNullableType = nonNullableTypeArgumentPatternFactory ?? throw new ArgumentNullException(nameof(nonNullableTypeArgumentPatternFactory));
        NullableType = nullableTypeArgumentPatternFactory ?? throw new ArgumentNullException(nameof(nullableTypeArgumentPatternFactory));
        NonNullableArray = nonNullableArrayArgumentPatternFactory ?? throw new ArgumentNullException(nameof(nonNullableArrayArgumentPatternFactory));
        NullableArray = nullableArrayArgumentPattern ?? throw new ArgumentNullException(nameof(nullableArrayArgumentPattern));
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

    INonNullableStringArgumentPatternFactory IArgumentPatternFactoryProvider.NonNullableString => NonNullableString;
    INullableStringArgumentPatternFactory IArgumentPatternFactoryProvider.NullableString => NullableString;
    INonNullableObjectArgumentPatternFactory IArgumentPatternFactoryProvider.NonNullableObject => NonNullableObject;
    INullableObjectArgumentPatternFactory IArgumentPatternFactoryProvider.NullableObject => NullableObject;
    INonNullableTypeArgumentPatternFactory IArgumentPatternFactoryProvider.NonNullableType => NonNullableType;
    INullableTypeArgumentPatternFactory IArgumentPatternFactoryProvider.NullableType => NullableType;

    INonNullableArrayArgumentPatternFactory IArgumentPatternFactoryProvider.NonNullableArray => NonNullableArray;
    INullableArrayArgumentPatternFactory IArgumentPatternFactoryProvider.NullableArray => NullableArray;
}
