namespace SharpAttributeParser.Patterns.NullableArrayArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var readWriteArgumentPatternFactory = Mock.Of<INullableReadWriteArrayArgumentPatternFactory>();
        var readOnlyArgumentPatternFactory = Mock.Of<INullableReadOnlyArrayArgumentPatternFactory>();

        NullableArrayArgumentPatternFactoryProvider provider = new(readWriteArgumentPatternFactory, readOnlyArgumentPatternFactory);

        return new(provider, readWriteArgumentPatternFactory, readOnlyArgumentPatternFactory);
    }

    public INullableArrayArgumentPatternFactoryProvider Provider { get; }

    public INullableReadWriteArrayArgumentPatternFactory ReadWrite { get; }
    public INullableReadOnlyArrayArgumentPatternFactory ReadOnly { get; }

    public ProviderContext(INullableArrayArgumentPatternFactoryProvider provider, INullableReadWriteArrayArgumentPatternFactory readWrite, INullableReadOnlyArrayArgumentPatternFactory readOnly)
    {
        Provider = provider;

        ReadWrite = readWrite;
        ReadOnly = readOnly;
    }
}
