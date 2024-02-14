namespace SharpAttributeParser.Patterns.ArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var boolArgumentPatternFactory = Mock.Of<IBoolArgumentPatternFactory>();
        var byteArgumentPatternFactory = Mock.Of<IByteArgumentPatternFactory>();
        var sbyteArgumentPatternFactory = Mock.Of<ISByteArgumentPatternFactory>();
        var charArgumentPatternFactory = Mock.Of<ICharArgumentPatternFactory>();
        var shortArgumentPatternFactory = Mock.Of<IShortArgumentPatternFactory>();
        var ushortArgumentPatternFactory = Mock.Of<IUShortArgumentPatternFactory>();
        var intArgumentPatternFactory = Mock.Of<IIntArgumentPatternFactory>();
        var uintArgumentPatternFactory = Mock.Of<IUIntArgumentPatternFactory>();
        var longArgumentPatternFactory = Mock.Of<ILongArgumentPatternFactory>();
        var ulongArgumentPatternFactory = Mock.Of<IULongArgumentPatternFactory>();
        var floatArgumentPatternFactory = Mock.Of<IFloatArgumentPatternFactory>();
        var doubleArgumentPatternFactory = Mock.Of<IDoubleArgumentPatternFactory>();
        var enumArgumentPatternFactory = Mock.Of<IEnumArgumentPatternFactory>();

        var nonNullableStringArgumentPatternFactory = Mock.Of<INonNullableStringArgumentPatternFactory>();
        var nullableStringArgumentPatternFactory = Mock.Of<INullableStringArgumentPatternFactory>();
        var nonNullableObjectArgumentPatternFactory = Mock.Of<INonNullableObjectArgumentPatternFactory>();
        var nullableObjectArgumentPatternFactory = Mock.Of<INullableObjectArgumentPatternFactory>();
        var nonNullableTypeArgumentPatternFactory = Mock.Of<INonNullableTypeArgumentPatternFactory>();
        var nullableTypeArgumentPatternFactory = Mock.Of<INullableTypeArgumentPatternFactory>();
        var nonNullableArrayArgumentPatternFactory = Mock.Of<INonNullableArrayArgumentPatternFactory>();
        var nullableArrayArgumentPatternFactory = Mock.Of<INullableArrayArgumentPatternFactory>();

        ArgumentPatternFactoryProvider provider = new(boolArgumentPatternFactory, byteArgumentPatternFactory, sbyteArgumentPatternFactory, charArgumentPatternFactory, shortArgumentPatternFactory,
            ushortArgumentPatternFactory, intArgumentPatternFactory, uintArgumentPatternFactory, longArgumentPatternFactory, ulongArgumentPatternFactory, floatArgumentPatternFactory, doubleArgumentPatternFactory,
            enumArgumentPatternFactory, nonNullableStringArgumentPatternFactory, nullableStringArgumentPatternFactory, nonNullableObjectArgumentPatternFactory, nullableObjectArgumentPatternFactory,
            nonNullableTypeArgumentPatternFactory, nullableTypeArgumentPatternFactory, nonNullableArrayArgumentPatternFactory, nullableArrayArgumentPatternFactory);

        return new(provider, boolArgumentPatternFactory, byteArgumentPatternFactory, sbyteArgumentPatternFactory, charArgumentPatternFactory, shortArgumentPatternFactory,
            ushortArgumentPatternFactory, intArgumentPatternFactory, uintArgumentPatternFactory, longArgumentPatternFactory, ulongArgumentPatternFactory, floatArgumentPatternFactory, doubleArgumentPatternFactory,
            enumArgumentPatternFactory, nonNullableStringArgumentPatternFactory, nullableStringArgumentPatternFactory, nonNullableObjectArgumentPatternFactory, nullableObjectArgumentPatternFactory,
            nonNullableTypeArgumentPatternFactory, nullableTypeArgumentPatternFactory, nonNullableArrayArgumentPatternFactory, nullableArrayArgumentPatternFactory);
    }

    public IArgumentPatternFactoryProvider Provider { get; }

    public IBoolArgumentPatternFactory Bool { get; }
    public IByteArgumentPatternFactory Byte { get; }
    public ISByteArgumentPatternFactory SByte { get; }
    public ICharArgumentPatternFactory Char { get; }
    public IShortArgumentPatternFactory Short { get; }
    public IUShortArgumentPatternFactory UShort { get; }
    public IIntArgumentPatternFactory Int { get; }
    public IUIntArgumentPatternFactory UInt { get; }
    public ILongArgumentPatternFactory Long { get; }
    public IULongArgumentPatternFactory ULong { get; }
    public IFloatArgumentPatternFactory Float { get; }
    public IDoubleArgumentPatternFactory Double { get; }
    public IEnumArgumentPatternFactory Enum { get; }

    public INonNullableStringArgumentPatternFactory NonNullableString { get; }
    public INullableStringArgumentPatternFactory NullableString { get; }
    public INonNullableObjectArgumentPatternFactory NonNullableObject { get; }
    public INullableObjectArgumentPatternFactory NullableObject { get; }
    public INonNullableTypeArgumentPatternFactory NonNullableType { get; }
    public INullableTypeArgumentPatternFactory NullableType { get; }
    public INonNullableArrayArgumentPatternFactory NonNullableArray { get; }
    public INullableArrayArgumentPatternFactory NullableArray { get; }

    public ProviderContext(IArgumentPatternFactoryProvider provider, IBoolArgumentPatternFactory boolArgumentPatternFactory, IByteArgumentPatternFactory byteArgumentPatternFactory, ISByteArgumentPatternFactory sbyteArgumentPatternFactory,
        ICharArgumentPatternFactory charArgumentPatternFactory, IShortArgumentPatternFactory shortArgumentPatternFactory, IUShortArgumentPatternFactory ushortArgumentPatternFactory, IIntArgumentPatternFactory intArgumentPatternFactory,
        IUIntArgumentPatternFactory uintArgumentPatternFactory, ILongArgumentPatternFactory longArgumentPatternFactory, IULongArgumentPatternFactory ulongArgumentPatternFactory, IFloatArgumentPatternFactory floatArgumentPatternFactory,
        IDoubleArgumentPatternFactory doubleArgumentPatternFactory, IEnumArgumentPatternFactory enumArgumentPatternFactory, INonNullableStringArgumentPatternFactory nonNullableStringArgumentPatternFactory,
        INullableStringArgumentPatternFactory nullableStringArgumentPatternFactory, INonNullableObjectArgumentPatternFactory nonNullableObjectArgumentPatternFactory, INullableObjectArgumentPatternFactory nullableObjectArgumentPatternFactory,
        INonNullableTypeArgumentPatternFactory nonNullableTypeArgumentPatternFactory, INullableTypeArgumentPatternFactory nullableTypeArgumentPatternFactory, INonNullableArrayArgumentPatternFactory nonNullableArrayArgumentPatternFactory,
        INullableArrayArgumentPatternFactory nullableArrayArgumentPattern)
    {
        Provider = provider;

        Byte = byteArgumentPatternFactory;
        Bool = boolArgumentPatternFactory;
        SByte = sbyteArgumentPatternFactory;
        Char = charArgumentPatternFactory;
        Short = shortArgumentPatternFactory;
        UShort = ushortArgumentPatternFactory;
        Int = intArgumentPatternFactory;
        UInt = uintArgumentPatternFactory;
        Long = longArgumentPatternFactory;
        ULong = ulongArgumentPatternFactory;
        Float = floatArgumentPatternFactory;
        Double = doubleArgumentPatternFactory;
        Enum = enumArgumentPatternFactory;

        NonNullableString = nonNullableStringArgumentPatternFactory;
        NullableString = nullableStringArgumentPatternFactory;
        NonNullableObject = nonNullableObjectArgumentPatternFactory;
        NullableObject = nullableObjectArgumentPatternFactory;
        NonNullableType = nonNullableTypeArgumentPatternFactory;
        NullableType = nullableTypeArgumentPatternFactory;
        NonNullableArray = nonNullableArrayArgumentPatternFactory;
        NullableArray = nullableArrayArgumentPattern;
    }
}
