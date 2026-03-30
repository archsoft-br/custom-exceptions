using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Unexpected;

[ExcludeFromCodeCoverage]
public class UnexpectedException : InternalServerErrorException
{
    public UnexpectedException()
    {
    }

    public UnexpectedException(string message)
        : base(message)
    {
    }

    public UnexpectedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}

