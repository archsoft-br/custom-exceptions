using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Resource;

[ExcludeFromCodeCoverage]
public class ResourceAlreadyExistsException : ConflictException
{
    public ResourceAlreadyExistsException()
    {
    }

    public ResourceAlreadyExistsException(string message)
        : base(message)
    {
    }

    public ResourceAlreadyExistsException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
