namespace Attribinter.Patterns.NullableArrayArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var readWrite = Mock.Of<INullableReadWriteArrayArgumentPatternFactory>();
        var readOnly = Mock.Of<INullableReadOnlyArrayArgumentPatternFactory>();

        NullableArrayArgumentPatternFactoryProvider provider = new(readWrite, readOnly);

        return new(provider, readWrite, readOnly);
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
