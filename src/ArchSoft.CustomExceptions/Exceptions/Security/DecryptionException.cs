using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Security;

[ExcludeFromCodeCoverage]
public class DecryptionException : InternalServerErrorException
{
    public DecryptionException()
    {
    }

    public DecryptionException(string message)
        : base(message)
    {
    }

    public DecryptionException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
