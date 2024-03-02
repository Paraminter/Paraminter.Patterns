namespace Attribinter.Patterns.NonNullableArrayArgumentPatternFactoryProviderCases;

using Moq;

internal sealed class ProviderContext
{
    public static ProviderContext Create()
    {
        var readWrite = Mock.Of<INonNullableReadWriteArrayArgumentPatternFactory>();
        var readOnly = Mock.Of<INonNullableReadOnlyArrayArgumentPatternFactory>();

        NonNullableArrayArgumentPatternFactoryProvider provider = new(readWrite, readOnly);

        return new(provider, readWrite, readOnly);
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
