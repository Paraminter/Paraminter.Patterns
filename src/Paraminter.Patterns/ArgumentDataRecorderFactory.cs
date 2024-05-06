namespace Paraminter.Patterns;

using Paraminter;

using System;

/// <inheritdoc cref="IArgumentDataRecorderFactory"/>
public sealed class ArgumentDataRecorderFactory : IArgumentDataRecorderFactory
{
    /// <summary>Instantiates a <see cref="ArgumentDataRecorderFactory"/>, handling creation of pattern-independent <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/> using pattern-dependent <see cref="IArgumentDataRecorder{TParameter, TArgumentData}"/>.</summary>
    public ArgumentDataRecorderFactory() { }

    IArgumentDataRecorder<TParameter, TUnpatternedArgumentData> IArgumentDataRecorderFactory.Create<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>(IArgumentDataRecorder<TParameter, TPatternedArgumentData> patternedRecorder, IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData> pattern)
    {
        if (patternedRecorder is null)
        {
            throw new ArgumentNullException(nameof(patternedRecorder));
        }

        if (pattern is null)
        {
            throw new ArgumentNullException(nameof(pattern));
        }

        return new ArgumentDataRecorder<TParameter, TUnpatternedArgumentData, TPatternedArgumentData>(patternedRecorder, pattern);
    }

    private sealed class ArgumentDataRecorder<TParameter, TUnpatternedArgumentData, TPatternedArgumentData> : IArgumentDataRecorder<TParameter, TUnpatternedArgumentData>
    {
        private readonly IArgumentDataRecorder<TParameter, TPatternedArgumentData> UnpatternedRecorder;
        private readonly IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData> Pattern;

        public ArgumentDataRecorder(IArgumentDataRecorder<TParameter, TPatternedArgumentData> unpatternedRecorder, IArgumentPattern<TUnpatternedArgumentData, TPatternedArgumentData> pattern)
        {
            UnpatternedRecorder = unpatternedRecorder;
            Pattern = pattern;
        }

        bool IArgumentDataRecorder<TParameter, TUnpatternedArgumentData>.TryRecordData(TParameter parameter, TUnpatternedArgumentData argumentData)
        {
            if (parameter is null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            if (argumentData is null)
            {
                throw new ArgumentNullException(nameof(argumentData));
            }

            var matchResult = Pattern.TryMatch(argumentData);

            if (matchResult.WasSuccessful is false)
            {
                return false;
            }

            return UnpatternedRecorder.TryRecordData(parameter, matchResult.GetMatchedArgument());
        }
    }
}
