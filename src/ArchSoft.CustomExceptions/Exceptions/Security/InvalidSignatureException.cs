using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Security;

[ExcludeFromCodeCoverage]
public class InvalidSignatureException : ForbiddenException
{
    public InvalidSignatureException()
    {
    }

    public InvalidSignatureException(string message)
        : base(message)
    {
    }

    public InvalidSignatureException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
