namespace Attribinter.Patterns;

using Attribinter;

using System;

/// <inheritdoc cref="IArgumentRecorderFactory"/>
public sealed class ArgumentRecorderFactory : IArgumentRecorderFactory
{
    /// <summary>Instantiates a <see cref="ArgumentRecorderFactory"/>, handling creation of pattern-independent <see cref="IArgumentRecorder{TParameter, TData}"/> using pattern-dependent ones.</summary>
    public ArgumentRecorderFactory() { }

    IArgumentRecorder<TParameter, TIn> IArgumentRecorderFactory.Create<TParameter, TIn, TOut>(IArgumentRecorder<TParameter, TOut> patternedRecorder, IArgumentPattern<TIn, TOut> pattern)
    {
        if (patternedRecorder is null)
        {
            throw new ArgumentNullException(nameof(patternedRecorder));
        }

        if (pattern is null)
        {
            throw new ArgumentNullException(nameof(pattern));
        }

        return new ArgumentRecorder<TParameter, TIn, TOut>(patternedRecorder, pattern);
    }

    private sealed class ArgumentRecorder<TParameter, TIn, TOut> : IArgumentRecorder<TParameter, TIn>
    {
        private readonly IArgumentRecorder<TParameter, TOut> UnpatternedRecorder;
        private readonly IArgumentPattern<TIn, TOut> Pattern;

        public ArgumentRecorder(IArgumentRecorder<TParameter, TOut> unpatternedRecorder, IArgumentPattern<TIn, TOut> pattern)
        {
            UnpatternedRecorder = unpatternedRecorder;
            Pattern = pattern;
        }

        bool IArgumentRecorder<TParameter, TIn>.TryRecordData(TParameter parameter, TIn data)
        {
            if (parameter is null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }

            if (data is null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            var matchResult = Pattern.TryMatch(data);

            if (matchResult.Successful is false)
            {
                return false;
            }

            return UnpatternedRecorder.TryRecordData(parameter, matchResult.GetMatchedArgument());
        }
    }
}
