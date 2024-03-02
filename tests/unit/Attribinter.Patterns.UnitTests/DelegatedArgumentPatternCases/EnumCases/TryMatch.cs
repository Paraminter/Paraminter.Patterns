namespace Attribinter.Patterns.DelegatedArgumentPatternCases.EnumCases;

using Moq;

using System;

using Xunit;

public sealed class TryMatch
{
    private static ArgumentPatternMatchResult<TEnum> Target<TEnum>(IArgumentPattern<TEnum> pattern, object? argument) => pattern.TryMatch(argument);

    [Fact]
    public void StringSplitOptions_StringSplitOptions_Successful() => Successful(StringSplitOptions.TrimEntries, StringSplitOptions.TrimEntries);

    [Fact]
    public void StringComparison_StringComparison_Successful() => Successful(StringComparison.Ordinal, StringComparison.Ordinal);

    [Fact]
    public void StringComparison_Int_Successful() => Successful(StringComparison.Ordinal, 4);

    [Fact]
    public void IntBasedEnum_Int_Successful() => Successful(IntEnum.None, 0);

    [Fact]
    public void IntBasedEnum_Short_Unsuccessful() => Unsuccessful<IntEnum>((short)0);

    [Fact]
    public void UIntBasedEnum_UInt_Successful() => Successful(UIntEnum.None, (uint)0);

    [Fact]
    public void UIntBasedEnum_UShort_Unsuccessful() => Unsuccessful<UIntEnum>((ushort)0);

    [Fact]
    public void LongBasedEnum_Long_Successful() => Successful(LongEnum.None, (long)0);

    [Fact]
    public void LongBasedEnum_Int_Unsuccessful() => Unsuccessful<LongEnum>(0);

    [Fact]
    public void ULongBasedEnum_ULong_Successful() => Successful(ULongEnum.None, (ulong)0);

    [Fact]
    public void ULongBasedEnum_UInt_Unsuccessful() => Unsuccessful<ULongEnum>((uint)0);

    [Fact]
    public void ShortBasedEnum_Short_Successful() => Successful(ShortEnum.None, (short)0);

    [Fact]
    public void ShortBasedEnum_SByte_Unsuccessful() => Unsuccessful<ShortEnum>((sbyte)0);

    [Fact]
    public void UShortBasedEnum_UShort_Successful() => Successful(UShortEnum.None, (ushort)0);

    [Fact]
    public void UShortBasedEnum_Byte_Unsuccessful() => Unsuccessful<UShortEnum>((byte)0);

    [Fact]
    public void ByteBasedEnum_Byte_Successful() => Successful(ByteEnum.None, (byte)0);

    [Fact]
    public void ByteBasedEnum_UShort_Unsuccessful() => Unsuccessful<ByteEnum>((ushort)0);

    [Fact]
    public void SByteBasedEnum_SByte_Successful() => Successful(SByteEnum.None, (sbyte)0);

    [Fact]
    public void SByteBasedEnum_Short_Unsuccessful() => Unsuccessful<SByteEnum>((short)0);

    [Fact]
    public void StringComparison_StringSplitOptions_Unsuccessful() => Unsuccessful<StringComparison>(StringSplitOptions.TrimEntries);

    [Fact]
    public void StringComparison_Object_Unsuccessful() => Unsuccessful<StringComparison>(Mock.Of<object>());

    [Fact]
    public void StringComparison_Null_Unsuccessful() => Unsuccessful<StringComparison>(null);

    [AssertionMethod]
    private static void Successful<TEnum>(TEnum expected, object? argument) where TEnum : Enum
    {
        var context = PatternContext<TEnum>.Create();

        var result = Target(context.Pattern, argument);

        Assert.Equal(expected, result.GetMatchedArgument());
    }

    [AssertionMethod]
    private static void Unsuccessful<TEnum>(object? argument) where TEnum : Enum
    {
        var context = PatternContext<TEnum>.Create();

        var result = Target(context.Pattern, argument);

        Assert.False(result.Successful);
    }

    private enum IntEnum
    {
        None = 0
    }

    private enum UIntEnum : uint
    {
        None = 0
    }

    private enum LongEnum : long
    {
        None = 0
    }

    private enum ULongEnum : ulong
    {
        None = 0
    }

    private enum ShortEnum : short
    {
        None = 0
    }

    private enum UShortEnum : ushort
    {
        None = 0
    }

    private enum ByteEnum : byte
    {
        None = 0
    }

    private enum SByteEnum : sbyte
    {
        None = 0
    }
}
