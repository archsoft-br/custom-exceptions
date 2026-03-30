using System.Diagnostics.CodeAnalysis;
using ArchSoft.Http.Exceptions;

namespace ArchSoft.CustomExceptions.Exceptions.IO;

[ExcludeFromCodeCoverage]
public class OutputException : InternalServerErrorException
{
    public OutputException()
    {
    }

    public OutputException(string message) : base(message)
    {
    }

    public OutputException(string message, Exception inner) : base(message, inner)
    {
    }
}

