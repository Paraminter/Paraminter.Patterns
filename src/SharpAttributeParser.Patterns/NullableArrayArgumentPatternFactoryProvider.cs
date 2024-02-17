namespace SharpAttributeParser.Patterns;

using System;

/// <inheritdoc cref="INullableArrayArgumentPatternFactoryProvider"/>
public sealed class NullableArrayArgumentPatternFactoryProvider : INullableArrayArgumentPatternFactoryProvider
{
    private readonly INullableReadWriteArrayArgumentPatternFactory ReadWrite;
    private readonly INullableReadOnlyArrayArgumentPatternFactory ReadOnly;

    /// <summary>Instantiates a <see cref="ArrayArgumentPatternFactoryProvider"/>, providing factories of <see cref="IArgumentPattern{T}"/> matching array-valued arguments.</summary>
    /// <param name="readWrite">The factory of <see cref="IArgumentPattern{T}"/> matching nullable array-valued arguments.</param>
    /// <param name="readOnly">The factory of <see cref="IArgumentPattern{T}"/> matching nullable read-only array-valued arguments.</param>
    public NullableArrayArgumentPatternFactoryProvider(INullableReadWriteArrayArgumentPatternFactory readWrite, INullableReadOnlyArrayArgumentPatternFactory readOnly)
    {
        ReadWrite = readWrite ?? throw new ArgumentNullException(nameof(readWrite));
        ReadOnly = readOnly ?? throw new ArgumentNullException(nameof(readOnly));
    }

    INullableReadWriteArrayArgumentPatternFactory INullableArrayArgumentPatternFactoryProvider.ReadWrite => ReadWrite;
    INullableReadOnlyArrayArgumentPatternFactory INullableArrayArgumentPatternFactoryProvider.ReadOnly => ReadOnly;
}
