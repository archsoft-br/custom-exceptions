using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Security;

[ExcludeFromCodeCoverage]
public class EncryptionException : InternalServerErrorException
{
    public EncryptionException()
    {
    }

    public EncryptionException(string message)
        : base(message)
    {
    }

    public EncryptionException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
