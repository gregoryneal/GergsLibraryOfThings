using System;

namespace GergsLibraryOfThings.gerg.things.lists.markov
{
    class ProbabilityGreaterThanOneException : Exception
    {
        public ProbabilityGreaterThanOneException() { }

        public ProbabilityGreaterThanOneException(string message)
            : base(message) { }
    }
}
