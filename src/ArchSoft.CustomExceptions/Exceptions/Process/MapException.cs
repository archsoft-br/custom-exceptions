using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.Process;

[ExcludeFromCodeCoverage]
public class MapException : UnprocessableEntityException
{
    public MapException()
    {
    }

    public MapException(string message) : base(message)
    {
    }

    public MapException(string message, Exception inner) : base(message, inner)
    {
    }
}

