namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="INonNullableArrayArgumentPatternFactoryProvider"/>
public sealed class NonNullableArrayArgumentPatternFactoryProvider : INonNullableArrayArgumentPatternFactoryProvider
{
    private readonly INonNullableReadWriteArrayArgumentPatternFactory ReadWrite;
    private readonly INonNullableReadOnlyArrayArgumentPatternFactory ReadOnly;

    /// <summary>Instantiates a <see cref="ArrayArgumentPatternFactoryProvider"/>, providing factories of <see cref="IArgumentPattern{T}"/> matching array-valued arguments.</summary>
    /// <param name="readWrite">The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable array-valued arguments.</param>
    /// <param name="readOnly">The factory of <see cref="IArgumentPattern{T}"/> matching non-nullable read-only array-valued arguments.</param>
    public NonNullableArrayArgumentPatternFactoryProvider(INonNullableReadWriteArrayArgumentPatternFactory readWrite, INonNullableReadOnlyArrayArgumentPatternFactory readOnly)
    {
        ReadWrite = readWrite ?? throw new ArgumentNullException(nameof(readWrite));
        ReadOnly = readOnly ?? throw new ArgumentNullException(nameof(readOnly));
    }

    INonNullableReadWriteArrayArgumentPatternFactory INonNullableArrayArgumentPatternFactoryProvider.ReadWrite => ReadWrite;
    INonNullableReadOnlyArrayArgumentPatternFactory INonNullableArrayArgumentPatternFactoryProvider.ReadOnly => ReadOnly;
}
