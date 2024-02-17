namespace SharpAttributeParser.Patterns.NonNullableArrayArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var readWriteArgumentPatternFactory = Mock.Of<INonNullableReadWriteArrayArgumentPatternFactory>();
        var readOnlyArgumentPatternFactory = Mock.Of<INonNullableReadOnlyArrayArgumentPatternFactory>();

        NonNullableArrayArgumentPatternFactoryProvider provider = new(readWriteArgumentPatternFactory, readOnlyArgumentPatternFactory);

        return new(provider, readWriteArgumentPatternFactory, readOnlyArgumentPatternFactory);
    }

    public INonNullableArrayArgumentPatternFactoryProvider Provider { get; }

    public INonNullableReadWriteArrayArgumentPatternFactory ReadWrite { get; }
    public INonNullableReadOnlyArrayArgumentPatternFactory ReadOnly { get; }

    public ProviderContext(INonNullableArrayArgumentPatternFactoryProvider provider, INonNullableReadWriteArrayArgumentPatternFactory readWrite, INonNullableReadOnlyArrayArgumentPatternFactory readOnly)
    {
        Provider = provider;

        ReadWrite = readWrite;
        ReadOnly = readOnly;
    }
}
